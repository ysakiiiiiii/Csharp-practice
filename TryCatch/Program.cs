using System.Diagnostics;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            try
            {
                Console.Write("Enter a number : ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 0;
                result = num1 / num2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(FormatException ex)
            {
                Console.WriteLine("ENTER A NUMBER " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("That's a large number" + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }

            //Console.Write("Enter Age: ");
            //GetUserAge(Console.ReadLine());

        }

        static int GetUserAge(string input)
        {
            int age;

            if(!int.TryParse(input, out age)){
                throw new Exception("You did not enter a valid age");
            }
            if(age < 0 || age > 120)
            {
                throw new Exception("Your age must be betwteen 0 and 120");
            }

            return age;
        }
    }
}
