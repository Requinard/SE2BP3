namespace SE2Tentamen
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public delegate void VoorraadUpdate(object sender, object newItem);

    public class Voorraad
    {
        private readonly List<Beker> bekers;

        private readonly List<Drank> dranks;

        public Voorraad()
        {
            this.Verkoops = new List<Verkoop>();
            this.dranks = new List<Drank>();
            this.bekers = new List<Beker>();
        }

        public List<Beker> Bekers
        {
            get
            {
                return this.bekers;
            }
        }

        public List<Drank> Dranks
        {
            get
            {
                return this.dranks;
            }
        }

        public List<Verkoop> Verkoops { get; set; }

        public event VoorraadUpdate OnVoorraadUpdate;

        /// <summary>
        ///     Voegt een nieuw drankje toe
        /// </summary>
        /// <param name="drank">Toe te voegen drank</param>
        /// <returns>Of de drank is toegevoegd</returns>
        public bool NieuwProduct(Drank drank)
        {
            // Kijken of de drank al bestaat
            foreach (var bestaandeDrank in this.dranks)
            {
                if (bestaandeDrank.Equals(drank))
                {
                    return false;
                }
            }

            //toevoegen aan archieven
            this.dranks.Add(drank);

            // Event afvuren
            if (this.OnVoorraadUpdate != null)
            {
                this.OnVoorraadUpdate(this, drank);
            }

            return true;
        }

        /// <summary>
        ///     Voegt een nieuwe beker toe
        /// </summary>
        /// <param name="beker">toe te voegen beker</param>
        /// <returns>success van de operatie</returns>
        public bool NieuwProduct(Beker beker)
        {
            //Kijken of de beker al bestaat
            foreach (var beker1 in this.bekers)
            {
                if (beker1.Equals(beker))
                {
                    return false;
                }
            }

            //toevoegen aan archieven
            this.bekers.Add(beker);

            //Event afvuren
            if (this.OnVoorraadUpdate != null)
            {
                this.OnVoorraadUpdate(this, beker);
            }

            return true;
        }

        /// <summary>
        ///     geeft een lijst van alle beschikbare producten
        /// </summary>
        /// <returns>Lijst met producten</returns>
        public List<IVoorraad> BeschikbareProducten()
        {
            // Lijst opstellen
            var beschikbaar = new List<IVoorraad>();

            //Door drankjes loopen
            foreach (IVoorraad drank in this.dranks)
            {
                beschikbaar.Add(drank);
            }

            // door bekers loopen
            foreach (IVoorraad beker in this.Bekers)
            {
                beschikbaar.Add(beker);
            }

            return beschikbaar;
        }

        // Haalt alle dranken op die voorraad hebben
        public List<Drank> VoorradigeDranken()
        {
            // LINQ die zoek voor items met bestaande voorraad
            var s = from d in this.dranks where d.Voorraad > 0 select d;

            // Converteer het terug naar lijst en geef dit terug
            return s.ToList();
        }

        /// <summary>
        ///     Vult een product bij
        /// </summary>
        /// <param name="product">Product bij te vullen</param>
        /// <param name="aantal">Hoeveelheid items</param>
        public void VulBij(IVoorraad product, int aantal)
        {
            product.Voorraad += aantal;

            if (this.OnVoorraadUpdate != null)
            {
                this.OnVoorraadUpdate(this, product);
            }
        }

        /// <summary>
        ///     Koopt een drankje
        /// </summary>
        /// <param name="drank">Drank die gekocht wordt</param>
        /// <param name="inworp">Hoeveelheid geld er gegooid word</param>
        /// <returns></returns>
        public bool KoopDrank(Drank drank, decimal inworp)
        {
            // Kijken of er genoeg geld is
            if (drank.Prijs > inworp)
            {
                return false;
            }

            List<Beker> available;
            if (drank.WarmeDrank)
            {
                //Kijken voor bekers
                var s = from beker in this.Bekers
                        where beker.Voorraad > 0
                        where beker.Milliliter >= drank.Milliliter
                        where beker.WarmeDrankMogelijk
                        orderby beker.Milliliter ascending
                        select beker;

                available = s.ToList();
            }
            else
            {
                var s = from beker in this.Bekers
                        where beker.Voorraad > 0
                        where beker.Milliliter >= drank.Milliliter
                        orderby beker.Milliliter ascending
                        select beker;

                available = s.ToList();
            }
            //als de lengte van bekers nul is, zijn er geen bekers over
            if (available.Count == 0)
            {
                throw new OnVoldoendeBekersException();
            }

            // Een beker weg halen bij de eerste beker
            drank.Voorraad -= 1;
            --available.First().Voorraad;

            var verkoop = new Verkoop(DateTime.Now, drank);
            this.Verkoops.Add(verkoop);

            if (this.OnVoorraadUpdate != null)
            {
                this.OnVoorraadUpdate(this, null);
            }
            return true;
        }

        /// <summary>
        ///     Exporteer alle verkopen naar een bestand
        /// </summary>
        /// <param name="bestandsnaam"></param>
        public void ExporteerLog(string bestandsnaam)
        {
            // Open writer en doe aan append
            using (var stream = new StreamWriter(bestandsnaam))
            {
                // Loop door verkoop
                foreach (var verkoop in this.Verkoops)
                {
                    //Format text
                    var text = string.Format("{0} - {1}", verkoop.Tijdstip, verkoop.GekochteDrank.Naam);

                    // Write the line
                    stream.WriteLine(text);
                }
            }
        }
    }

    public class OnVoldoendeBekersException : Exception
    {
    }
}