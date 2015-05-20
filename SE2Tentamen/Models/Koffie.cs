namespace SE2Tentamen
{
    public class Koffie : Drank
    {
        public Koffie(decimal prijs, int milliliter, bool warmeDrank, int milligramCaffeinie)
            : base(prijs, milliliter, warmeDrank)
        {
            this.MilligramCaffeinie = milligramCaffeinie;
        }

        public int MilligramCaffeinie { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} mg Caffeine", base.ToString(), this.MilligramCaffeinie);
        }
    }
}