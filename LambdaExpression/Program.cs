using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expression");
            List<Person> listofpersons = new List<Person>();
            listofpersons.Add(new Person() { Address = "Hyderabad", Age = 16, Name = "amit", Pincode = 678905 });
            listofpersons.Add(new Person() { Address = "Mumbai", Age = 25, Name = "raju", Pincode = 123456 });
            listofpersons.Add(new Person() { Address = "Chennai", Age = 9, Name = "sonu", Pincode = 509132 });
            listofpersons.Add(new Person() { Address = "Karnataka", Age = 30, Name = "vani", Pincode = 509345 });
            var temp_person = listofpersons.Find(x => x.Age == 30);
            var temp_personTwo = listofpersons.FindAll(x => x.Age > 15);
            foreach (var ele in temp_personTwo)
            {
                Console.WriteLine(ele.Address);
            }
            Console.WriteLine(temp_person.Name);
        }
    }
}
