internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę");
        int b = Int32.Parse(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("Podane liczby są równe");
        }
        else
        {
            Console.WriteLine("Podane liczby nie są równe");
        }

        Console.WriteLine("Podaj liczbę parzystą lub nieparzystą");
        int c = Int32.Parse(Console.ReadLine());

        if (c%2 == 0)
        {
            Console.WriteLine("Podana liczba jest parzysta");
        }
        else
        {
            Console.WriteLine("Podana liczba jest nieparzysta");
        }

        Console.WriteLine("Podaj liczbę dodatnią lub ujemną");
        int d = Int32.Parse(Console.ReadLine());   
        
        if (d > 0)
        {
            Console.WriteLine("Podana liczba jest dodatnia");
        }
        else if (d < 0)
        {
            Console.WriteLine("Podana liczba jest ujemna");
        }
        else
        {
            Console.WriteLine("Podana liczba nie jest dodatnia i nie jest ujemna");
        }

        Console.WriteLine("Podaj rok");
        int r = Int32.Parse(Console.ReadLine());

        if (r % 4 == 0 && r % 100 != 0) 
        {
            Console.WriteLine("Podany rok jest przestępny");
        }
        else
        {
            Console.WriteLine("Podany rok nie jest przestępny");
        }

        Console.WriteLine("Podaj swój wiek w dniu najbliższych wyborów");
        int w = Int32.Parse(Console.ReadLine());

        if (w>=18)
        {
            if (w >= 21)
            {
                if (w>=25)
                {
                    if (w>=30)
                    {
                        if (w>=35)
                        {
                            Console.WriteLine("Możesz być kim chcesz!");
                        }
                        else
                        {
                            Console.WriteLine("Możesz być radnym, posłem, prezydentem miasta lub senatorem");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Możesz być radnym, posłem lub prezydentem miasta");
                    }
                }
                else
                {
                    Console.WriteLine("Możesz być radnym lub posłem");
                }
            }
            else
            {
                Console.WriteLine("Możesz być radnym");
            }
        }
        else
        {
            Console.WriteLine("Nie możesz być radnym");
        }

        Console.WriteLine("Podaj wzrost");
        int h = Int32.Parse(Console.ReadLine());

        if (h>160) 
        {
            if (h > 190)
            {
                Console.WriteLine("Jesteś olbrzymem");
            }
            else
            {
                Console.WriteLine("Jesteś normalnego wzrostu");
            }
        }
        else
        {
            Console.WriteLine("Jesteś krasnoludem");
        }
    }

}