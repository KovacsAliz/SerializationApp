using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SerializePeople SerializePeople1 = new SerializePeople("John", new DateTime(2012, 10, 21), Genders.Male);
            Console.WriteLine(SerializePeople1);

            SerializePeople SerializePeople2 = new SerializePeople("Heidi", new DateTime(1998, 03, 06), Genders.Female);
            Console.WriteLine(SerializePeople2);
            Console.ReadKey();
        }
    }
}
