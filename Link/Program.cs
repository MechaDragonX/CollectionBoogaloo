using System;

namespace Link
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLink link = new StudentLink();
            Student one = new Student("Roger", 17);
            Student two = new Student("Vlad", 44);
            Student three = new Student("Parson", 13);
            Student four = new Student("David", 41);

            link.Add(one);
            link.Add(two);
            link.Add(three);
            link.Add(four);
            Console.WriteLine(link);

            //link.Remove();
            //Console.WriteLine(link);

            //link.Remove(ni);
            //Console.WriteLine(link);

            //link.Remove(ni.Name);
            //Console.WriteLine(link);

            try
            {
                Console.WriteLine(link.Find("Parson"));
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
