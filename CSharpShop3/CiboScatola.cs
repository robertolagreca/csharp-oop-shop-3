using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class CiboScatola : Prodotto
    {
        private string foodType;
        private float weightTotal;
        private float weightNetto;

        public CiboScatola(string name, string description, float price, int iva, string foodType, float weightTotal, float weightNetto) : base(name, description, price, iva)
        {
            this.foodType = foodType;
            this.weightTotal = weightTotal;
            this.weightNetto = weightNetto;

            if (weightNetto > 300f)
            {
                this.weightNetto = 300f;
            }
        }

        public string GetFoodType() { return foodType; }
        public float GetWeightTotal() { return weightTotal; }
        public float GetWeightNetto() { return weightNetto; }

        //SETTERS

        public override void FullName()
        {
            base.FullName();
            Console.WriteLine("Tipologia di cibo in scatola " + this.foodType);
            Console.WriteLine("Il peso lordo è " + this.weightTotal);
            Console.WriteLine("Il peso netto è " + this.weightNetto);
        }

        public override void PrintGeneralDate()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("PRODOTTO CREATO: CIBO IN SCATOLA");
            base.PrintGeneralDate();
        }
    }
}
