internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wpisz trzy liczby");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int m;
            m = (a > c) ? m = a : m = c;
            Console.WriteLine(m + " jest największa z podanych");
        }
        else
        {
            int m;
            m = (b > c) ? m = b : m = c;
            Console.WriteLine(m + " jest największa z podanych");
        }

        Console.WriteLine("Wpisz wyniki z następujących przedmiotów: matematyka, fizyka, chemia");
        int mat = int.Parse(Console.ReadLine());
        int fiz = int.Parse(Console.ReadLine());
        int chem = int.Parse(Console.ReadLine());
        int suma = mat + fiz + chem;
        int suma1 = mat + fiz;
        int suma2 = mat + chem;

        if (suma1 > 150 || suma2 > 150)
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else if (mat > 70 && fiz > 55 && chem > 45 && suma > 180)
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
        }


        Console.WriteLine("Wprowadź temperaturę w stopniach Celsjusza");
        int temp = int.Parse(Console.ReadLine());
        switch (temp)
        {
            case < 0:
                Console.WriteLine("cholernie piździ");
                break;
            case < 10:
                Console.WriteLine("zimno");
                break;
            case < 20:
                Console.WriteLine("chłodno");
                break;
            case < 30:
                Console.WriteLine("w sam raz");
                break;
            case < 40:
                Console.WriteLine("zaczyna być słabo, bo gorąco");
                break;
            default:
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
                break;
        }

        Console.WriteLine("Wprowadź długości boków trójkąta");
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        if (d > e && d > f)
        {
            Console.WriteLine(d < e + f ? "Można zbudować trójkąt" : "Nie można zbudować trójkąta");
        }
        else if (d > e && d < f)
        {
            Console.WriteLine(f < d + e ? "Można zbudować trójkąt" : "Nie można zbudować trójkąta");
        }
        else
        {
            Console.WriteLine(e < d + f ? "Można zbudować trójkąt" : "Nie można zbudować trójkąta");
        }

    }
}