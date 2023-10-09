using System.Linq.Expressions;

class ExceptionHandler
{
    // Exception handling for readline ints
    public static int ReadInt()
    {
        while(true)
        {
            try
            {
                int output = int.Parse(Console.ReadLine());
                return output;
            } 
            catch (Exception)
            {
                Console.WriteLine("Please input valid integer");
            }
        }
        
        
    }
    public static string ReadString()
    {
        while(true)
        {
            try
            {
                string output = Console.ReadLine();
                return output;
            }
            catch (Exception)
            {
                Console.WriteLine("Please input valid string");
            }
        }
    }
}