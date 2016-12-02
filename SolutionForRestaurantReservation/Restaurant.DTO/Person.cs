using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class Person 
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Registred { get; set; }
        public string UniformSize { get; set; }
        public decimal? ShoesSize { get; set; }
    }
}
