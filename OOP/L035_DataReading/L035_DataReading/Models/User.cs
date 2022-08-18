using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L035_DataReading.Models
{
    internal class User
    {
        private string[] userData;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public Int64 Salery { get; set; } = 0;

        public string FavoriteColor { get; set; }

        public DateTime BirthDate { get; set; }

        public User() { }

        public User(string[] userData)
        {
            Id= Convert.ToInt32(userData[0]);
            FirstName=userData[1];
            LastName=userData[2];
            Email=userData[3];
            Gender=userData[4];
            Salery= Convert.ToInt64(userData[5]);
            FavoriteColor=userData[6];
            BirthDate= Convert.ToDateTime(userData[7]);
        }
    }
}
