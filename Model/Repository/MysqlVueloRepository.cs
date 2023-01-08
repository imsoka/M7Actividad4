using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace M7Actividad4.Model.Repository
{
    internal class MysqlVueloRepository : VueloRespositoryInterface
    {
        private DataSet dataSet;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;

        public MysqlVueloRepository()
        {
            this.connection = new OdbcConnection("Dsn=reservas;server=127.0.0.1;uid=root;database=reservas;port=3306");
            connection.Open();
            this.dataSet = new DataSet();
        }

        public Vuelo[] GetAll()
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "date(vuelos.Fecha) AS Fecha, time(vuelos.Hora) AS Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id ORDER BY vuelos.Fecha ASC";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach(DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = this.buildVuelo(row);

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo[] getByAirline(string airline)
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "date(vuelos.Fecha) AS Fecha, time(vuelos.Hora) AS Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND aerolineas.Nombre LIKE " + "'" + airline + "' ORDER BY vuelos.Fecha ASC";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = this.buildVuelo(row);

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo[] getByDates(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "date(vuelos.Fecha) AS Fecha, time(vuelos.Hora) AS Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND vuelos.Fecha >= date('" + startDate.ToString("yyyy-MM-dd") + "') AND vuelos.Fecha <= date('" +
                endDate.ToString("yyy-MM-dd") + "') ORDER BY vuelos.Fecha ASC";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = this.buildVuelo(row);

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo[] getByDestinationAirport(string destinationAirport)
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "date(vuelos.Fecha) AS Fecha, time(vuelos.Hora) AS Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND aerpuertos_1.Nombre LIKE " + "'" + destinationAirport + "' ORDER BY vuelos.Fecha ASC";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = this.buildVuelo(row);

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo getByFlightNumber(string flightNumber)
        {
            throw new NotImplementedException();
        }

        public Vuelo[] getByOriginAirport(string originAirport)
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "date(vuelos.Fecha) AS Fecha, time(vuelos.Hora) AS Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND aerpuertos.Nombre LIKE " + "'" + originAirport + "' ORDER BY vuelos.Fecha ASC";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = this.buildVuelo(row);

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        private Vuelo buildVuelo(DataRow row)
        {
            DateTime fecha = (DateTime) row["Fecha"];

            string fechaString = fecha.ToString("dd/MM/yyyy") + ' ' + row["hora"].ToString();
            DateTime flightDate = DateTime.ParseExact(fechaString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            return new Vuelo(
                row["Numero"].ToString(),
                row["Origen"].ToString(),
                row["Destino"].ToString(),
                flightDate,
                row["Aerolinea"].ToString()
            );
        }

        private DataTable execute(string query)
        {
            this.dataAdapter = new OdbcDataAdapter(query, connection);
            this.dataAdapter.Fill(this.dataSet, "consulta");
            return this.dataSet.Tables["consulta"];
        }
    }
}
