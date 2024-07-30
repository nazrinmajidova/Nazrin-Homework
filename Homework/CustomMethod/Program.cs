namespace CustomMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, };
            Console.WriteLine(string.Join(" ", array));

            Array.CustomResize(ref array, 6, 7, 8, 9, 10);
            Console.WriteLine(string.Join(" ", array));
        }
    }
       
}
