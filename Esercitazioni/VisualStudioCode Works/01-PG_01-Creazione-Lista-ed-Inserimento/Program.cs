//Creare una lista e inserire i nomi dei compagni del corso di informatica
/////////////////////////////////////////////////////////////////////////////
// le liste sono molto utili quando si deve riordinare gli elementi
// le liste sono molto utili quando si devono scegliere elementi a caso 
//() indica che il costruttore non ha parametri 
//List<string> compagniDiCorso = new list<string>(); è una dichiarazione di una  variabile di tipo List<string>
//List e una classe che contiene una serie di elementi
//string è un tipo di dato che contiene

//Crea una nuova lista di stringhe
List<string> compagniDiCorso = new List<string>();

//Aggiungi i nomi dei compagni alla lista

compagniDiCorso.Add("Josen");               //Add è un metodo della classe List
compagniDiCorso.Add("Arianna");
compagniDiCorso.Add("Arash");
compagniDiCorso.Add("andrea");
compagniDiCorso.Add("Vittorio");
compagniDiCorso.Add("Giorgio");
compagniDiCorso.Add("Marco");
compagniDiCorso.Add("Jasmina");
compagniDiCorso.Add("Davide");
compagniDiCorso.Add("Daniele");

//Stampa i nomi dei compagni nella console
Console.WriteLine("I nomi dei compagni di corso sono:");
foreach (string compagno in compagniDiCorso)  //foreach è un ciclo che scorre tutti gli elementi della lista
{
    Console.WriteLine(compagno);
}

//Attesa per l'input dell'utente prima di chiudere la finestra della console
Console.WriteLine("Premi un tasto per continuare....");
Console.ReadKey();