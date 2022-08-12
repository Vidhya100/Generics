using GenericMaxNumber;

namespace GenericmaxNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the First string: ");
            string first= Console.ReadLine();

            Console.WriteLine("Enter the second string: ");
            string second= Console.ReadLine();

            Console.WriteLine("Enter the third string: ");
            string third = Console.ReadLine();

            MaxNumber maxnumObj = new MaxNumber(first,second,third);
            string last = maxnumObj.GetLastString();

            Console.WriteLine("The last string in the sort order by comparedTo method is : {0}", last);
        }
    }
}