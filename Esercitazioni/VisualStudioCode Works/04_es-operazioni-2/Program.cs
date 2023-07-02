// metodo di input
Console.WriteLine("INSERISCI LA TEMPERATURA IN GRADI Celsius: ");
//leggo input come stringa
string input = Console.ReadLine();
//dichiaro variabile double celsius
double Celsius;
//dichiaro varibile booleana verificando il valore input
bool success = double.TryParse(input, out Celsius);
// Se metodo tryParse viene verificato (esito positivo)
if (success)
{
    // effettuo il calcolo di conversione
    double fahrenheit = (Celsius * 9 / 5) + 32;
    //stampo il risultato a video
    Console.WriteLine("La temperatura in gradi fahrenheit è: " + fahrenheit);

}
else
{    
    // stampo risultato
    Console.WriteLine("input non valido!");
}


