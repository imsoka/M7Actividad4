using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad4.Model.Repository
{
    internal class MysqlAeropuertoRepository : AeropuertoRepositoryInterface
    {
        private DataSet dataSet;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;

        public MysqlAeropuertoRepository()
        {
            this.connection = new OdbcConnection("Dsn=reservas;server=127.0.0.1;uid=root;database=reservas;port=3306");
            connection.Open();
            this.dataSet = new DataSet();
        }
        public Aeropuerto[] GetAll()
        {
            string query = "SELECT Id, Nombre, Siglas, Nacional FROM aerpuertos;";
            DataTable resultTable = this.execute(query);
            List<Aeropuerto> aeropuertos = new List<Aeropuerto>();
            foreach (DataRow row in resultTable.Rows)
            {
                Aeropuerto aeropuerto = new Aeropuerto(
                    row["Id"].ToString(),
                    row["Nombre"].ToString(),
                    row["Siglas"].ToString(),
                    row["Nacional"].ToString()
                );

                aeropuertos.Add(aeropuerto);
            }

            return aeropuertos.ToArray();

        }

        private DataTable execute(string query)
        {
            this.dataAdapter = new OdbcDataAdapter(query, connection);
            this.dataAdapter.Fill(this.dataSet, "consulta");
            return this.dataSet.Tables["consulta"];
        }
    }
}
