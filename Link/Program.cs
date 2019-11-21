using System;

namespace Link
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLink link = new StudentLink();
            Student ichi = new Student("Raghav", 17);
            Student ni = new Student("Vivek", 44);
            Student san = new Student("Pranav", 13);
            Student yon = new Student("Deepa", 41);

            link.Add(ichi);
            link.Add(ni);
            link.Add(san);
            link.Add(yon);
            Console.WriteLine(link);

            //link.Remove();
            //Console.WriteLine(link);

            //link.Remove(ni);
            //Console.WriteLine(link);

            //link.Remove(ni.Name);
            //Console.WriteLine(link);

            try
            {
                Console.WriteLine(link.Find("Pranav"));
                Console.WriteLine(link.Find("Bob"));
            }
            catch (ItemNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
