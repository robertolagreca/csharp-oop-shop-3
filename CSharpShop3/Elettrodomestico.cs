using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Elettrodomestico : Prodotto
    {
        //Attributi
        private float weight;
        private float width;
        private float height;
        private string color;

        //COSTRUTTORE
        public Elettrodomestico(string name, string description, float price, int iva, float weight, float width, float height, string color) : base(name, description, price, iva)
        {
            this.weight = weight;
            this.width = width;
            this.height = height;
            this.color = color;
        }

        //GETTERS
        public float GetWeight() { return weight; }
        public float GetWidth() { return width; }
        public float GetHeight() { return height; }
        public string GetColor() { return color; }

        public override void FullName()
        {
            base.FullName();
            Console.WriteLine("Il suo peso è " + this.weight);
            Console.WriteLine("La sua larghezza è " + this.width);
            Console.WriteLine("La sua altezza è " + this.height);
            Console.WriteLine("Il suo colore è " + this.color);
        }
    }
}
