using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad2.Model.Repository
{
    internal class MysqlVueloRepository : VueloRespositoryInterface
    {
        private DataSet dataSet;
        private OdbcConnection connection;
        private DataTable dataTable;
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
            this.dataAdapter = new OdbcDataAdapter(query, connection);
            this.dataAdapter.Fill(this.dataSet, "consulta");
            this.dataTable = this.dataSet.Tables["consulta"];
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach(DataRow row in this.dataTable.Rows)
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
            throw new NotImplementedException();
        }

        public Vuelo[] getByDestinationAirport(string destinationAirport)
        {
            throw new NotImplementedException();
        }

        public Vuelo getByFlightNumber(string flightNumber)
        {
            throw new NotImplementedException();
        }

        public Vuelo[] getByOriginAirport(string originAirport)
        {
            throw new NotImplementedException();
        }

        public Vuelo store(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        public Vuelo update(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }
    }
}
