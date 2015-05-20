namespace SE2Tentamen
{
    using System;

    public class Verkoop
    {
        public Verkoop(DateTime tijdstip, Drank gekochteDrank)
        {
            this.Tijdstip = tijdstip;
            this.GekochteDrank = gekochteDrank;
        }

        public Drank GekochteDrank { get; set; }

        public DateTime Tijdstip { get; set; }

        public override string ToString()
        {
            return string.Format("{0} op {1}", this.GekochteDrank.Naam, this.Tijdstip);
        }
    }
}