namespace Ejemplo_Interface
{
    internal class Program
    {
        class TestClass
        {

        }

        static void Main(string[] args)
        {
            Libro[] biblioteca = new Libro[5];

            var test = new TestClass();
            Object[] objectsToCompare = { test, test.ToString(), 123,
                                    123.ToString(), "some text",
                                    "Some Text" };
            string s = "some text";
            foreach (var objectToCompare in objectsToCompare)
            {
                try
                {
                    int i = s.CompareTo(objectToCompare);
                    Console.WriteLine("Comparing '{0}' with '{1}': {2}",
                                      s, objectToCompare, i);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Bad argument: {0} (type {1})",
                                      objectToCompare,
                                      objectToCompare.GetType().Name);
                }
            }
        }
    }
}