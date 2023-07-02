//chiedo input ad utente
Console.WriteLine("Inserisci nun numero intero");
//Legge input dell' utente
string input = Console.ReadLine();
//variabile intera chiamata num
int num;
//variabile success può avere 2 stati che dipendono dalla riuscita del try parse
bool success = int.TryParse(input, out num);

if (success)

{
    Console.ForegroundColor = ConsolColor.Blue
    Console.WriteLine("Il doppio del numero inserito è :" + (num * 2));

}

else
{
    Console.ForegroundColor = ConsolColor
    Console.WriteLine("Input non valido");  

}