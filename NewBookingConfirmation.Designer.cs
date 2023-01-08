namespace M7Actividad4
{
    partial class NewBookingConfirmation
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
            this.lchildrenTickets = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.ladultTickets = new System.Windows.Forms.Label();
            this.lextraLuggage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lextraLuggage);
            this.panel1.Controls.Add(this.ladultTickets);
            this.panel1.Controls.Add(this.lchildrenTickets);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 188);
            this.panel1.TabIndex = 1;
            // 
            // lchildrenTickets
            // 
            this.lchildrenTickets.AutoSize = true;
            this.lchildrenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lchildrenTickets.Location = new System.Drawing.Point(76, 69);
            this.lchildrenTickets.Name = "lchildrenTickets";
            this.lchildrenTickets.Size = new System.Drawing.Size(46, 17);
            this.lchildrenTickets.TabIndex = 2;
            this.lchildrenTickets.Text = "label1";
            this.lchildrenTickets.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(509, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(128, 25);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(261, 24);
            this.message.TabIndex = 0;
            this.message.Text = "Ha habido un error al reservar";
            // 
            // ladultTickets
            // 
            this.ladultTickets.AutoSize = true;
            this.ladultTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladultTickets.Location = new System.Drawing.Point(76, 100);
            this.ladultTickets.Name = "ladultTickets";
            this.ladultTickets.Size = new System.Drawing.Size(46, 17);
            this.ladultTickets.TabIndex = 3;
            this.ladultTickets.Text = "label1";
            this.ladultTickets.Visible = false;
            // 
            // lextraLuggage
            // 
            this.lextraLuggage.AutoSize = true;
            this.lextraLuggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lextraLuggage.Location = new System.Drawing.Point(76, 136);
            this.lextraLuggage.Name = "lextraLuggage";
            this.lextraLuggage.Size = new System.Drawing.Size(46, 17);
            this.lextraLuggage.TabIndex = 4;
            this.lextraLuggage.Text = "label2";
            this.lextraLuggage.Visible = false;
            // 
            // NewBookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(614, 188);
            this.Controls.Add(this.panel1);
            this.Name = "NewBookingConfirmation";
            this.Text = "NewBookingConfirmation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label lchildrenTickets;
        private System.Windows.Forms.Label lextraLuggage;
        private System.Windows.Forms.Label ladultTickets;
    }
}