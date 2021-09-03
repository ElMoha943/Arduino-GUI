
namespace Arduino_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnDebug = new FontAwesome.Sharp.IconButton();
            this.btnSensors = new FontAwesome.Sharp.IconButton();
            this.btnLeds = new FontAwesome.Sharp.IconButton();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.formHijo = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLateral.Controls.Add(this.btnDebug);
            this.panelLateral.Controls.Add(this.btnSensors);
            this.panelLateral.Controls.Add(this.btnLeds);
            this.panelLateral.Controls.Add(this.panelSuperior);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 421);
            this.panelLateral.TabIndex = 0;
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDebug.FlatAppearance.BorderSize = 0;
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebug.IconChar = FontAwesome.Sharp.IconChar.Bug;
            this.btnDebug.IconColor = System.Drawing.Color.Black;
            this.btnDebug.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDebug.IconSize = 32;
            this.btnDebug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebug.Location = new System.Drawing.Point(7, 136);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(186, 42);
            this.btnDebug.TabIndex = 5;
            this.btnDebug.Text = "DEBUG";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnSensors
            // 
            this.btnSensors.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSensors.FlatAppearance.BorderSize = 0;
            this.btnSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSensors.IconChar = FontAwesome.Sharp.IconChar.ThermometerEmpty;
            this.btnSensors.IconColor = System.Drawing.Color.Black;
            this.btnSensors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSensors.IconSize = 32;
            this.btnSensors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensors.Location = new System.Drawing.Point(7, 88);
            this.btnSensors.Name = "btnSensors";
            this.btnSensors.Size = new System.Drawing.Size(186, 42);
            this.btnSensors.TabIndex = 4;
            this.btnSensors.Text = "SENSORS";
            this.btnSensors.UseVisualStyleBackColor = false;
            this.btnSensors.Click += new System.EventHandler(this.btnSensors_Click);
            // 
            // btnLeds
            // 
            this.btnLeds.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLeds.FlatAppearance.BorderSize = 0;
            this.btnLeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeds.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.btnLeds.IconColor = System.Drawing.Color.Black;
            this.btnLeds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeds.IconSize = 32;
            this.btnLeds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeds.Location = new System.Drawing.Point(7, 40);
            this.btnLeds.Name = "btnLeds";
            this.btnLeds.Size = new System.Drawing.Size(186, 42);
            this.btnLeds.TabIndex = 3;
            this.btnLeds.Text = "LEDS";
            this.btnLeds.UseVisualStyleBackColor = false;
            this.btnLeds.Click += new System.EventHandler(this.btnLeds_Click_1);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Controls.Add(this.labelStatus);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(198, 34);
            this.panelSuperior.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelStatus.Location = new System.Drawing.Point(3, 8);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "label1";
            // 
            // formHijo
            // 
            this.formHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.formHijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formHijo.Location = new System.Drawing.Point(200, 0);
            this.formHijo.Name = "formHijo";
            this.formHijo.Size = new System.Drawing.Size(600, 421);
            this.formHijo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.formHijo);
            this.Controls.Add(this.panelLateral);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Arduino Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel formHijo;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconButton btnLeds;
        private FontAwesome.Sharp.IconButton btnDebug;
        private FontAwesome.Sharp.IconButton btnSensors;
    }
}

