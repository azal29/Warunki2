internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wpisz ocenę numeryczną");

        string opis;
        opis = int.Parse(Console.ReadLine()) switch
        {
            1 => "Niedostateczny",
            2 => "Dopuszczający",
            3 => "Dostateczny",
            4 => "Dobry",
            5 => "Bardzo dobry",
            6 => "Celujący",
            _ => "Błąd"
        };

        Console.WriteLine(opis);


        Console.WriteLine("Wpisz numer dnia tygodnia");

        string dzien;
        dzien = int.Parse(Console.ReadLine()) switch
        {
            1 => "Poniedziałek",
            2 => "Wtorek",
            3 => "Środa",
            4 => "Czwartek",
            5 => "Piątek",
            6 => "Sobota",
            7 => "Niedziela",
            _ => "Błąd"
        };

        Console.WriteLine(dzien);

        //Prosty kalkulator

        Console.WriteLine("Podaj pierwszą liczbę:");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę:");
        int b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj numer opcji do wykonania:");
        Console.WriteLine("1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4.Dzielenie");

        string wynik;
        wynik = Console.ReadLine() switch
        {
            "1" => "Twój wynik to " + (a + b),
            "2" => "Twój wynik to " + (a - b),
            "3" => "Twój wynik to " + (a * b),
            "4" => "Twój wynik to " + (a / b),
            _ => "Błędny wybór"
        };

        Console.WriteLine(wynik);
    }
}