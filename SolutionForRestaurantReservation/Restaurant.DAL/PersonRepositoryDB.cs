using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DTO;   ///
using Restaurant.DTO.Interfaces;
using System.Data.SqlClient;
using System.Data; /////////

namespace Restaurant.DAL
{
    public class PersonRepositoryDB : IPersonRepository
    {
        private SqlConnection _connection;
        public PersonRepositoryDB(SqlConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("SqlConnection null reference!");
            }
            _connection = connection;
            _connection.Open();
            
        }

        public int AddPerson(Person person)
        {
            SqlCommand cmd = new SqlCommand("p_addPerson", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@RestaurantId", SqlDbType.Int).Value = person.RestaurantId;
            cmd.Parameters.Add("@RoleId", SqlDbType.Int).Value = person.RoleId;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = person.Name;
            cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = person.Surname;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = person.Email;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = person.Password;
            cmd.Parameters.Add("@Registred", SqlDbType.Bit).Value = person.Registred;
            cmd.Parameters.Add("@UniformSize", SqlDbType.VarChar).Value = person.UniformSize;
            cmd.Parameters.Add("@ShoesSize", SqlDbType.Decimal).Value = person.ShoesSize;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
             
            cmd.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd.Parameters["@Id"].Value);
            return id;
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }
}
