// See https://aka.ms/new-console-template for more information

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



//creazione oggetti.
//Prodotto prodObject = new Prodotto(name, description, price, iva);
Acqua bottle1 = new Acqua("Sor", "Naturale", 1.9f, 6, 1.5f, 8, "Trentino", 1f);

List<string> fruits = new List<string>() { "Mandorle", "Noci", "Nocciole" };
FruitsPack fruits1 = new FruitsPack("Pacco frutta secca", "mandorle ecc", 4.6f, 22, fruits);

Elettrodomestico washingMachine = new Elettrodomestico("Lavatrice", "Lava bene", 300f, 22, 24.7f, 52.2f, 1.05f, "Bianca");

CiboScatola tuna = new CiboScatola("Rio Mare", "Pescato nel mediterraneo", 3.4f, 22, "pesce", 500f, 400f);

//PRODOTTO ACQUA

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
