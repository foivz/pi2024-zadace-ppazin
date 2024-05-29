using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using RateYourPlate.Models;

namespace RateYourPlate
{
    internal class PrijavaRepository
    {
        public static bool CheckUser(string username)
        {
            string sql = $"SELECT * FROM Vlasnici WHERE username = '{username}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows == true)
            {
                return true;
            }
            DB.CloseConnection();

            return false;
        }

        public static bool CheckPass(string password)
        {
            string sql = $"SELECT * FROM Vlasnici WHERE password = '{password}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows == true)
            {
                return true;
            }
            DB.CloseConnection();

            return false;
        }

    }
}
