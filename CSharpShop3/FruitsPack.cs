using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class FruitsPack : Prodotto
    {
        //ATTRIBUTI
        private List<string> fruitsList;

        //COSTRUTTORE
        public FruitsPack(string name, string description, float price, int iva, List<string> fruitsList) : base(name, description, price, iva)
        {
            this.fruitsList = fruitsList;

        }



        //GET
        public List<string> GetFruitsList() { return fruitsList; }



        //METODI D'UTILITA'
        private void printList()
        {
            Console.WriteLine("Stampa lista frutta sacchetto");
            foreach (String fruit in this.fruitsList)
            {

                Console.WriteLine(fruit);
            }

        }

        //METODI PUBBLICI
        public override void FullName()
        {
            base.FullName();
            printList();
        }
    }
}
