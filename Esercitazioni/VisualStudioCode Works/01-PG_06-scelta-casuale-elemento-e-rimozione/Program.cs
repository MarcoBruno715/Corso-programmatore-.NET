
List<string> compagniDiCorso = new List<string> {"Josen","Arianna","Arash","Andrea","Vittorio","Giorgio","Marco","Jasmina","Davide","Daniele"};


Random rnd = new Random(); //Scegli un nome a caso dalla lista compagni
int indiceCasauale = rnd.Next(compagniDiCorso.Count); 
string nomeCasule = compagniDiCorso[indiceCasuale];

//Rimuovi il nome scelto a caso dalla lista dei compagni
compagniDiCorso.Remove(nomeCasuale);
//Stampa il nome scelto a caso e la lista dei compagni senza il nome rimosso nella console
Console.WriteLine("Il nome scelto a caso è" + nomeCasuale);
Console.WriteLine("I nomi dei compagni di corso senza il nome rimosso:");
foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}

Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

