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
    public partial class MainWindow : Form
    {
        private VueloRespositoryInterface vueloRepository;
        public MainWindow()
        {
            InitializeComponent();
            this.vueloRepository = new MysqlVueloRepository();
            showAllFlights();
        }

        private void showAllFlights()
        {
            lvAllFlights.Items.Clear();
            Vuelo[] vuelos = vueloRepository.GetAll();

            foreach(Vuelo vuelo in vuelos)
            {
                ListViewItem lvItem = lvAllFlights.Items.Add(vuelo._flightNumber);
                lvItem.SubItems.Add(vuelo._originAirportId);
                lvItem.SubItems.Add(vuelo._destinationAirportId);
                lvItem.SubItems.Add(vuelo._flightDate);
                lvItem.SubItems.Add(vuelo._airlineId);
            }
        }
    }
}
