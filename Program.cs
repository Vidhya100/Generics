using GenericMaxNumber;

namespace GenericmaxNumber
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the First number: ");
            float first = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            float second = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            float third = Convert.ToSingle(Console.ReadLine());

            MaxNumber<float> maxnumObj = new MaxNumber<float>(first, second, third);
            var maxNumber = maxnumObj.GetMaxNum();

            Console.WriteLine("your max float number {0}", maxNumber);
        }
    }
}