using System.Windows.Forms;

namespace Arduino_IDE_Splash_Logo_Creator
{
    public static class FileCreator
    {
        public static string CreateFileContent(DataGridView tabela, string[] align, decimal[] size, float delay, float duration, int iteration, string anim_mode, bool infinite) //Horizontal, Vertical      //Width, Height
        {
            int parts = tabela.Rows.Count;
            int partSize = 100 / (parts - 1);

            #region Align

            string output = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n  <meta name=\"apple-mobile-web-app-capable\" content=\"yes\">\r\n  <title>Arduino IDE</title>\r\n</head>\r\n\r\n<body>\r\n    <div class=\"theia-preload\"><head>\r\n    <style>\r\n        /* The colors are hard-coded and based on the `editor.background` and `editor.foreground` values from `./arduino-ide-extension/src/browser/data/default.color-theme.json` */\r\n        @media (prefers-color-scheme: light) {\r\n            html {\r\n                background: #ffffff;\r\n            }\r\n        }\r\n\r\n        /* The colors are hard-coded and based on the `editor.background` and `editor.foreground` values from `./arduino-ide-extension/src/browser/data/dark.color-theme.json` */\r\n        @media (prefers-color-scheme: dark) {\r\n            html {\r\n                background: #1f272a;\r\n            }\r\n        }\r\n\r\n        .theia-preload {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            right: 0;\r\n            bottom: 0;\r\n\r\n            /* Above styles copied from https://github.com/eclipse-theia/theia/blob/5aeef6c0c683b4e91713ab736957e6655b486adc/packages/core/src/browser/style/index.css#L147-L161 */\r\n            /* Otherwise, there is a flickering when Theia's CSS loads. */\r\n\r\n            background-image: none;\r\n        }\r\n\r\n        .theia-preload::after {\r\n            /* remove default loading animation */\r\n            content: none;\r\n        }\r\n\r\n        .spinner-container {\r\n            display: flex;\r\n            flex-direction: center;\r\n            align-self: center;\r\n";

            output += $"            justify-content: {align[0].ToLower()};\r\n";
            output += "            height: 100vh;\r\n            width: 100vw;\r\n        }\r\n\r\n        .custom-spinner {\r\n";

            #region string verticalAlign

            string verticalAlign = "left";
            if (align[1] == "Middle")
                verticalAlign = "center";
            else if (align[1] == "Bottom")
                verticalAlign = "right";

            #endregion
            output += $"            align-self: {verticalAlign}\r\n";

            output += "        }\r\n\r\n        .custom-spinner svg {\r\n";

            #endregion
            #region .custom-spinner svg

            string iterationString = infinite ? "infinite" : iteration.ToString();

            output += $"            width: {size[0].ToString().Replace(",", ".").Replace(".0", "")}vw;\r\n";
            output += $"            height: {size[1].ToString().Replace(",", ".").Replace(".0", "")}vh;\r\n";
            output += $"            animation-delay: {delay.ToString().Replace(",", ".").Replace(".0", "")}s;\r\n";
            output += $"            animation-duration: {duration.ToString().Replace(",", ".").Replace(".0", "")}s;\r\n";
            output += $"            animation-iteration-count: {iterationString};\r\n";
            output +=  "            animation-name: preload-spinner;\r\n";
            output += $"            animation-timing-function: {anim_mode.ToLower()};\r\n";

            output += "        }\r\n\r\n        @keyframes preload-spinner {";

            #endregion
            #region @keyframes preload-spinner

            for(int times = 0; times < parts; times++)
            {
                string translateX = (string)tabela.Rows[times].Cells[1].Value; translateX = (translateX ?? "0").Replace(",", "."); //If null, set to "0", replace "," with "."
                string translateY = (string)tabela.Rows[times].Cells[2].Value; translateY = (translateY ?? "0").Replace(",", "."); //If null, set to "0", replace "," with "."

                string rotate = (string)tabela.Rows[times].Cells[3].Value; rotate = rotate ?? "0"; //If null, set to "0"
                string scale = (string)tabela.Rows[times].Cells[4].Value; scale = (scale ?? "1").Replace(",", "."); //If null, set to "1", replace "," with "."

                output += $"\r\n            {times * partSize}% {{\r\n                transform: ";
                output += $"translate({translateX}px, {translateY}px) ";
                output += $"rotate({rotate}deg) ";
                output += $"scale({scale});\r\n            }}\r\n";
            }

            output += "        }\r\n\r\n    </style>\r\n</head>\r\n\r\n<body>\r\n    <div class=\"spinner-container\">\r\n        <div class=\"custom-spinner\">\r\n            <svg\r\n                id=\"spinner\"\r\n                xmlns=\"http://www.w3.org/2000/svg\"\r\n                width=\"2499\"\r\n                height=\"2500\"\r\n                viewBox=\"0 0 1372.201 1372.684\"\r\n            >\r\n                <path\r\n                    fill=\"#00979D\"\r\n                    stroke=\"#81C9CB\"\r\n                    stroke-width=\".932\"\r\n                    stroke-miterlimit=\"10\"\r\n                    d=\"M1371.701 686.024c0 378.658-306.972 685.605-685.549 685.605C307.451 1371.629.5 1064.682.5 686.024.5 307.455 307.451.483 686.152.483c378.594.001 685.549 306.972 685.549 685.541z\"\r\n                />\r\n                <linearGradient\r\n                    id=\"a\"\r\n                    gradientUnits=\"userSpaceOnUse\"\r\n                    x1=\"-16.3\"\r\n                    y1=\"16.071\"\r\n                    x2=\"1354.901\"\r\n                    y2=\"16.071\"\r\n                    gradientTransform=\"matrix(1 0 0 -1 16.8 702.696)\"\r\n                >\r\n                    <stop offset=\".117\" stop-color=\"#fff\" stop-opacity=\"0\" />\r\n                    <stop\r\n                        offset=\".252\"\r\n                        stop-color=\"#c0d1d3\"\r\n                        stop-opacity=\".153\"\r\n                    />\r\n                    <stop\r\n                        offset=\".387\"\r\n                        stop-color=\"#91b3b7\"\r\n                        stop-opacity=\".306\"\r\n                    />\r\n                    <stop\r\n                        offset=\".52\"\r\n                        stop-color=\"#6d9fa3\"\r\n                        stop-opacity=\".457\"\r\n                    />\r\n                    <stop\r\n                        offset=\".65\"\r\n                        stop-color=\"#4d9195\"\r\n                        stop-opacity=\".604\"\r\n                    />\r\n                    <stop\r\n                        offset=\".776\"\r\n                        stop-color=\"#30888b\"\r\n                        stop-opacity=\".746\"\r\n                    />\r\n                    <stop\r\n                        offset=\".895\"\r\n                        stop-color=\"#148386\"\r\n                        stop-opacity=\".881\"\r\n                    />\r\n                    <stop offset=\"1\" stop-color=\"#008184\" />\r\n                </linearGradient>\r\n                <linearGradient\r\n                    id=\"b\"\r\n                    gradientUnits=\"userSpaceOnUse\"\r\n                    x1=\"-16.8\"\r\n                    y1=\"16.071\"\r\n                    x2=\"1355.401\"\r\n                    y2=\"16.071\"\r\n                    gradientTransform=\"matrix(1 0 0 -1 16.8 702.696)\"\r\n                >\r\n                    <stop offset=\"0\" stop-color=\"#fff\" stop-opacity=\"0\" />\r\n                    <stop\r\n                        offset=\".153\"\r\n                        stop-color=\"#c0d1d3\"\r\n                        stop-opacity=\".153\"\r\n                    />\r\n                    <stop\r\n                        offset=\".306\"\r\n                        stop-color=\"#91b3b7\"\r\n                        stop-opacity=\".306\"\r\n                    />\r\n                    <stop\r\n                        offset=\".457\"\r\n                        stop-color=\"#6d9fa3\"\r\n                        stop-opacity=\".457\"\r\n                    />\r\n                    <stop\r\n                        offset=\".604\"\r\n                        stop-color=\"#4d9195\"\r\n                        stop-opacity=\".604\"\r\n                    />\r\n                    <stop\r\n                        offset=\".746\"\r\n                        stop-color=\"#30888b\"\r\n                        stop-opacity=\".746\"\r\n                    />\r\n                    <stop\r\n                        offset=\".881\"\r\n                        stop-color=\"#148386\"\r\n                        stop-opacity=\".881\"\r\n                    />\r\n                    <stop offset=\"1\" stop-color=\"#008184\" />\r\n                </linearGradient>\r\n                <path\r\n                    opacity=\".5\"\r\n                    fill=\"url(#a)\"\r\n                    stroke=\"url(#b)\"\r\n                    stroke-miterlimit=\"10\"\r\n                    d=\"M1371.701 686.595c0 378.65-306.972 685.606-685.549 685.606C307.451 1372.201.5 1065.23.5 686.595.5 308.019 307.451 1.048 686.152 1.048c378.594.016 685.549 306.97 685.549 685.547z\"\r\n                />\r\n                <g fill=\"#FFF\">\r\n                    <path\r\n                        d=\"M947.959 931.196c-12.909 0-26.127-.929-39.127-2.864-108.978-15.554-181.848-93.822-222.665-153.989-40.946 60.166-113.811 138.512-222.74 154.045a275.864 275.864 0 0 1-39.133 2.785c-67.753 0-131.358-25.217-179.201-71.003-48.299-46.165-74.951-108.114-74.951-174.171 0-66.14 26.651-128.004 75.021-174.253 47.797-45.793 111.449-70.936 179.231-70.936 12.918 0 26.067.928 39.023 2.783 108.932 15.535 181.794 93.813 222.743 153.99 40.825-60.177 113.689-138.432 222.658-153.99 13-1.863 26.148-2.783 39.066-2.783 67.753 0 131.401 25.208 179.197 70.936 48.345 46.249 74.937 108.113 74.937 174.253 0 66.057-26.524 128.006-74.868 174.171-47.881 45.785-111.434 71.026-179.191 71.026M734.42 686.024c21.283 40.534 84.067 141.676 186.692 156.375 8.984 1.236 18.028 1.923 26.839 1.923 92.185 0 167.225-71.002 167.225-158.322s-75.023-158.321-167.291-158.321c-8.812 0-17.853.629-26.753 1.921-102.644 14.664-165.428 115.806-186.712 156.424M424.393 527.702c-92.308 0-167.36 70.998-167.36 158.321 0 87.305 75.021 158.322 167.245 158.322 8.852 0 17.897-.688 26.879-1.922 102.629-14.697 165.394-115.783 186.689-156.375-21.237-40.535-84.061-141.761-186.689-156.376-8.877-1.341-17.945-1.97-26.764-1.97\"\r\n                    />\r\n                    <path\r\n                        d=\"M354.37 662.051h152.625v49.181H354.37zM1016.484 662.051h-51.671v-51.747h-49.348v51.747h-51.648v49.181h51.648v51.737h49.348v-51.737h51.671z\"\r\n                    />\r\n                </g>\r\n            </svg>\r\n        </div>\r\n    </div>\r\n</body>\r\n</div>\r\n    <script type=\"text/javascript\" src=\"./bundle.js\" charset=\"utf-8\"></script>\r\n</body>\r\n\r\n</html>";
            
            #endregion

            return output;
        }
    }
}
