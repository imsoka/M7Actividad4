namespace M7Actividad2
{
    partial class OriginAirportFilterWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butFilter = new System.Windows.Forms.Button();
            this.cbAirports = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butFilter);
            this.panel1.Controls.Add(this.cbAirports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 188);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona un aeropuerto";
            // 
            // butFilterOrigin
            // 
            this.butFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFilter.Location = new System.Drawing.Point(186, 120);
            this.butFilter.Name = "butFilterOrigin";
            this.butFilter.Size = new System.Drawing.Size(142, 41);
            this.butFilter.TabIndex = 1;
            this.butFilter.Text = "Filtrar";
            this.butFilter.UseVisualStyleBackColor = true;
            this.butFilter.Click += new System.EventHandler(this.butFilterOrigin_Click);
            // 
            // cbAirports
            // 
            this.cbAirports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirports.FormattingEnabled = true;
            this.cbAirports.Location = new System.Drawing.Point(186, 86);
            this.cbAirports.Name = "cbAirports";
            this.cbAirports.Size = new System.Drawing.Size(142, 28);
            this.cbAirports.TabIndex = 0;
            // 
            // AirportFilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(515, 188);
            this.Controls.Add(this.panel1);
            this.Name = "AirportFilterWindow";
            this.Text = "AirportFilterWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butFilter;
        private System.Windows.Forms.ComboBox cbAirports;
        private System.Windows.Forms.Label label1;
    }
}