namespace M7Actividad2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.butNewReserva = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvAllFlights = new System.Windows.Forms.ListView();
            this.flightNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.origin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flightDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.airline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAirline = new System.Windows.Forms.Button();
            this.butDates = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "&Perfil";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1023, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // butNewReserva
            // 
            this.butNewReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNewReserva.Location = new System.Drawing.Point(856, 378);
            this.butNewReserva.Name = "butNewReserva";
            this.butNewReserva.Size = new System.Drawing.Size(155, 36);
            this.butNewReserva.TabIndex = 3;
            this.butNewReserva.Text = "Nueva reserva";
            this.butNewReserva.UseVisualStyleBackColor = true;
            this.butNewReserva.Click += new System.EventHandler(this.butNewReserva_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvAllFlights);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Todos los vuelos";
            // 
            // lvAllFlights
            // 
            this.lvAllFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.flightNumber,
            this.origin,
            this.destination,
            this.flightDate,
            this.airline});
            this.lvAllFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAllFlights.HideSelection = false;
            this.lvAllFlights.Location = new System.Drawing.Point(3, 22);
            this.lvAllFlights.Name = "lvAllFlights";
            this.lvAllFlights.Size = new System.Drawing.Size(993, 304);
            this.lvAllFlights.TabIndex = 0;
            this.lvAllFlights.UseCompatibleStateImageBehavior = false;
            this.lvAllFlights.View = System.Windows.Forms.View.Details;
            // 
            // flightNumber
            // 
            this.flightNumber.Text = "Número de vuelo";
            this.flightNumber.Width = 124;
            // 
            // origin
            // 
            this.origin.Text = "Origen";
            // 
            // destination
            // 
            this.destination.Text = "Destino";
            // 
            // flightDate
            // 
            this.flightDate.Text = "Fecha";
            // 
            // airline
            // 
            this.airline.Text = "Aerolínea";
            this.airline.Width = 143;
            // 
            // butAirline
            // 
            this.butAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAirline.Location = new System.Drawing.Point(75, 377);
            this.butAirline.Name = "butAirline";
            this.butAirline.Size = new System.Drawing.Size(112, 36);
            this.butAirline.TabIndex = 5;
            this.butAirline.Text = "Por aerolínea";
            this.butAirline.UseVisualStyleBackColor = true;
            this.butAirline.Click += new System.EventHandler(this.butAirline_Click);
            // 
            // butDates
            // 
            this.butDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDates.Location = new System.Drawing.Point(193, 377);
            this.butDates.Name = "butDates";
            this.butDates.Size = new System.Drawing.Size(85, 36);
            this.butDates.TabIndex = 6;
            this.butDates.Text = "Por fecha";
            this.butDates.UseVisualStyleBackColor = true;
            this.butDates.Click += new System.EventHandler(this.butDates_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(284, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Por origen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(381, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Por destino";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butDates);
            this.Controls.Add(this.butAirline);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butNewReserva);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "FlyinBisons";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button butNewReserva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListView lvAllFlights;
        private System.Windows.Forms.ColumnHeader flightNumber;
        private System.Windows.Forms.ColumnHeader origin;
        private System.Windows.Forms.ColumnHeader destination;
        private System.Windows.Forms.ColumnHeader flightDate;
        private System.Windows.Forms.ColumnHeader airline;
        private System.Windows.Forms.Button butAirline;
        private System.Windows.Forms.Button butDates;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}