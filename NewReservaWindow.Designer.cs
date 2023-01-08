namespace M7Actividad4
{
    partial class NewReservaWindow
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
            this.butNewReserva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbExtraLuggage = new System.Windows.Forms.ComboBox();
            this.tbAdultTickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChildrenTickets = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lFlightNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butNewReserva);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbExtraLuggage);
            this.panel1.Controls.Add(this.tbAdultTickets);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbChildrenTickets);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lFlightNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 188);
            this.panel1.TabIndex = 1;
            // 
            // butNewReserva
            // 
            this.butNewReserva.ForeColor = System.Drawing.Color.Black;
            this.butNewReserva.Location = new System.Drawing.Point(197, 138);
            this.butNewReserva.Name = "butNewReserva";
            this.butNewReserva.Size = new System.Drawing.Size(120, 38);
            this.butNewReserva.TabIndex = 8;
            this.butNewReserva.Text = "Reservar";
            this.butNewReserva.UseVisualStyleBackColor = true;
            this.butNewReserva.Click += new System.EventHandler(this.butNewReserva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(360, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "¿Equipaje extra?";
            // 
            // cbExtraLuggage
            // 
            this.cbExtraLuggage.FormattingEnabled = true;
            this.cbExtraLuggage.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbExtraLuggage.Location = new System.Drawing.Point(360, 83);
            this.cbExtraLuggage.Name = "cbExtraLuggage";
            this.cbExtraLuggage.Size = new System.Drawing.Size(116, 32);
            this.cbExtraLuggage.TabIndex = 6;
            // 
            // tbAdultTickets
            // 
            this.tbAdultTickets.Location = new System.Drawing.Point(200, 83);
            this.tbAdultTickets.Name = "tbAdultTickets";
            this.tbAdultTickets.Size = new System.Drawing.Size(114, 29);
            this.tbAdultTickets.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Billetes para adulto";
            // 
            // tbChildrenTickets
            // 
            this.tbChildrenTickets.Location = new System.Drawing.Point(50, 83);
            this.tbChildrenTickets.Name = "tbChildrenTickets";
            this.tbChildrenTickets.Size = new System.Drawing.Size(114, 29);
            this.tbChildrenTickets.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Billetes para niño";
            // 
            // lFlightNumber
            // 
            this.lFlightNumber.AutoSize = true;
            this.lFlightNumber.ForeColor = System.Drawing.Color.White;
            this.lFlightNumber.Location = new System.Drawing.Point(323, 13);
            this.lFlightNumber.Name = "lFlightNumber";
            this.lFlightNumber.Size = new System.Drawing.Size(0, 24);
            this.lFlightNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva reserva para vuelo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewReservaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(515, 188);
            this.Controls.Add(this.panel1);
            this.Name = "NewReservaWindow";
            this.Text = "NewReservaWindow";
            this.Load += new System.EventHandler(this.NewReservaWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdultTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChildrenTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbExtraLuggage;
        private System.Windows.Forms.Button butNewReserva;
    }
}