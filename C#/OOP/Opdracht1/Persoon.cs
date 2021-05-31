using System;

namespace Personen
{
    public class Persoon
    {
        /*
        public Persoon(string vNaam, string aNaam, string gSlacht, double lEngte, double gEwicht, DateTime gDate)
        {
            Voornaam = vNaam;
            Achternaam = aNaam;
            Geslacht = gSlacht;
            Lengte = lEngte;
            Geboortedatum = gDate;
            Gewicht = gEwicht;
        }
        */
        public string Voornaam { set; get; }
        public string Achternaam { set; get; }
        public DateTime Geboortedatum { set; get; }
        public string Geslacht { set; get; }

        public double Gewicht { 
            get 
            {
                return gewicht; 
            } 
            set
            {
                if(value < 1.5)
                {
                    gewicht = 1.5;
                } 
                else if(value > 321.6)
                {
                    gewicht = 321.6;
                }
                else
                {
                    gewicht = value;
                }
            }
        }
        private double gewicht;

        public double Lengte {
            get { return Plengte; } 
            set
            {
                if(value < 0.30)
                {
                    Plengte = 0.30;
                }
                else
                {
                    Plengte = value;
                }
            } 
        }
        private double Plengte;

        public virtual string WieBenIk()
        {
            return $"{Voornaam} {Achternaam} {Lengte}";
        }

    }

}
