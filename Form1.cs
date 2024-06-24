using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Arduino_IDE_Splash_Logo_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            reset_Click(new object(), new EventArgs());
            AnimModeChanged(new object(), new EventArgs());
            set_default_path_Click(new object(), new EventArgs());
        }

        private void AnimModeChanged(object sender, EventArgs e)
        {
            step_panel.Enabled = anim_step.Checked;
            ease_panel.Enabled = anim_ease.Checked;
        }
        private void InfiniteAnimChanged(object sender, EventArgs e)
        {
            anim_iteration.Enabled = !infinite_anim.Checked;
        }
        private void AnimResetClick(object sender, EventArgs e)
        {
            anim_iteration.Value = 1;
            infinite_anim.Checked = true;

            anim_duration.Value = 2;
            anim_delay.Value = 0;

            anim_ease.Checked = true;
            ease.Checked = true;
            step_start.Checked = true;
        }
        private void AnimPointsCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = animation_points.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string value = (string)cell.Value;

                try
                {
                    if(e.ColumnIndex == 2)
                        int.Parse(value);
                    else
                        float.Parse(value);
                }
                catch
                {
                    cell.Value = "0";
                }
            }
        }
        private void addPoint_Click(object sender, EventArgs e)
        {
            animation_points.Rows.Add("0", "0", "0", "0", "1");

            for(int row = 0; row < animation_points.Rows.Count; row++)
            {
                animation_points.Rows[row].Cells[0].Value = (row * 100 / (animation_points.Rows.Count - 1)).ToString();
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            animation_points.Rows.Clear();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            clear_Click(sender, e);

            animation_points.Rows.Add("0",   "0", "0", "0",   "1");
            animation_points.Rows.Add("50",  "0", "0", "180", "1");
            animation_points.Rows.Add("100", "0", "0", "360", "1");
        }
        private void set_default_path_Click(object sender, EventArgs e)
        {
            arduino_path.Text = Properties.Settings.DefaultArduinoIDEPath;
        }
        
        private void upload_Click(object sender, EventArgs e)
        {
            if(!new Regex(@"^(([a-zA-Z]\:)|(\\))(\\{1}|((\\{1})[^\\]([^/:*?<>""|]*))+)$").IsMatch(arduino_path.Text))
            {
                MessageBox.Show("Invalid path to Arduino IDE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                set_default_path_Click(sender, e);

                return;
            }

            string mode = "None";
            #region Mode selection

            if (anim_linear.Checked)
                mode = "linear";
            else if(anim_ease.Checked)
            {
                if(ease.Checked)
                    mode = "ease";
                else if (ease_in.Checked)
                    mode = "ease-in";
                else if (ease_out.Checked)
                    mode = "ease-out";
                else
                    mode = "ease-in-out";
            }
            else if(anim_step.Checked)
            {
                if(step_start.Checked)
                    mode = "step-start";
                else if(step_end.Checked)
                    mode = "step-end";
            }

            #endregion

            string output = FileCreator.CreateFileContent(animation_points, new string[] { align_h.Text, align_v.Text }, new decimal[] { width.Value, height.Value },
                (float)anim_delay.Value, (mode == "None") ? 0 : (float)anim_duration.Value, (int)anim_iteration.Value, mode, infinite_anim.Checked);

            try
            {
                #region First file

                string path = Path.Combine(arduino_path.Text, @"resources\app\src-gen\frontend\index.html");
            
                if(File.Exists(path))
                    File.Delete(path);

                StreamWriter sw = new StreamWriter(path);

                sw.Write(output);
                sw.Flush();
                sw.Close();

                #endregion
                #region Second file

                path = Path.Combine(arduino_path.Text, @"resources\app\lib\frontend\index.html");

                if (File.Exists(path))
                    File.Delete(path);

                sw = new StreamWriter(path);

                sw.Write(output);
                sw.Flush();
                sw.Close();

                #endregion

                MessageBox.Show("Overwrite complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while writing to file:\r\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
