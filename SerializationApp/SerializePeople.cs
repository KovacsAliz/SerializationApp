using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializationApp
{
    public enum Genders { Male, Female }

    [Serializable]
    public class SerializePeople
    {
        protected string Name { get; set; }
        protected DateTime BirthDate { get; set; }
        protected Genders Gender { get; set; }
        protected int Age { get; }

        public SerializePeople(string name, DateTime birthDate, Genders gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Age = DateTime.Now.Year - BirthDate.Year;
        }

        public override string ToString()
        {
            return "SerializePeople: " + Name + ", " + BirthDate + ", " + Gender;
        }
    }
}
