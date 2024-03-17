//OOPS 
namespace OOPSPractise
{

    class person

    {
        private string Name;
        private int Age;
          
            public void Setname(string newName)

            {
            Name = newName;
            }
        public string GetName()
        {
            return Name;
        }
        public void Setage(int newAge)
        {
            if (newAge>=0)
            {
                Age = newAge;
            }
            else
            {
                Console.WriteLine("The given age is negative");
            }
        }
        public int GetAge()
        {
            return Age;
        }        
    }
     class oops2
     {
        static void Main(string[] args)
        {
            person Person1 = new person();
            Person1.Setname("Archana");
            Person1.Setage(-7);

            Console.WriteLine($"the person {Person1.GetName()} and age is {Person1.GetAge()}");
        }
     }
}
