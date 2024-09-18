internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.WriteLine("-------CALCULATOR-------");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            string sign = Console.ReadLine();

            if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
            {
                Console.Clear();
                Console.WriteLine("Give me first number: ");
                int l1 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Give me second number: ");
                int l2 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (sign)
                {
                    case "+":
                        Console.WriteLine($"You choose (+): {l1} + {l2} = {l1 + l2}");
                        break;
                    case "-":
                        Console.WriteLine($"You choose (-): {l1} - {l2} = {l1 - l2}");
                        break;
                    case "*":
                        Console.WriteLine($"You choose (*): {l1} * {l2} = {l1 * l2}");
                        break;
                    case "/":
                        Console.WriteLine($"You choose (/): {l1} / {l2} = {l1 / l2}");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Restart?\n 0=(NO) 1=(YES)");
                i = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You chose sign that doesn't exist");
                Console.WriteLine();
                Console.WriteLine("Restart?\n 0=(NO) 1=(YES)");
                i = int.Parse(Console.ReadLine());
                Console.Clear();
            }



        } while (i == 1);
    }
}