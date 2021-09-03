
namespace Arduino_GUI
{
    partial class FormLeds
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
            this.labelLed3 = new System.Windows.Forms.Label();
            this.toggleLed3 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.labelLed2 = new System.Windows.Forms.Label();
            this.toggleLed2 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.labelLed1 = new System.Windows.Forms.Label();
            this.toggleLed1 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.rgbPicker = new Nevron.UI.WinForm.Controls.NColorPicker();
            this.SuspendLayout();
            // 
            // labelLed3
            // 
            this.labelLed3.AutoSize = true;
            this.labelLed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelLed3.Location = new System.Drawing.Point(7, 90);
            this.labelLed3.Name = "labelLed3";
            this.labelLed3.Size = new System.Drawing.Size(47, 17);
            this.labelLed3.TabIndex = 15;
            this.labelLed3.Text = "LED3";
            // 
            // toggleLed3
            // 
            this.toggleLed3.AutoSize = true;
            this.toggleLed3.Location = new System.Drawing.Point(60, 88);
            this.toggleLed3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleLed3.Name = "toggleLed3";
            this.toggleLed3.OffBackColor = System.Drawing.Color.Gray;
            this.toggleLed3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleLed3.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleLed3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleLed3.Size = new System.Drawing.Size(45, 22);
            this.toggleLed3.TabIndex = 16;
            this.toggleLed3.UseVisualStyleBackColor = true;
            // 
            // labelLed2
            // 
            this.labelLed2.AutoSize = true;
            this.labelLed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelLed2.Location = new System.Drawing.Point(7, 53);
            this.labelLed2.Name = "labelLed2";
            this.labelLed2.Size = new System.Drawing.Size(47, 17);
            this.labelLed2.TabIndex = 13;
            this.labelLed2.Text = "LED2";
            // 
            // toggleLed2
            // 
            this.toggleLed2.AutoSize = true;
            this.toggleLed2.Location = new System.Drawing.Point(60, 51);
            this.toggleLed2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleLed2.Name = "toggleLed2";
            this.toggleLed2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleLed2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleLed2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleLed2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleLed2.Size = new System.Drawing.Size(45, 22);
            this.toggleLed2.TabIndex = 14;
            this.toggleLed2.UseVisualStyleBackColor = true;
            // 
            // labelLed1
            // 
            this.labelLed1.AutoSize = true;
            this.labelLed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelLed1.Location = new System.Drawing.Point(7, 14);
            this.labelLed1.Name = "labelLed1";
            this.labelLed1.Size = new System.Drawing.Size(47, 17);
            this.labelLed1.TabIndex = 9;
            this.labelLed1.Text = "LED1";
            // 
            // toggleLed1
            // 
            this.toggleLed1.AutoSize = true;
            this.toggleLed1.Location = new System.Drawing.Point(60, 12);
            this.toggleLed1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleLed1.Name = "toggleLed1";
            this.toggleLed1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleLed1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleLed1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleLed1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleLed1.Size = new System.Drawing.Size(45, 22);
            this.toggleLed1.TabIndex = 12;
            this.toggleLed1.UseVisualStyleBackColor = true;
            this.toggleLed1.CheckedChanged += new System.EventHandler(this.toggleLed1_CheckedChanged);
            // 
            // rgbPicker
            // 
            // 
            // 
            // 
            this.rgbPicker.ColorPane.BackgroundType = Nevron.UI.WinForm.Controls.BackgroundType.Transparent;
            this.rgbPicker.ColorPane.CommandLayout = Nevron.UI.WinForm.Controls.CommandLayout.HorizontalWrapping;
            this.rgbPicker.ColorPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbPicker.ColorPane.Location = new System.Drawing.Point(0, 0);
            this.rgbPicker.ColorPane.Name = "lI11III11";
            this.rgbPicker.ColorPane.Selectable = true;
            this.rgbPicker.ColorPane.SelectedIndex = 63;
            this.rgbPicker.ColorPane.Size = new System.Drawing.Size(272, 271);
            this.rgbPicker.ColorPane.TabIndex = 0;
            this.rgbPicker.ColorPane.TabStop = false;
            this.rgbPicker.ColorPane.Text = "lI11III11";
            this.rgbPicker.Location = new System.Drawing.Point(292, 12);
            this.rgbPicker.Name = "rgbPicker";
            this.rgbPicker.Size = new System.Drawing.Size(280, 352);
            this.rgbPicker.TabIndex = 17;
            // 
            // FormLeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(584, 382);
            this.ControlBox = false;
            this.Controls.Add(this.rgbPicker);
            this.Controls.Add(this.labelLed3);
            this.Controls.Add(this.toggleLed3);
            this.Controls.Add(this.labelLed2);
            this.Controls.Add(this.toggleLed2);
            this.Controls.Add(this.labelLed1);
            this.Controls.Add(this.toggleLed1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLeds";
            this.Text = "FormLeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLed3;
        private RJCodeAdvance.RJControls.RJToggleButton toggleLed3;
        private System.Windows.Forms.Label labelLed2;
        private RJCodeAdvance.RJControls.RJToggleButton toggleLed2;
        private System.Windows.Forms.Label labelLed1;
        private RJCodeAdvance.RJControls.RJToggleButton toggleLed1;
        private Nevron.UI.WinForm.Controls.NColorPicker rgbPicker;
    }
}