
class Program
{
    static void Main(string[] args)

    {
        {



            {
                Mazzo mazzo = new Mazzo(); // creo un oggetto di tipo Mazzo
                mazzo.Mescola(); // mescolo le carte
                Carta carta = mazzo.Pesca(); // pesco una carta
                Carta carta1 = mazzo.Pesca();
                Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
                Console.WriteLine(carta1.GetSeme() + " " + carta1.GetValore()); // stampo il seme e il valore della carta

            }


        }
    }

}
// Output:
// cuori 10

//Nota che il programma calcola numero di semi per variabile del ciclo 13 