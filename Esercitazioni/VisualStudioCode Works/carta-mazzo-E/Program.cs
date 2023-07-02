
class Program
{

    static void Main(string[] args)

    {

        Console.WriteLine("Quante carte vuoi pescare ?");
        string input = Console.ReadLine();
        int num;
        bool success = int.TryParse(input, out num);
        int risultato;
        while (true)
        {
            if (!success)
            {
                Console.WriteLine("ERRORE ! Inserisci un numero!");
                Console.ReadLine();
                return;
            }
            if (num == 1)
            {

                Mazzo mazzo = new Mazzo(); // creo un oggetto di tipo Mazzo
                mazzo.Mescola(); // mescolo le carte
                Carta carta = mazzo.Pesca(); // pesco una carta   
                Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
                Console.ReadLine();
                break;

            }
            if (num == 2)
            {
                Mazzo mazzo = new Mazzo(); // creo un oggetto di tipo Mazzo
                mazzo.Mescola(); // mescolo le carte
                Carta carta = mazzo.Pesca(); // pesco una carta   
                Carta carta1 = mazzo.Pesca();
                Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
                Console.WriteLine(carta1.GetSeme() + " " + carta1.GetValore());
                Console.ReadLine();
                break;
            }

            if (num == 3)
            {
                Mazzo mazzo = new Mazzo(); // creo un oggetto di tipo Mazzo
                mazzo.Mescola(); // mescolo le carte
                Carta carta = mazzo.Pesca(); // pesco una carta
                Carta carta1 = mazzo.Pesca();
                mazzo.Mescola(); // mescolo le carte
                Carta carta2 = mazzo.Pesca();
                Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
                Console.ReadLine();
                Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
                Console.ReadLine();
                Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
                Console.ReadLine();
                break;
            }
        }
    }

}



/*


        ///   modifico il valore del primo elemento
        myNum[0] = 11;

        Console.WriteLine("Primo elemento: {0}", myNum[0]);
        Console.ReadLine();
*/
// Output:
// cuori 10


//Nota che il prgoramma fa numero di semi per variabile de ciclo 13 

/*
if (Carta.Count > 20)
            {
                 Console.WriteLine("ERRORE ! Impossibile pescare piu di 20 carte !");
            }*/

           // if (dado.Count(d=> d.faccia == i) == 2)