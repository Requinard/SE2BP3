namespace SE2Tentamen
{
    using System;

    public abstract class Drank : IVoorraad
    {
        /// <summary>
        ///     Inits drank
        /// </summary>
        /// <param name="prijs"></param>
        /// <param name="milliliter"></param>
        /// <param name="warmeDrank"></param>
        public Drank(decimal prijs, int milliliter, bool warmeDrank)
        {
            this.Prijs = prijs;
            this.Milliliter = milliliter;
            this.WarmeDrank = warmeDrank;
        }

        public decimal Prijs { get; private set; }

        public bool WarmeDrank { get; private set; }

        public int Milliliter { get; private set; }

        public string Naam { get; set; }

        public int Voorraad { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t- {1} EUR -{2} stuks", this.Naam, this.Prijs, this.Voorraad);
        }

        /// <summary>
        ///     Kijkt of de naam en types overeenkomen
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //Try and cast it as a drank
            try
            {
                return this.Naam == ((Drank)obj).Naam;
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
    }
}