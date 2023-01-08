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
    public partial class DateFilterWindow : Form
    {
        private AerolineaRepositoryInterface aerolineaRepository;
        public DateFilterWindow()
        {
            InitializeComponent();
        }

        private void butFilter_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            DateTime startDate = dpInicio.Value.Date;
            DateTime endDate = dpFinal.Value.Date;
            mainWindow.showFlightsBetweenDates(startDate, endDate);

            this.Close();
        }
    }
}
