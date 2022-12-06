using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Acqua : Prodotto
    {
        //ATTRIBUTI
        float litre;
        float ph;
        float drink;
        float fill;
        float empty;
        string source;

        //COSTRUTTORI
        public Acqua(string name, string description, float price, int iva, float litre, float ph, string source, float drink = 0f, float fill = 0f, float empty = 0f) : base(name, description, price, iva)
        {
            //CreateCode(); usa in automatico quello della super classe
            this.litre = litre;
            this.drink = drink;
            this.fill = fill;
            this.empty = empty;
            this.ph = ph;
            this.source = source;
        }

        //GETTERS

        //public int GetCode() { return code; }
        public float GetLitre() { return litre; }
        public float GetDrink() { return drink; }
        public float GetFill() { return fill; }
        public float GetEmpty() { return empty; }
        public float GetPh() { return ph; }
        public string GetSource() { return source; }

        //SETTERS

        //METODI D'UTILITA'

        private float drinkBottle()
        {
            float newLitres;
            newLitres = (float)this.litre - this.drink;

            return newLitres;
        }

        private float fillBottle()
        {
            float newLitres;
            newLitres = (float)this.litre + this.fill;
            if (this.fill > this.litre)
            {
                return this.litre;
            }

            return newLitres;
        }

        private float emptyBottle()
        {
            return this.litre = (float)0;
        }

        //METODI PUBBLICI
        public override void FullName()
        {
            base.FullName();
            Console.WriteLine("La sua sorgente è " + this.source);
            Console.WriteLine("Capacita di " + this.litre);
            Console.WriteLine("Il pH è " + this.ph);
            Console.WriteLine("Consumato " + this.drink + " l. Acqua rimasta nella bottiglia " + drinkBottle());
        }
    }
}
