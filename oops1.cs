

namespace OOPSPractise
{
     class Car
    {
        //variables 
         public  string make; 
         public string made; 
         public int year;

        //method which has void as a return type n no value 
        public void start()
        {
            Console.WriteLine("manufactured and started with 10,000 miles ");
        }

        public void stop()
        {
            Console.WriteLine(" stopped ");
        }
        

    }
     class oops1
    {
      static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar . make = "corolla";
            myCar. made = "toyota";
            myCar .year = 2024;

            Console.WriteLine($"the car is {myCar.made} {myCar.make} {myCar.year}");
            myCar.start();
            myCar.stop();
        }
            
    }
}
