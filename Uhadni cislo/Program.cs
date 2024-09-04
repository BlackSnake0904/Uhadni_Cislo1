namespace Uhadni_Cislo;

internal class Program
{
        
    private static void Main(string[] args)
    {
       bool hraPokracuje = true;

        Random cislo = new Random();
        var nahodneCislo = cislo.Next(1,51);

        Console.WriteLine("Witaj v hre uhadni cislo. Tvojou ulohou je uhadnut cislo na ktore PC mysli");
        while (hraPokracuje)
        {

            Console.WriteLine("zadaj cislo medzi 1 - 50");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && input < 50)
            {
                if (nahodneCislo == input)
                {
                    Console.WriteLine("Zadal si spravne cislo");
                    hraPokracuje = false;

                }
                else if (input < nahodneCislo) {
                    Console.WriteLine("Zadal si nizke cislo oproti hladanemu \n ________________________________");
                    

                } else 
                {
                    Console.WriteLine("Zadal si vysoke cislo cislo oproti hladanemu \n ________________________________");
                }
                                
            }
            else
            {
                Console.WriteLine("Zadal si zle cislo. Gratulujem");
            }
        }

        Console.WriteLine("Koniec hry");
    }

    
}