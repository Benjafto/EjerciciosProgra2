using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClaseVirtual.Data
{
    public class DataHelper
    {
        //clase que nos asiste con la conexio de datos
        private string StrConnection;
        private static DataHelper _instance;
        private SqlConnection _connection;
        public DataHelper()
        {
            _connection = new SqlConnection(Properties.Resources.StrConnection);
        }

        public static DataHelper GetInstance() {

            if (_instance == null) { 
                _instance = new DataHelper();
            }
            return _instance;
        }

        public DataTable ExecuteSPQuery(string sp)
        {
            DataTable dt = new DataTable();
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(sp, _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                dt.Load(cmd.ExecuteReader());

                _connection.Close();
            }
            catch (SqlException)
            {
                //gestionar error
                dt = null;
            }

            return dt;
        }
    }
}
