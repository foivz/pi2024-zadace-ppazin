using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateYourPlate
{
    public class MenuRepository
    {
        public static Menu GetDailyMenu(DateTime datum)
        {
            Menu menu = null;
            string sql = $"SELECT * FROM Menu WHERE datum = {datum}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql); //zadnja greska (error near .2024.)
            if (reader.HasRows)
            {
                reader.Read();
                menu = CreateObject(reader);
                reader.Close();
            }
            reader.Close();
            DB.CloseConnection();
            return menu;
        }

        public static List<Menu> GetMenus()
        {
            List<Menu> menus = new List<Menu>();
            string sql = "SELECT * FROM Menu";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Menu menu = CreateObject(reader);
                menus.Add(menu);
            }
            reader.Close();
            DB.CloseConnection();
            return menus;
        }

        private static Menu CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string juha = reader["juha"].ToString();
            string glavnoJelo = reader["glavnoJelo"].ToString();
            string prilog = reader["prilog"].ToString();
            string desert = reader["desert"].ToString();
            DateTime datum = reader.GetDateTime(reader.GetOrdinal("datum"));
            var menu = new Menu
            {
                Id = id,
                Juha = juha,
                GlavnoJelo = glavnoJelo,
                Prilog = prilog,
                Desert = desert,
                Datum = datum
            };
            return menu;
        }

    }
}
