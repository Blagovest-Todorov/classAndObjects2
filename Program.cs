using System;

namespace _03.ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            car.Year = 1891;
            Console.WriteLine(car.Year);


        }

        //fileds, properties and methods can be instanced and static
        //object members -instance
        //Static //or class members -can not be made instance
        //instatnce members are specific for each Object
        //static memebrs are common  for all instances of a class
        

    }
    class Car
    {
        private ushort year;
        const int minYear = 1890;

        public ushort Year
        {
            get
            {
                return (ushort)(year - 10 ) ;
            }
            set 
            {
                if (value < minYear)
                {
                    Console.WriteLine("Sorry invalid value for the year entered ! ");
                }
                else
                {
                    year = value;     
                }

            }
        
        }

    }


}
