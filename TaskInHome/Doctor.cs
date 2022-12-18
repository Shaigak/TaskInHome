using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInHome
{
    internal class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Address { get; set; }

        public DateTime Birhtday { get; set; }

        public Doctor(string name, string surname, string address, DateTime birhtday)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Birhtday = birhtday;
        }

    }

}
