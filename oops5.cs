//enum example 
namespace OOPSPractise
{
    public class oops5
    {
        public enum fruits
        {
            orange,
            papaya,
            watermelon

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a fruit 1.orange , 2.papaya, 3.watermelon");
            int Choice = int.Parse(Console.ReadLine());


            fruits selectedfruit = (fruits)(Choice - 1);

            switch (selectedfruit)

            {

                case fruits.orange:
                 Console.WriteLine("You choose orange");
                    break;

                case fruits.papaya:
                    Console.WriteLine("You choose papaya");
                    break;
                 case fruits.watermelon:
                    Console.WriteLine("You choose watermelon");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;







            }
        }
    }
}
