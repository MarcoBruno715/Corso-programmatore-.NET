
class Mazzo
{
	private Carta[] carte; // array di carte
    
    

    public Mazzo() // costruttore della classe Mazzo
	{
		this.carte = new Carta[13]; // inizializzo l'array di carte con 52 cart               NUMERO CARTE
		
		
		string[] semi = { "cuori" }; // creo un array di stringhe con i semi delle carte           SEMI
		int indice = 0; // indice per l'array di carte
		for (int i = 0; i < semi.Length; i++) // ciclo per i semi
		{
			for (int j = 1; j <= 13; j++) // ciclo per i valori
			{
				this.carte[indice] = new Carta(semi[i], j); // creo una carta con seme semi[i] e valore j e la assegno all'array di carte
				indice++; // incremento l'indice
			}
		}
	}

	public void Mescola() // metodo per mescolare le carte
	{
		Random rnd = new Random(); // creo un oggetto di tipo Random
		for (int i = 0; i < this.carte.Length; i++) // ciclo per le carte
		{
			int indiceCasuale = rnd.Next(0, this.carte.Length); // creo un indice casuale
			Carta cartaCasuale = this.carte[indiceCasuale]; // creo una carta casuale
			this.carte[indiceCasuale] = this.carte[i]; // assegno alla carta casuale la carta i
			this.carte[i] = cartaCasuale; // assegno alla carta i la carta casuale
		}
	}

	public Carta Pesca() // metodo per pescare una carta         
	{
		Carta carta = this.carte[0]; // creo una carta e la assegno alla prima carta dell'array di carte
		Carta[] carteNuove = new Carta[this.carte.Length - 1]; // creo un array di carte con una carta in meno
		for (int i = 1; i < this.carte.Length; i++) // ciclo per le carte
		{
			carteNuove[i - 1] = this.carte [0]; // assegno alla carta i - 1 la carta i dell'array di carte originale (in questo modo la prima carta viene saltata)
		}
		this.carte = carteNuove; // assegno all'array di carte originale l'array di carte con una carta in meno
		return carta; // ritorno la carta
	}

	

	}










    //int[] myNum = { 2, 9, 17 };















    //Proprietà di larghezza
    /*public int Larghezza
    {
        get { return this.larghezzaCarta; }
        set
        {
            if (value > 0)
                this.larghezzaCarta = value;
            else
                throw new Exception("La larghezza del mazzo non può essere un valore
                negativo");
        }*/
    












    /*public Carta prendiCarta()
    {
        if (!mazzoVuoto())
        {
            //Selezioniamo dalla lista il primo elemento
            Carta scelta = new Carta();
            scelta = carte.FirstOrDefault();
            carte.Remove(scelta);
            return scelta;
        }
        else
            throw new Exception("Mazzo vuoto, impossibile selezionare una carta! ");*/









    