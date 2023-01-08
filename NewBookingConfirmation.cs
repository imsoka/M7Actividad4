using M7Actividad4.Model;
using M7Actividad4.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M7Actividad4
{
    public partial class NewBookingConfirmation : Form
    {
        public NewBookingConfirmation()
        {
            InitializeComponent();
        }

        public NewBookingConfirmation(string flightNumber, int childrenTickets, int adultTickets, bool extraLuggage)
        {
            InitializeComponent();
            message.Text = "¡Reserva confirmada! Número de vuelo: " + flightNumber;
            lchildrenTickets.Visible = true;
            ladultTickets.Visible = true;
            lextraLuggage.Visible = true;
            lchildrenTickets.Text = "Número de tickets de niño: " + childrenTickets.ToString();
            ladultTickets.Text = "Número de tickets de adulto: " + childrenTickets.ToString();
            lextraLuggage.Text = "Equipaje extra: Sí";
            if(!extraLuggage)
            {
                lextraLuggage.Text = "Equipaje extra: No";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
