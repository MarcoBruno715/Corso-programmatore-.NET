//Creo una nuova lista di stringhe e aggiungi i nomi dei compagni
List<string> compagniDiCorso = new List<string> {"Josen","Arianna","Arash","Andrea","Vittorio","Giorgio","Marco","Jasmina","Davide","Daniele"};


//Rimuovi i nomi di più compagni specifici della lista
compagniDiCorso.RemoveAll(nome => nome == "Marco"|| nome == "Josen"); //RemoveAll è un metodo della classe List

//Stampa i nomi dei compagni nella console dopo la rimozione 
Console.WriteLine("I nomi dei compagni di corso dopo la rimozione di Marco e Josen sono:");

foreach (string compagno in compagniDiCorso)
{
    Console.WriteLine(compagno);
}


//Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare...");
Console.ReadKey();

