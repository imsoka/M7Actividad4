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
    public partial class NewReservaWindow : Form
    {
        private string flightNumber;
        public NewReservaWindow(string flightNumber)
        {
            InitializeComponent();
            this.flightNumber = flightNumber;
        }

        private void NewReservaWindow_Load(object sender, EventArgs e)
        {
            lFlightNumber.Text = this.flightNumber;
        }

        private void butNewReserva_Click(object sender, EventArgs e)
        {
            int childrenTickets;
            int adultTickets;
            bool extraLuggage;
            NewBookingConfirmation newBookingConfirmation;
            try
            {
                childrenTickets = int.Parse(tbChildrenTickets.Text);
                adultTickets = int.Parse(tbAdultTickets.Text);
                if(cbExtraLuggage.Text == "Sí")
                {
                    extraLuggage = true;
                } else
                {
                    extraLuggage = false;
                }

                newBookingConfirmation = new NewBookingConfirmation(flightNumber, childrenTickets, adultTickets, extraLuggage);
                newBookingConfirmation.ShowDialog();
                this.Close();

            } catch(Exception ex)
            {
                newBookingConfirmation = new NewBookingConfirmation();
                newBookingConfirmation.ShowDialog();
                this.Close();
            }
        }
    }
}
