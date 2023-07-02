//entry point metodo main
static void Main(string[] args)
{
    //Creo array contenente questi valori
    int[] numeri = { 5, 7, 10, 3, 4, };
    //Metodo stampa
    Console.WriteLine("La somma degli elementi dell'array: " + SommaArray(numeri));

}
//funziona ausiliaria
static int SommaArray(int[] array)
{
    int somma = 0;
    //ciclo for per sommare i numeri
    foreach (int numero in array)

    {
        
         somma += numero;
    }
    return somma;

}




