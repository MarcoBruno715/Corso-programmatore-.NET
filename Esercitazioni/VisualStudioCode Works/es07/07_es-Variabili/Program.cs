
using System.Transactions;
//Scrivi un programma che dichiara una variabile intera e stampa il valore della variabile nella console

int num = 1;
Console.WriteLine("questo è ; " + num);


                                                  // variabile a virgola mobile 

double num = 2.45;
Console.WriteLine("questo è :" +num );

                                                  // booleana

bool Num = true;
Console.WriteLine(Num);

                                                  //di tipo stringa

string Esercizio = "woow";
Console.WriteLine(Esercizio);    

//Scrivi un programma che chiede all'utente di inserire il proprio nome e l'età e poi stampa una frase che li contiene.


//Chiedere si inserire l'età
Console.WriteLine("Inserisci il tuo Nome ");
//leggi a console cosa scrivo
string nome = Console.ReadLine();
//Inserisci l'età
Console.WriteLine("Inserisci la tua Età");
//Leggi cosa scrivo
string Età = Console.ReadLine();
//Leggi nome + età 
Console.WriteLine("Il il tuo nome ed Età sono :" +nome +  Età + "anni" );




Console.WriteLine("Inserisci il tuo Nome ed Età ");
string NomeEdEtà = Console.ReadLine();
Console.WriteLine("Il il tuo nome ed Età sono :" +NomeEdEtà );

/*+++++++++++++++++++++++++++++++-----Con metodo Parse------++++++++++++++++++++++++++++++++++++++*/

Console.WriteLine("Inserisci il tuo nome");

string name = Console.ReadLine(); // ReadLine è un metodo che legge una stringa della console 

Console.WriteLine("Inserisci la tua età : ");

//Legge un intero della console con Console.Readline

int age = int.Parse(Console.ReadLine()); //Parse è un metodo che converte una stringa in un intero 

Console.WriteLine("Ciao, " + name + "! Hai " + age + "anni."); // stampa una frase che contiene l nome e l'età




//scrivi un programma che chiede all'utente di  inserire età e che stampi "sei maggiorenne" se l'età è maggiore o uguale a 18, altrimenti stampa "sei minorenne"


Console.WriteLine("Inserisci la tua età : "); //Legge un intero della console con Console.Readline

int age = int.Parse(Console.ReadLine()); //  Parse è un metodo che converte una stringa in un intero 

if (age >= 18)
{

    Console.WriteLine("Sei magg " ); //Condizione se imput age è maggiore di 18 allora sei maggiorenne se no Sei minorenne

} else

{
    Console.WriteLine(" Sei minn "); //se no sei minorenne
}



/*Scrivi un programma che chiede all'utente di inserire un numero intero , quindi stampa "il numero è positivo" 
se il numero e positivo , "Il numero è negativo" se il numero è < zero e "Il numero è zero" se il numero è uguale a zero 
*/

Console.WriteLine("Inserisci un numero intero : "); //Legge un intero della console con Console.Readline

int num = int.Parse(Console.ReadLine()); //  Parse è un metodo che converte una stringa in un intero 

if (num > 0)

{

    Console.WriteLine("Il numero è positivo."); //Condizione se imput age è maggiore 

}
else if (num < 0)

{
    Console.WriteLine("Il numero è negativo."); //

} else  

{
    Console.WriteLine("Il numero è zero."); //
}




                                
                     /*Scrivi un programma che dichiara un array di stringhe contenente i nomi di tre persone e stampa il secondo 
nome dell'array*/


class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4}; // dichiarazione di un array di interi di nome "numbers"

        //dichiarazione di una lista di stringhe di nome "names"
        List<string> names = new List<string>(); // List è una classe che rappresenta una lista d oggetti

        //aggiungi un elemento alla lista
        names.Add("Gio");    //Posizione 0
        names.Add("Sara");   //Posizione 1
        names.Add("Marco");   //Posizione 2
       

        //stampa il valore della variabile nella console con Console WriteLine
       
        Console.WriteLine("THe second name is" + names[2] + ".");


    }
}


  //Si puo' anche fare 
  //dichiara un array di stringhe contenetnte i nomi di tre persone 

   string[] names = {"Alice" , "Bob" , "Charlie"};

   //stamap il secondo nome dell'array
   Console.WriteLine(names[1]);

//Scrivi un programma che dichiara due variabili intere , una contenente il valore 10 l'altra contenente il valore 20
//Quindi le somme e stampa il risultato.



//Scrivi un programma che dichiara due variabili intere , una contenente il valore 10 l'altra contenente il valore 20
//Quindi le sommi e stampa il risultato.

int x = 10;          //Dichiaro una  variabile 10

int y = 20;         //Dichiaro un variabile 20


Console.WriteLine(x + y);
 //////// or
int sum = x + y;
Console.WriteLine(sum);



//Scrivi un programma che dichiara un array di stringhe contenenti i nomi di tre città, e poi stampa tutti i nomi,
//delle città con la parola "città" aggiungi alla fine ciascun nome.



string[] Città = {"Acerra" , "Bacoli" , " Cagliari"}; //Serie di citta con comando Array

Console.WriteLine("Città" +[0] + "Città" + [1] "Città" + [2]) ; //Errato 

//////////////////////////////

class Program
{

    static void Main(string[] args)
    {


        string[] city = { "Milano", "Genova", "Roma", }; //Dichiaro un array di stringhe contenente i nomi di tre città
      //stampa i nomi della città con la parola "Città" aggiunta alla fine di ciascun nome
        foreach (string i in city)
        // per ogni città nell'Array
            Console.WriteLine(i + "citta"); //stampa il nome della città con la parola città aggiunta lla fine 
    }
}

//Scrivi un programma che stampa i numeri da 1 a 10 utilizzando i ciclo while (Ciclo di flusso)


int n = 1; // dichiara valoriabile
while (n <= 10)   
Console.WriteLine(n);
n++;

//Scrivi un programma che stampa i numeri da 1 a 10 utilizzando un ciclo for.

for (int p = 1; 1 <= 10; p++)  //Dichiara 
Console.WriteLine(p); //Dichiara 


//Scrivi un programma che dichiara un array di interi vuoto , quindi stampa il numero di elementi dell'array nella console.

//dichiara un array di interi vuoto
int[] num = new int[0];
//stampa il numero di elementi dell'array
Console.WriteLine(num.Length);
/////////////////////////////////////////////////

int[] numbers = { 1, 2, 3, 4, 5 };
//stampa il numero di elementi dell'array
Console.WriteLine(numbers.Length);


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
























