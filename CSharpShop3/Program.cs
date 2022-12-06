// See https://aka.ms/new-console-template for more information


//A partire da quanto già fatto con csharp-oop-shop-2 inserire correttamente le Eccezioni nei vostri Prodotti
//e sotto prodotti in modo da gestire
//correttamente gli eventi eccezionali, senza dover più fare un semplice Console.WriteLIne().
//Ricordatevi poi di testare le vostre classi, in particolare poi gestite e “catturate” correttamente le
//eccezioni nel vostro programma principale Program.cs e fate delle prove per simulare qualche situazione
//spiacevole per i vostri prodotti che avete previsto, in modo da verificare il comportamento delle vostre
//eccezioni.

//Come primo esercizio focalizzatevi bene SOLO sulla classe Prodotto e sottoclasse Acqua dove potete aggiungere
//le seguenti Eccezioni:
//nel costruttore di Acqua, non posso creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10.
//O ancora non posso avere una capienza sopra la capienza massima o negativa e così via.
//nel metodo bevi (double litriDaBere) se l’acqua finisce, restituire un eccezione magari costruita da voi.
//metodo riempi(double litri) che riempie la bottiglia di acqua e restituisce un eccezione se supero la sua capienza massima.
//un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la
//conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di
//codificare le costanti come 3.785 nel modo corretto come visto in classe).

//Una volta terminata la classe Prodotto e Acqua correttamente gestite anche le Eccezioni, vi chiedo di
//inserire un attributo statico alla classe Prodotto che permetta di contare quanti Prodotti ho istanziato fino
//ad un determinato istante nel mio programma. Alla fine o durante l’esecuzione del programma principale
//stampare in Console l’ammontare dei prodotti creati nel vostro negozio online.

//BONUS:
//Continuare gli stessi ragionamenti anche per tutte le altre sottoclassi che avevate pensato, come il
//sacchetto di frutta, l’elettrodomestico e così via.



using CSharpShop3;
//Dichiariazione viariabili
int code;
int iva;
float price;
string name;
string description;



//Assegnazione valori esempio
code = 0;
iva = 22;
price = 12.99f;
name = "I sentieri dei nidi di ragno";
description = "Autore Italo Calvino";




try
{
    //PRODOTTO ACQUA
    //variabili per creare eccezioni
    float ph = 7.5f;
    float litre = 1.5f;
    float drink = 1.5f;
    float fill = 2.3f;

    //quinto attributo è litre, la capienza che genera eccezione.
    //sesto attributo è il ph che genera eccezione
    //ottavo attributo è l'acqua che si beve.
    //nono tributo è i litri che vengono riempiti
    Acqua bottle1 = new Acqua("Sor", "Naturale", 1.9f, 6, litre, ph, "Trentino", drink, fill);


    //Richiedo variabili a classe Prodotto e Stampa
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("STAMPA PRODOTTO: BOTTIGLIA D'ACQUA");
    code = bottle1.GetCode();
    Console.WriteLine("Il codice creato per l'acqua è " + code);

    Console.WriteLine("Hai inserito i seguenti dati:");

    Console.WriteLine("Nome prodotto: " + bottle1.GetName());
    Console.WriteLine("Descrizione prodotto: " + bottle1.GetDescription());

    bottle1.FullName();
    bottle1.BasicPrice();
    bottle1.FullPrice();
    Console.WriteLine("-----------------------------------");

}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
















//creazione oggetti.
//Prodotto prodObject = new Prodotto(name, description, price, iva);



/*List<string> fruits = new List<string>() { "Mandorle", "Noci", "Nocciole" };
FruitsPack fruits1 = new FruitsPack("Pacco frutta secca", "mandorle ecc", 4.6f, 22, fruits);

Elettrodomestico washingMachine = new Elettrodomestico("Lavatrice", "Lava bene", 300f, 22, 24.7f, 52.2f, 1.05f, "Bianca");

CiboScatola tuna = new CiboScatola("Rio Mare", "Pescato nel mediterraneo", 3.4f, 22, "pesce", 500f, 400f);

*/

/*
//PRODOTTO ELETTRODOMESTICO

//Richiedo variabili a classe Prodotto e Stampa
Console.WriteLine("-----------------------------------");
Console.WriteLine("STAMPA PRODOTTO: LAVATRICE");
code = washingMachine.GetCode();
Console.WriteLine("Il codice creato per la lavatrice è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine("Nome prodotto: " + washingMachine.GetName());
Console.WriteLine("Descrizione prodotto: " + washingMachine.GetDescription());

washingMachine.FullName();
washingMachine.BasicPrice();
washingMachine.FullPrice();
Console.WriteLine("-----------------------------------");

//PRODOTTO CIBO IN SCATOLA

//Richiedo variabili a classe Prodotto e Stampa
Console.WriteLine("-----------------------------------");
Console.WriteLine("STAMPA PRODOTTO: CIBO IN SCATOLA");
code = tuna.GetCode();
Console.WriteLine("Il codice creato per il cibo in scatola è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine("Nome prodotto: " + tuna.GetName());
Console.WriteLine("Descrizione prodotto: " + tuna.GetDescription());

tuna.FullName();
tuna.BasicPrice();
tuna.FullPrice();
Console.WriteLine("-----------------------------------");



//PRODOTTO SACCHETTO FRUTTA

//Richiedo variabili a classe Prodotto e Stampa
Console.WriteLine("-----------------------------------");
Console.WriteLine("STAMPA PRODOTTO: SACCHETTO DI FRUTTA");
code = fruits1.GetCode();
Console.WriteLine("Il codice creato per il sacchetto di frutta è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine("Nome prodotto: " + fruits1.GetName());
Console.WriteLine("Descrizione prodotto: " + fruits1.GetDescription());



//Metodo che restituisce codice + nome
fruits1.FullName();



//Metodo che restituisce il prezzo base
fruits1.BasicPrice();
//Console.WriteLine(prodObject.GetPrice());



//Metodo che restituisce il prezzo compreso di IVA.
fruits1.FullPrice();
//Console.WriteLine(prodObject.GetIva());
Console.WriteLine("-----------------------------------");
*/

// PRODOTTO LIBRO
/*
//Set delle variabili nell'oggetto
prodObject.SetName(name);
prodObject.SetDescription(description);
prodObject.SetPrice(price);
prodObject.SetIva(iva);




//Richiedo variabili a classe Prodotto e Stampa
code = prodObject.GetCode();
Console.WriteLine("Il codice creato per il tuo libro è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine(prodObject.GetName());
Console.WriteLine(prodObject.GetDescription());



//Metodo che restituisce codice + nome
prodObject.FullName(name, code);



//Metodo che restituisce il prezzo base
prodObject.BasicPrice(price);
//Console.WriteLine(prodObject.GetPrice());



//Metodo che restituisce il prezzo compreso di IVA.
prodObject.FullPrice(price, iva);
//Console.WriteLine(prodObject.GetIva()); */
