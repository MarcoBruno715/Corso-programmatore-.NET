//Creo una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> {"Josen","Arianna","Arash","Andrea","Vittorio","Giorgio","Marco","Jasmina","Davide","Daniele"};

//Riordinare i nomi dei compagni in ordine alfabetico
compagniDiCorso.Sort(); //Sort è un metodo della classe list

//Stampa i nomi dei compagni riordinati nella console
Console.WriteLine("I nomi dei compagni di corso riordinati in ordine alfabetico sono:");

foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}

//Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

