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
    public partial class AirlineFilterWindow : Form
    {
        private AerolineaRepositoryInterface aerolineaRepository;
        public AirlineFilterWindow()
        {
            InitializeComponent();
            fillAirlineComboBox();
        }

        private void fillAirlineComboBox()
        {
            aerolineaRepository = new MysqlAerolineaRepository();
            Aerolinea[] aerolineas = aerolineaRepository.GetAll();
            foreach(Aerolinea aerolinea in aerolineas)
            {
                cbAirlines.Items.Add(aerolinea.Nombre);
            }
        }

        private void butFilter_Click(object sender, EventArgs e)
        {
            string selectedAirline = cbAirlines.Text;
            MainWindow mainWindow = new MainWindow();

            mainWindow.showFlightsByAirline(selectedAirline);
            this.Close();
        }
    }
}
