
namespace Integration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBoxPy = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.LoadExtension = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btnCannyEdge = new System.Windows.Forms.Button();
            this.btnSobelEdge = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxFactor1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBoxFactor2 = new System.Windows.Forms.TextBox();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.btnSharpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.Location = new System.Drawing.Point(16, 160);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(623, 618);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBoxPy
            // 
            this.pictureBoxPy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPy.Location = new System.Drawing.Point(647, 160);
            this.pictureBoxPy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPy.Name = "pictureBoxPy";
            this.pictureBoxPy.Size = new System.Drawing.Size(623, 618);
            this.pictureBoxPy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPy.TabIndex = 2;
            this.pictureBoxPy.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpload.Location = new System.Drawing.Point(36, 37);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(129, 76);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrightness
            // 
            this.btnBrightness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrightness.Location = new System.Drawing.Point(295, 37);
            this.btnBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(113, 76);
            this.btnBrightness.TabIndex = 4;
            this.btnBrightness.Text = "Brightness";
            this.btnBrightness.UseVisualStyleBackColor = false;
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNegative.Location = new System.Drawing.Point(659, 37);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(113, 76);
            this.btnNegative.TabIndex = 5;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = false;
            // 
            // LoadExtension
            // 
            this.LoadExtension.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadExtension.Location = new System.Drawing.Point(173, 37);
            this.LoadExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadExtension.Name = "LoadExtension";
            this.LoadExtension.Size = new System.Drawing.Size(113, 76);
            this.LoadExtension.TabIndex = 6;
            this.LoadExtension.Text = "Load Python FIles";
            this.LoadExtension.UseVisualStyleBackColor = false;
            this.LoadExtension.Click += new System.EventHandler(this.LoadExtension_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGray.Location = new System.Drawing.Point(537, 37);
            this.btnGray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(113, 76);
            this.btnGray.TabIndex = 7;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = false;
            // 
            // btnContrast
            // 
            this.btnContrast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContrast.Location = new System.Drawing.Point(416, 37);
            this.btnContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(113, 76);
            this.btnContrast.TabIndex = 8;
            this.btnContrast.Text = "Contrast";
            this.btnContrast.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(241, 807);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(2, 26);
            this.label.TabIndex = 10;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCannyEdge
            // 
            this.btnCannyEdge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCannyEdge.Location = new System.Drawing.Point(780, 37);
            this.btnCannyEdge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCannyEdge.Name = "btnCannyEdge";
            this.btnCannyEdge.Size = new System.Drawing.Size(113, 76);
            this.btnCannyEdge.TabIndex = 11;
            this.btnCannyEdge.Text = "Canny Edge";
            this.btnCannyEdge.UseVisualStyleBackColor = false;
            // 
            // btnSobelEdge
            // 
            this.btnSobelEdge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSobelEdge.Location = new System.Drawing.Point(901, 37);
            this.btnSobelEdge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSobelEdge.Name = "btnSobelEdge";
            this.btnSobelEdge.Size = new System.Drawing.Size(113, 76);
            this.btnSobelEdge.TabIndex = 12;
            this.btnSobelEdge.Text = "Sobel Edge";
            this.btnSobelEdge.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(1144, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 76);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxFactor1
            // 
            this.txtBoxFactor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFactor1.Location = new System.Drawing.Point(1016, 802);
            this.txtBoxFactor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFactor1.Name = "txtBoxFactor1";
            this.txtBoxFactor1.Size = new System.Drawing.Size(119, 30);
            this.txtBoxFactor1.TabIndex = 14;
            this.txtBoxFactor1.Text = "0";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBoxFactor2
            // 
            this.txtBoxFactor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFactor2.Location = new System.Drawing.Point(1144, 802);
            this.txtBoxFactor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFactor2.Name = "txtBoxFactor2";
            this.txtBoxFactor2.Size = new System.Drawing.Size(119, 30);
            this.txtBoxFactor2.TabIndex = 15;
            this.txtBoxFactor2.Text = "0";
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomLabel.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.Location = new System.Drawing.Point(1016, 842);
            this.bottomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(2, 26);
            this.bottomLabel.TabIndex = 17;
            this.bottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upLabel.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLabel.Location = new System.Drawing.Point(1144, 842);
            this.upLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(2, 26);
            this.upLabel.TabIndex = 18;
            this.upLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSharpen
            // 
            this.btnSharpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSharpen.Location = new System.Drawing.Point(1023, 37);
            this.btnSharpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(113, 76);
            this.btnSharpen.TabIndex = 19;
            this.btnSharpen.Text = "Sharpen";
            this.btnSharpen.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1283, 891);
            this.Controls.Add(this.btnSharpen);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.txtBoxFactor2);
            this.Controls.Add(this.txtBoxFactor1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSobelEdge);
            this.Controls.Add(this.btnCannyEdge);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.LoadExtension);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBoxPy);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.PictureBox pictureBoxPy;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnUpload;
        public System.Windows.Forms.Button btnBrightness;
        public System.Windows.Forms.Button btnNegative;
        public System.Windows.Forms.Button LoadExtension;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button btnGray;
        public System.Windows.Forms.Button btnContrast;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Button btnCannyEdge;
        public System.Windows.Forms.Button btnSobelEdge;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtBoxFactor1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.TextBox txtBoxFactor2;
        public System.Windows.Forms.Label bottomLabel;
        public System.Windows.Forms.Label upLabel;
        public System.Windows.Forms.Button btnSharpen;
    }
}

