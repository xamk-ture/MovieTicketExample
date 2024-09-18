namespace MovieTicket
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 10, 20, 30, 0, 50 };
            bool validInput = false;

            while (!validInput)
            {
                try
                {

                    // Ask for the first index number
                    Console.Write("Enter the first index number (0-5): ");
                    int index1 = Convert.ToInt32(Console.ReadLine());
                    int value1 = numbers[index1];

                    // Ask for the second index number
                    Console.Write("Enter the second index number (0-5): ");
                    int index2 = Convert.ToInt32(Console.ReadLine());
                    int value2 = numbers[index2];

                    // Check that the division is not by zero
                    if (value2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    // Calculate and display the result
                    double result = (double)value1 / value2;
                    Console.WriteLine($"Result: {value1} / {value2} = {result}");
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error: Index is out of bounds!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                }
            }
        }
    }

}
