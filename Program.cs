using GenericMaxNumber;

namespace GenericmaxNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the First float number: ");
            float first= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the second float number: ");
            float second= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the third float number: ");
            float third = Convert.ToSingle(Console.ReadLine());

            MaxNumber maxnumObj = new MaxNumber(first,second,third);
            float maxNumber = maxnumObj.GetMaxNum();

            Console.WriteLine("your max number {0}", maxNumber);
        }
    }
}