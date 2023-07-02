class Program
{
	static void Main(string[] args)
	{
        Mazzo mazzo = new Mazzo(); // creo un oggetto di tipo Mazzo
        mazzo.Mescola(); // mescolo le carte
        Carta carta = mazzo.Pesca(); // pesco una carta
        Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta


       
    }

}

// Output:
// cuori 10


//Nota che il prgoramma fa numero di semi per variabile de ciclo 13 