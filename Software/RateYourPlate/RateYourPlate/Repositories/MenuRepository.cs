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
    internal class MenuRepository
    {
        public static Menu GetDailyMenus(string datum)
        {
            string sql = $"SELECT * FROM Menu WHERE datum = '{datum}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Menu menu = null;

            if (reader.HasRows)
            {
                reader.Read();
                menu = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return menu;
        }

        private static Menu CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            DateTime datum = reader.GetDateTime(reader.GetOrdinal("datum"));
            int IdMenu1 = int.Parse(reader["IdMeni1"].ToString());
            int IdMenu2 = int.Parse(reader["IdMeni2"].ToString());
            int IdMenu3 = int.Parse(reader["IdMeni3"].ToString());

            var menu = new Menu
            {
                Id = id,
                Datum = datum,
                Menu1 = IdMenu1,
                Menu2 = IdMenu2,
                Menu3 = IdMenu3
            };

            return menu;
        }

        public static MenuDetails GetMenuDetails(int id, string index)
        {
            string tableName = $"Menu{index}";
            string columnName = $"IdMeni{index}";
            string sId = id.ToString();

            string sql = $"SELECT * FROM {tableName} WHERE {columnName} = {sId}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            MenuDetails menuDetails = null;

            if (reader.HasRows)
            {
                reader.Read();
                menuDetails = CreateMenuDetailsObject(reader, index);
                reader.Close();
            }
            DB.CloseConnection();
            return menuDetails;
        }

        private static MenuDetails CreateMenuDetailsObject(SqlDataReader reader, string suffix)
        {
            int id = int.Parse(reader[$"IdMeni{suffix}"].ToString());
            string juha = reader[$"juha{suffix}"].ToString();
            string glavnoJelo = reader[$"glavnoJelo{suffix}"].ToString();
            string prilog = reader[$"prilog{suffix}"].ToString();
            string desert = reader[$"desert{suffix}"].ToString();

            var menuDetails = new MenuDetails
            {
                Id = id,
                Juha = juha,
                GlavnoJelo = glavnoJelo,
                Prilog = prilog,
                Desert = desert
            };

            return menuDetails;
        }
    }
}