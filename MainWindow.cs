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
    public partial class MainWindow : Form
    {
        private static Vuelo[] vuelos;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void butAirline_Click(object sender, EventArgs e)
        {
            AirlineFilterWindow airlineFilterWindow = new AirlineFilterWindow();
            airlineFilterWindow.ShowDialog();
        }

        private void showAllFlights()
        {
            VueloRespositoryInterface vueloRepository = new MysqlVueloRepository();
            vuelos = vueloRepository.GetAll();
        }

        public void showFlightsByAirline(string airline)
        {
            VueloRespositoryInterface vueloRepository = new MysqlVueloRepository();
            vuelos = vueloRepository.getByAirline(airline);
        }

        public void showFlightsByOrigin(string airport) {
            VueloRespositoryInterface vueloRepository = new MysqlVueloRepository();
            vuelos = vueloRepository.getByOriginAirport(airport);
        }

        public void showFlightsByDestination(string airport)
        {
            VueloRespositoryInterface vueloRepository = new MysqlVueloRepository();
            vuelos = vueloRepository.getByDestinationAirport(airport);
        }
        public void showFlightsBetweenDates(DateTime fechaInicio, DateTime fechaFinal)
        {
            VueloRespositoryInterface vueloRepository = new MysqlVueloRepository();
            vuelos = vueloRepository.getByDates(fechaInicio, fechaFinal);
        }
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            showFlights(vuelos);
        }

        private void showFlights(Vuelo[] vuelos)
        {
            lvAllFlights.Items.Clear();

            foreach (Vuelo vuelo in vuelos)
            {
                ListViewItem lvItem = lvAllFlights.Items.Add(vuelo._flightNumber);
                lvItem.SubItems.Add(vuelo._originAirportId);
                lvItem.SubItems.Add(vuelo._destinationAirportId);
                lvItem.SubItems.Add(vuelo._flightDate.ToString("dd/MM/yyyy HH:mm"));
                lvItem.SubItems.Add(vuelo._airlineId);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            showAllFlights();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OriginAirportFilterWindow airportFilterWindow = new OriginAirportFilterWindow();
            airportFilterWindow.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DestinationAirportFilterWindow airportFilterWindow = new DestinationAirportFilterWindow();
            airportFilterWindow.ShowDialog();
        }

        private void butDates_Click(object sender, EventArgs e)
        {
            DateFilterWindow dateFilterWindow = new DateFilterWindow();
            dateFilterWindow.ShowDialog();
        }

        private void butNewReserva_Click(object sender, EventArgs e)
        {
            if (lvAllFlights.SelectedItems.Count <= 0) return;
            if (lvAllFlights.SelectedItems.Count > 1) return;

            ListViewItem selectedItem = lvAllFlights.SelectedItems[0];
            if (selectedItem == null) return;

            NewReservaWindow newReservaWindow = new NewReservaWindow(selectedItem.Text);
            newReservaWindow.ShowDialog();
        }

        public void showBookingConfirmation()
        {
        }
    }
}
