using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL;
using Restaurant.DTO;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=MB-PC; Initial Catalog=RestaurantDB; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connString);
            PersonRepositoryDB p = new PersonRepositoryDB(conn);
            Person pp = new Person() 
            { 
                Name = "Nesto",
                Registred = true,
                Email = "Nesto@nesto",
                Password = "qwe",
                RestaurantId = 1,
                RoleId = 1,
                ShoesSize = (decimal)45.5,
                Surname = "Nestp",
                UniformSize = "XL"
            };
            int i = p.AddPerson(pp);
            conn.Close();
        }
    }
}
