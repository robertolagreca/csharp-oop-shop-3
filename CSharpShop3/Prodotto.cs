using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Prodotto
    {
        //dichiariazione variabili private
        private int code;
        private string name;
        private string description;
        private float price;
        private int iva;

        //dichiarazione variabile statica contatore
        private static int counterProducts = 0;


        //COSTRUTTORE
        public Prodotto(string name, string description, float price, int iva)
        {
            counterProducts++;
            CreateCode();

            //this.code = code;
            if(name == "")
            {
                counterProducts--;
                throw new ArgumentException("Il nome del prodotto non può essere vuoto", "Nome");
            }
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;
            
        }



        //SETTERS

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetPrice(float price)
        {
            this.price = price;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        /*public void SetCode (int code)
       {
           this.code = code;
       }*/




        //GETTERS

        public int GetCode() { return code; }
        public string GetName() { return name; }
        public string GetDescription() { return description; }
        public float GetPrice() { return price; }
        public int GetIva() { return iva; }
        public static int GetCounterProds() { return counterProducts; }


        //METODI

        //Generazione numero casuale
        private protected void CreateCode()
        {
            Random rnd = new Random();
            int randCode;
            randCode = rnd.Next(1, 101);
            //.Next(numeroMax escluso); Altro modo
            code = randCode;

        }
        //Toglie il prodotto non andato buon fine dal contatore
        public static void cancelCounterProd() 
        { counterProducts--; }

        //Stampa prezzo senza IVA
        public void BasicPrice()
        {
            Console.WriteLine("Il prezzo base è " + this.price + " euro");
        }

        //Stampa prezzo con IVA
        public void FullPrice()
        {
            float fullPrice;

            fullPrice = (float)Math.Round(this.price + (this.price * (iva / 100f)), 2);

            Console.WriteLine("Il prezzo compreso di IVA è  " + fullPrice.ToString() + " euro");
        }

        //Stampa codice+nome
        public virtual void FullName()
        {
            string fullName;

            fullName = this.code.ToString() + this.name;
            Console.WriteLine("Il nome completo è " + fullName);
        }

        public virtual void PrintGeneralDate()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("PRODOTTO NUMERO " + Prodotto.GetCounterProds());
            Console.WriteLine("STAMPA PRODOTTO");
            Console.WriteLine("-----------------------------------");
            code = GetCode();
            Console.WriteLine("Il codice creato per l'acqua è " + code);

            Console.WriteLine("Hai inserito i seguenti dati:");

            Console.WriteLine("Nome prodotto: " + GetName());
            Console.WriteLine("Descrizione prodotto: " + GetDescription());
        }
    }
}
