namespace SE2Tentamen
{
    internal class Frisdrank : Drank
    {
        public Frisdrank(decimal prijs, int milliliter, bool warmeDrank, int milligramsuiker)
            : base(prijs, milliliter, warmeDrank)
        {
            this.Milligramsuiker = milligramsuiker;
        }

        public int Milligramsuiker { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} mg suiker", base.ToString(), this.Milligramsuiker);
        }
    }
}