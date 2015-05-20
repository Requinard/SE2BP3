namespace SE2Tentamen
{
    using System;

    public class Beker : IVoorraad
    {
        public Beker(string naam, int milliliter, bool warmeDrankMogelijk)
        {
            this.Naam = naam;
            this.Milliliter = milliliter;
            this.WarmeDrankMogelijk = warmeDrankMogelijk;
        }

        public int Milliliter { get; private set; }

        public bool WarmeDrankMogelijk { get; private set; }

        public string Naam { get; set; }

        public int Voorraad { get; set; }

        public override bool Equals(object obj)
        {
            try
            {
                return this.Naam == ((Beker)obj).Naam;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var hotOrCold = "";
            if (this.WarmeDrankMogelijk)
            {
                hotOrCold = "Warm";
            }
            else
            {
                hotOrCold = "Koud";
            }
            return string.Format(
                "{0}\t- {1} - {2} - {3} stuks",
                this.Naam,
                this.Milliliter,
                this.WarmeDrankMogelijk,
                this.Voorraad);
        }
    }
}