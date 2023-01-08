using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad4.Model.Repository
{
    internal class MysqlAerolineaRepository : AerolineaRepositoryInterface
    {
        private DataSet dataSet;
        private OdbcConnection connection;
        private OdbcDataAdapter dataAdapter;

        public MysqlAerolineaRepository()
        {
            this.connection = new OdbcConnection("Dsn=reservas;server=127.0.0.1;uid=root;database=reservas;port=3306");
            connection.Open();
            this.dataSet = new DataSet();
        }

        public Aerolinea[] GetAll()
        {
            string query = "SELECT Id, Nombre, Codigo FROM aerolineas";
            DataTable resultTable = this.execute(query);
            List<Aerolinea> aerolineas = new List<Aerolinea>();
            foreach (DataRow row in resultTable.Rows)
            {
                Aerolinea aerolinea = new Aerolinea(
                    row["Id"].ToString(),
                    row["Nombre"].ToString(),
                    row["Codigo"].ToString()
                );

                aerolineas.Add(aerolinea);
            }

            return aerolineas.ToArray();
        }

        private DataTable execute(string query)
        {
            this.dataAdapter = new OdbcDataAdapter(query, connection);
            this.dataAdapter.Fill(this.dataSet, "consulta");
            return this.dataSet.Tables["consulta"];
        }
    }
}
