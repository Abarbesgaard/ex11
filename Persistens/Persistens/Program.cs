namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string loadedPerson;
            Person person = new Person("Mike", new DateTime(1975, 8, 24), 175.9, true, 3);

            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePerson(person);

            handler.LoadPerson();
            //Console.WriteLine(person.MakeTitle());


            Console.ReadLine();
        }
    }
}