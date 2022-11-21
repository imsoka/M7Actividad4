using M7Actividad2.Model;
using M7Actividad2.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M7Actividad2
{
    public partial class DestinationAirportFilterWindow: Form
    {
        private AeropuertoRepositoryInterface aeropuertoRepository;
        public DestinationAirportFilterWindow()
        {
            InitializeComponent();
            fillAirpotComboBox();
        }

        private void fillAirpotComboBox()
        {
            aeropuertoRepository = new MysqlAeropuertoRepository();
            Aeropuerto[] aeropuertos = aeropuertoRepository.GetAll();
            foreach (Aeropuerto aeropuerto in aeropuertos)
            {
                cbAirports.Items.Add(aeropuerto.Nombre);
            }
        }

        private void butFilterDestination_Click(object sender, EventArgs e)
        {
            string selectedAirport = cbAirports.Text;
            MainWindow mainWindow = new MainWindow();

            mainWindow.showFlightsByDestination(selectedAirport);
            this.Close();
        }
    }
}
