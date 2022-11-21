using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace M7Actividad2.Model.Repository
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
        public Vuelo Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Vuelo[] GetAll()
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "vuelos.Fecha, vuelos.Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach(DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = new Vuelo(
                    row["Numero"].ToString(),
                    row["Origen"].ToString(),
                    row["Destino"].ToString(),
                    row["Fecha"].ToString(),
                    row["Hora"].ToString(),
                    row["Aerolinea"].ToString()
                );

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo[] getByAirline(string airline)
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "vuelos.Fecha, vuelos.Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND aerolineas.Nombre LIKE " + "'" + airline + "'";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = new Vuelo(
                    row["Numero"].ToString(),
                    row["Origen"].ToString(),
                    row["Destino"].ToString(),
                    row["Fecha"].ToString(),
                    row["Hora"].ToString(),
                    row["Aerolinea"].ToString()
                );

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo[] getByDestinationAirport(string destinationAirport)
        {
            string query = "SELECT vuelos.Numero, aerpuertos.Nombre AS Origen, aerpuertos_1.Nombre AS Destino, " +
                "vuelos.Fecha, vuelos.Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND aerpuertos_1.Nombre LIKE " + "'" + destinationAirport + "'";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = new Vuelo(
                    row["Numero"].ToString(),
                    row["Origen"].ToString(),
                    row["Destino"].ToString(),
                    row["Fecha"].ToString(),
                    row["Hora"].ToString(),
                    row["Aerolinea"].ToString()
                );

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
                "vuelos.Fecha, vuelos.Hora, aerolineas.Nombre AS Aerolinea FROM aerolineas, aerpuertos aerpuertos_1, " +
                "vuelos, aerpuertos WHERE aerolineas.Id = vuelos.Aerolinea AND aerpuertos_1.Id = vuelos.Destino AND " +
                "vuelos.Origen = aerpuertos.Id AND aerpuertos.Nombre LIKE " + "'" + originAirport + "'";
            DataTable resultTable = this.execute(query);
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (DataRow row in resultTable.Rows)
            {
                Vuelo vuelo = new Vuelo(
                    row["Numero"].ToString(),
                    row["Origen"].ToString(),
                    row["Destino"].ToString(),
                    row["Fecha"].ToString(),
                    row["Hora"].ToString(),
                    row["Aerolinea"].ToString()
                );

                vuelos.Add(vuelo);
            }

            return vuelos.ToArray();
        }

        public Vuelo store(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        public Vuelo update(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        private DataTable execute(string query)
        {
            this.dataAdapter = new OdbcDataAdapter(query, connection);
            this.dataAdapter.Fill(this.dataSet, "consulta");
            return this.dataSet.Tables["consulta"];
        }
    }
}
