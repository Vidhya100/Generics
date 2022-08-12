using GenericMaxNumber;

namespace GenericmaxNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the First number: ");
            int first= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int second= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            MaxNumber maxnumObj = new MaxNumber(first,second,third);
            int maxNumber = maxnumObj.GetMaxNum();

            Console.WriteLine("your max number {0}", maxNumber);
        }
    }
}