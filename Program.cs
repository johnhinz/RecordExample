using System;

namespace RecordTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                fName = "Joe", 
                lName = "Smith", 
                dob = DateTime.Now - new TimeSpan(30,0,0)
            };
        }
    }

    public record Person 
    {
        public string fName;
        public string lName;
        public DateTime dob;
    };

}
