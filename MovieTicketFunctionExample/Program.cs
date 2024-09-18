namespace MovieTicketFunctionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = GetCustomerName();
            int age = GetCustomerAge();

            InformUserTicketTypes();

            double ticketPrice = GetTicketPrice();

            bool hasDiscount = HasUserDiscountCode();
            double discountPercentage = 0;

            if (hasDiscount == true)
            {
                discountPercentage = GetDiscountPercentage();
            }

            double finalTicketPrice = CalculateFinalTicketPrice(ticketPrice, discountPercentage);

            PrintFinalPrice(name, finalTicketPrice);
        }

        static string GetCustomerName()
        {
            Console.WriteLine("Anna nimesi");

            string name = Console.ReadLine();

            return name;
        }

        static int GetCustomerAge()
        {
            Console.WriteLine("Anna ikäsi");

            int age = 0;

            while (true)
            {
                bool ageConversionSucces = int.TryParse(Console.ReadLine(), out age);

                if (ageConversionSucces == false)
                {
                    Console.WriteLine("Virheellinen ikä, syötä uudelleen");
                }
                else
                {
                    break;
                }
            }

            return age;
        }


        static void InformUserTicketTypes()
        {
            Console.WriteLine("Valitse lipputyyppi");

            Console.WriteLine("1: Lastenlippu(alle 12 - vuotiaille)");
            Console.WriteLine("2: Aikuisten lippu(12–64 - vuotiaille)");
            Console.WriteLine("3: Seniorilippu(65 - vuotiaille ja vanhemmille)");
        }

        static double GetTicketPrice()
        {
            int ticketType = 0;
            bool ticketConversionSuccess = false;
            double ticketPrice = 0;

            while (ticketConversionSuccess == false)
            {
                ticketConversionSuccess = int.TryParse(Console.ReadLine(), out ticketType);

                if (ticketType == 1)
                {
                    ticketPrice = 5;
                }
                else if (ticketType == 2)
                {
                    ticketPrice = 10;
                }
                else if (ticketType == 3)
                {
                    ticketPrice = 7;
                }
                else
                {
                    Console.WriteLine("Virheellinen lipputyyppi. Syötä lipputyyppi uudestaan");
                }

            }

            return ticketPrice;
        }

        static double GetDiscountPercentage()
        {
            double discountPercentage = 0;

            Console.WriteLine("Syötä alennuskoodi");

            string discountCode = Console.ReadLine();

            if (discountCode == "ALE20")
            {
                discountPercentage = 20;
            }
            else if (discountCode == "ALE30")
            {
                discountPercentage = 30;
            }
            else
            {
                Console.WriteLine("Väärä alennuskoodi");
            }

            return discountPercentage;
        }

        static bool HasUserDiscountCode()
        {
            Console.WriteLine("Onko alennus koodia? Vastaa kyllä, jos sinulla on");
            bool hasDiscount = Console.ReadLine() == "kyllä";

            return hasDiscount;
        }

        private static void PrintFinalPrice(string name, double finalTicketPrice)
        {
            Console.WriteLine($"Lipun hinta {name} on: {finalTicketPrice}");
        }

        static double CalculateFinalTicketPrice(double ticketPrice, double discountPercentage)
        {
            double finalTicketPrice = ticketPrice;

            if (discountPercentage > 0)
            {
                finalTicketPrice = ticketPrice * ((100 - discountPercentage) / 100);
            }

            return finalTicketPrice;
        }
    }

}
