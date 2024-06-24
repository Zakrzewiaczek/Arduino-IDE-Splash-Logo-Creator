namespace Arduino_IDE_Splash_Logo_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.arduino_patth_lbl = new System.Windows.Forms.Label();
            this.arduino_path = new System.Windows.Forms.TextBox();
            this.set_default_path = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.anim_linear = new System.Windows.Forms.RadioButton();
            this.anim_ease = new System.Windows.Forms.RadioButton();
            this.anim_step = new System.Windows.Forms.RadioButton();
            this.ease = new System.Windows.Forms.RadioButton();
            this.ease_in = new System.Windows.Forms.RadioButton();
            this.ease_out = new System.Windows.Forms.RadioButton();
            this.step_start = new System.Windows.Forms.RadioButton();
            this.step_end = new System.Windows.Forms.RadioButton();
            this.anim_none = new System.Windows.Forms.RadioButton();
            this.ease_in_out = new System.Windows.Forms.RadioButton();
            this.step_panel = new System.Windows.Forms.Panel();
            this.ease_panel = new System.Windows.Forms.Panel();
            this.anim_panel = new System.Windows.Forms.GroupBox();
            this.anim_reset_all = new System.Windows.Forms.Button();
            this.sec2 = new System.Windows.Forms.Label();
            this.sec1 = new System.Windows.Forms.Label();
            this.infinite_anim = new System.Windows.Forms.CheckBox();
            this.anim_delay = new System.Windows.Forms.NumericUpDown();
            this.anim_duration = new System.Windows.Forms.NumericUpDown();
            this.anim_iteration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.animation_points = new System.Windows.Forms.DataGridView();
            this.logo_panel = new System.Windows.Forms.GroupBox();
            this.align_v = new System.Windows.Forms.ComboBox();
            this.align_h = new System.Windows.Forms.ComboBox();
            this.align_h_lbl = new System.Windows.Forms.Label();
            this.align_v_lbl = new System.Windows.Forms.Label();
            this.px2 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.px1 = new System.Windows.Forms.Label();
            this.height_lbl = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.width_lbl = new System.Windows.Forms.Label();
            this.addPoint = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.step_panel.SuspendLayout();
            this.ease_panel.SuspendLayout();
            this.anim_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anim_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim_iteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animation_points)).BeginInit();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // arduino_patth_lbl
            // 
            resources.ApplyResources(this.arduino_patth_lbl, "arduino_patth_lbl");
            this.arduino_patth_lbl.Name = "arduino_patth_lbl";
            // 
            // arduino_path
            // 
            resources.ApplyResources(this.arduino_path, "arduino_path");
            this.arduino_path.Name = "arduino_path";
            // 
            // set_default_path
            // 
            resources.ApplyResources(this.set_default_path, "set_default_path");
            this.set_default_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.set_default_path.Name = "set_default_path";
            this.set_default_path.UseVisualStyleBackColor = true;
            this.set_default_path.Click += new System.EventHandler(this.set_default_path_Click);
            // 
            // upload
            // 
            resources.ApplyResources(this.upload, "upload");
            this.upload.ForeColor = System.Drawing.Color.Black;
            this.upload.Name = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // anim_linear
            // 
            resources.ApplyResources(this.anim_linear, "anim_linear");
            this.anim_linear.Name = "anim_linear";
            this.anim_linear.UseVisualStyleBackColor = true;
            this.anim_linear.CheckedChanged += new System.EventHandler(this.AnimModeChanged);
            // 
            // anim_ease
            // 
            resources.ApplyResources(this.anim_ease, "anim_ease");
            this.anim_ease.Checked = true;
            this.anim_ease.Name = "anim_ease";
            this.anim_ease.TabStop = true;
            this.anim_ease.UseVisualStyleBackColor = true;
            this.anim_ease.CheckedChanged += new System.EventHandler(this.AnimModeChanged);
            // 
            // anim_step
            // 
            resources.ApplyResources(this.anim_step, "anim_step");
            this.anim_step.Name = "anim_step";
            this.anim_step.UseVisualStyleBackColor = true;
            this.anim_step.CheckedChanged += new System.EventHandler(this.AnimModeChanged);
            // 
            // ease
            // 
            resources.ApplyResources(this.ease, "ease");
            this.ease.Checked = true;
            this.ease.Name = "ease";
            this.ease.TabStop = true;
            this.ease.UseVisualStyleBackColor = true;
            // 
            // ease_in
            // 
            resources.ApplyResources(this.ease_in, "ease_in");
            this.ease_in.Name = "ease_in";
            this.ease_in.UseVisualStyleBackColor = true;
            // 
            // ease_out
            // 
            resources.ApplyResources(this.ease_out, "ease_out");
            this.ease_out.Name = "ease_out";
            this.ease_out.UseVisualStyleBackColor = true;
            // 
            // step_start
            // 
            resources.ApplyResources(this.step_start, "step_start");
            this.step_start.Checked = true;
            this.step_start.Name = "step_start";
            this.step_start.TabStop = true;
            this.step_start.UseVisualStyleBackColor = true;
            // 
            // step_end
            // 
            resources.ApplyResources(this.step_end, "step_end");
            this.step_end.Name = "step_end";
            this.step_end.UseVisualStyleBackColor = true;
            // 
            // anim_none
            // 
            resources.ApplyResources(this.anim_none, "anim_none");
            this.anim_none.Name = "anim_none";
            this.anim_none.UseVisualStyleBackColor = true;
            this.anim_none.CheckedChanged += new System.EventHandler(this.AnimModeChanged);
            // 
            // ease_in_out
            // 
            resources.ApplyResources(this.ease_in_out, "ease_in_out");
            this.ease_in_out.Name = "ease_in_out";
            this.ease_in_out.UseVisualStyleBackColor = true;
            // 
            // step_panel
            // 
            this.step_panel.Controls.Add(this.step_start);
            this.step_panel.Controls.Add(this.step_end);
            resources.ApplyResources(this.step_panel, "step_panel");
            this.step_panel.Name = "step_panel";
            // 
            // ease_panel
            // 
            this.ease_panel.Controls.Add(this.ease);
            this.ease_panel.Controls.Add(this.ease_in);
            this.ease_panel.Controls.Add(this.ease_in_out);
            this.ease_panel.Controls.Add(this.ease_out);
            resources.ApplyResources(this.ease_panel, "ease_panel");
            this.ease_panel.Name = "ease_panel";
            // 
            // anim_panel
            // 
            this.anim_panel.Controls.Add(this.anim_reset_all);
            this.anim_panel.Controls.Add(this.sec2);
            this.anim_panel.Controls.Add(this.sec1);
            this.anim_panel.Controls.Add(this.infinite_anim);
            this.anim_panel.Controls.Add(this.step_panel);
            this.anim_panel.Controls.Add(this.ease_panel);
            this.anim_panel.Controls.Add(this.anim_delay);
            this.anim_panel.Controls.Add(this.anim_duration);
            this.anim_panel.Controls.Add(this.anim_iteration);
            this.anim_panel.Controls.Add(this.label1);
            this.anim_panel.Controls.Add(this.label3);
            this.anim_panel.Controls.Add(this.label2);
            this.anim_panel.Controls.Add(this.anim_none);
            this.anim_panel.Controls.Add(this.anim_step);
            this.anim_panel.Controls.Add(this.anim_ease);
            this.anim_panel.Controls.Add(this.anim_linear);
            resources.ApplyResources(this.anim_panel, "anim_panel");
            this.anim_panel.Name = "anim_panel";
            this.anim_panel.TabStop = false;
            // 
            // anim_reset_all
            // 
            resources.ApplyResources(this.anim_reset_all, "anim_reset_all");
            this.anim_reset_all.Name = "anim_reset_all";
            this.anim_reset_all.UseVisualStyleBackColor = true;
            this.anim_reset_all.Click += new System.EventHandler(this.AnimResetClick);
            // 
            // sec2
            // 
            resources.ApplyResources(this.sec2, "sec2");
            this.sec2.Name = "sec2";
            // 
            // sec1
            // 
            resources.ApplyResources(this.sec1, "sec1");
            this.sec1.Name = "sec1";
            // 
            // infinite_anim
            // 
            resources.ApplyResources(this.infinite_anim, "infinite_anim");
            this.infinite_anim.Checked = true;
            this.infinite_anim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.infinite_anim.Name = "infinite_anim";
            this.infinite_anim.UseVisualStyleBackColor = true;
            this.infinite_anim.CheckedChanged += new System.EventHandler(this.InfiniteAnimChanged);
            // 
            // anim_delay
            // 
            resources.ApplyResources(this.anim_delay, "anim_delay");
            this.anim_delay.DecimalPlaces = 1;
            this.anim_delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.anim_delay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.anim_delay.Name = "anim_delay";
            // 
            // anim_duration
            // 
            resources.ApplyResources(this.anim_duration, "anim_duration");
            this.anim_duration.DecimalPlaces = 1;
            this.anim_duration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.anim_duration.Name = "anim_duration";
            this.anim_duration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // anim_iteration
            // 
            resources.ApplyResources(this.anim_iteration, "anim_iteration");
            this.anim_iteration.Name = "anim_iteration";
            this.anim_iteration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // animation_points
            // 
            this.animation_points.AllowUserToAddRows = false;
            this.animation_points.AllowUserToResizeColumns = false;
            this.animation_points.AllowUserToResizeRows = false;
            resources.ApplyResources(this.animation_points, "animation_points");
            this.animation_points.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.animation_points.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.animation_points.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.animation_points.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.animation_points.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percent,
            this.posX,
            this.posY,
            this.rotate,
            this.scale});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.animation_points.DefaultCellStyle = dataGridViewCellStyle6;
            this.animation_points.Name = "animation_points";
            this.animation_points.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnimPointsCellValueChanged);
            // 
            // logo_panel
            // 
            this.logo_panel.Controls.Add(this.align_v);
            this.logo_panel.Controls.Add(this.align_h);
            this.logo_panel.Controls.Add(this.align_h_lbl);
            this.logo_panel.Controls.Add(this.align_v_lbl);
            this.logo_panel.Controls.Add(this.px2);
            this.logo_panel.Controls.Add(this.width);
            this.logo_panel.Controls.Add(this.px1);
            this.logo_panel.Controls.Add(this.height_lbl);
            this.logo_panel.Controls.Add(this.height);
            this.logo_panel.Controls.Add(this.width_lbl);
            resources.ApplyResources(this.logo_panel, "logo_panel");
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.TabStop = false;
            // 
            // align_v
            // 
            resources.ApplyResources(this.align_v, "align_v");
            this.align_v.FormattingEnabled = true;
            this.align_v.Items.AddRange(new object[] {
            resources.GetString("align_v.Items"),
            resources.GetString("align_v.Items1"),
            resources.GetString("align_v.Items2")});
            this.align_v.Name = "align_v";
            // 
            // align_h
            // 
            resources.ApplyResources(this.align_h, "align_h");
            this.align_h.FormattingEnabled = true;
            this.align_h.Items.AddRange(new object[] {
            resources.GetString("align_h.Items"),
            resources.GetString("align_h.Items1"),
            resources.GetString("align_h.Items2")});
            this.align_h.Name = "align_h";
            // 
            // align_h_lbl
            // 
            resources.ApplyResources(this.align_h_lbl, "align_h_lbl");
            this.align_h_lbl.Name = "align_h_lbl";
            // 
            // align_v_lbl
            // 
            resources.ApplyResources(this.align_v_lbl, "align_v_lbl");
            this.align_v_lbl.Name = "align_v_lbl";
            // 
            // px2
            // 
            resources.ApplyResources(this.px2, "px2");
            this.px2.Name = "px2";
            // 
            // width
            // 
            resources.ApplyResources(this.width, "width");
            this.width.DecimalPlaces = 1;
            this.width.Name = "width";
            this.width.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // px1
            // 
            resources.ApplyResources(this.px1, "px1");
            this.px1.Name = "px1";
            // 
            // height_lbl
            // 
            resources.ApplyResources(this.height_lbl, "height_lbl");
            this.height_lbl.Name = "height_lbl";
            // 
            // height
            // 
            resources.ApplyResources(this.height, "height");
            this.height.DecimalPlaces = 1;
            this.height.Name = "height";
            this.height.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // width_lbl
            // 
            resources.ApplyResources(this.width_lbl, "width_lbl");
            this.width_lbl.Name = "width_lbl";
            // 
            // addPoint
            // 
            resources.ApplyResources(this.addPoint, "addPoint");
            this.addPoint.Name = "addPoint";
            this.addPoint.UseVisualStyleBackColor = true;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // clear
            // 
            resources.ApplyResources(this.clear, "clear");
            this.clear.Name = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // reset
            // 
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // percent
            // 
            this.percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.percent.FillWeight = 63.45178F;
            resources.ApplyResources(this.percent, "percent");
            this.percent.Name = "percent";
            this.percent.ReadOnly = true;
            this.percent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.percent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // posX
            // 
            dataGridViewCellStyle2.Format = "N1";
            this.posX.DefaultCellStyle = dataGridViewCellStyle2;
            this.posX.FillWeight = 109.1371F;
            resources.ApplyResources(this.posX, "posX");
            this.posX.Name = "posX";
            this.posX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // posY
            // 
            dataGridViewCellStyle3.Format = "N1";
            this.posY.DefaultCellStyle = dataGridViewCellStyle3;
            this.posY.FillWeight = 109.1371F;
            resources.ApplyResources(this.posY, "posY");
            this.posY.Name = "posY";
            this.posY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rotate
            // 
            dataGridViewCellStyle4.Format = "N1";
            this.rotate.DefaultCellStyle = dataGridViewCellStyle4;
            this.rotate.FillWeight = 109.1371F;
            resources.ApplyResources(this.rotate, "rotate");
            this.rotate.Name = "rotate";
            this.rotate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rotate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // scale
            // 
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = "1";
            this.scale.DefaultCellStyle = dataGridViewCellStyle5;
            this.scale.FillWeight = 109.1371F;
            resources.ApplyResources(this.scale, "scale");
            this.scale.Name = "scale";
            this.scale.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.scale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.reset);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.logo_panel);
            this.Controls.Add(this.animation_points);
            this.Controls.Add(this.anim_panel);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.set_default_path);
            this.Controls.Add(this.arduino_path);
            this.Controls.Add(this.arduino_patth_lbl);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.step_panel.ResumeLayout(false);
            this.step_panel.PerformLayout();
            this.ease_panel.ResumeLayout(false);
            this.ease_panel.PerformLayout();
            this.anim_panel.ResumeLayout(false);
            this.anim_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anim_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim_iteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animation_points)).EndInit();
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arduino_patth_lbl;
        private System.Windows.Forms.TextBox arduino_path;
        private System.Windows.Forms.Button set_default_path;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.RadioButton anim_linear;
        private System.Windows.Forms.RadioButton anim_ease;
        private System.Windows.Forms.RadioButton anim_step;
        private System.Windows.Forms.RadioButton ease;
        private System.Windows.Forms.RadioButton ease_in;
        private System.Windows.Forms.RadioButton ease_out;
        private System.Windows.Forms.RadioButton step_start;
        private System.Windows.Forms.RadioButton step_end;
        private System.Windows.Forms.RadioButton anim_none;
        private System.Windows.Forms.RadioButton ease_in_out;
        private System.Windows.Forms.Panel step_panel;
        private System.Windows.Forms.Panel ease_panel;
        private System.Windows.Forms.GroupBox anim_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox infinite_anim;
        private System.Windows.Forms.NumericUpDown anim_delay;
        private System.Windows.Forms.NumericUpDown anim_duration;
        private System.Windows.Forms.NumericUpDown anim_iteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sec2;
        private System.Windows.Forms.Label sec1;
        private System.Windows.Forms.Button anim_reset_all;
        private System.Windows.Forms.DataGridView animation_points;
        private System.Windows.Forms.GroupBox logo_panel;
        private System.Windows.Forms.Label px2;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label px1;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label width_lbl;
        private System.Windows.Forms.ComboBox align_h;
        private System.Windows.Forms.Label align_h_lbl;
        private System.Windows.Forms.Label align_v_lbl;
        private System.Windows.Forms.ComboBox align_v;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn posX;
        private System.Windows.Forms.DataGridViewTextBoxColumn posY;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scale;
    }
}

