
//Scegliere un nome a caso della lista dei compagni rimuoverlo dalla lista , finche la lista non viene esaurita


List<string> compagniDiCorso = new List<string> { "Josen", "Arianna", "Arash", "Andrea", "Vittorio", "Giorgio", "Marco", "Jasmina", "Davide", "Daniele" };
Random rnd = new Random();
while (compagniDiCorso.Count > 0)
{

     //Scegli un nome a caso dalla lista compagni
    int indiceCasuale = rnd.Next(compagniDiCorso.Count);
    string nomeCasuale = compagniDiCorso[indiceCasuale];
    Console.WriteLine("Il nome scelto a caso è" + nomeCasuale);
    compagniDiCorso.Remove(nomeCasuale);
    Console.WriteLine("I nomi dei compagni di corso senza il nome rimosso sono:");
    
foreach (string compagno in compagniDiCorso)
    {
        Console.WriteLine(compagno);
    }
    Console.WriteLine("Premi un tasto per contimuare....");

Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();
}
//Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un testo per continuare...");
Console.ReadKey();

