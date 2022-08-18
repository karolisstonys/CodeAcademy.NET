using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L035_DataReading.Models
{
    public class BasicUser
    {
        public BasicUser() { }

        public BasicUser(string[] basicUserData)
        {
            Id=Convert.ToInt32(basicUserData[0]);
            Name=basicUserData[1];
        }

        public BasicUser(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
