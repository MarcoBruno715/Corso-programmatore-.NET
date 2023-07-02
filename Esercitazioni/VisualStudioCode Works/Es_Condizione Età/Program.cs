
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