namespace Katalog
{
    class Produkt
    {
        private string _nazwa;
        public string Nazwa
        {
            get { return _nazwa; }
            set
            {
                if(value == String.Empty)
                {
                    _nazwa = "Brak nazwy";
                    throw new ArgumentException("Nazwa nie może być pusta.");
                }
                else
                {
                    _nazwa = value;
                }
            }
        }
        private double _cena;
        public double Cena
        {
            get { return _cena; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cena nie może być ujemna.");
                }
                else
                {
                    _cena = value;
                }
                
            }
        }

        public int MinimalnyStan { get; set; }

        public string Kategoria;
        public int Ilosc;

        public double WartoscMagazynu
        {
            get { return Cena * Ilosc; }
        }
   
        public Produkt(string nazwa, double cena, string kategoria, int ilosc)
        {
            Nazwa = nazwa;
            Cena = cena;
            Kategoria = kategoria;
            Ilosc = ilosc;
            MinimalnyStan = 1;
        }

        public void PokazProdukt()
        {
            Console.WriteLine($"Nazwa: {Nazwa,-25} | Cena: {Cena,10} |" +
                $"Kategoria: {Kategoria} | Ilość: {Ilosc,5} | Wartość: {WartoscMagazynu,10:F2}");
        }

        public string ZwracaProdukt()
        {
            return $"Nazwa: {Nazwa,-25} | Cena: {Cena,10} |" +
                $"Kategoria: {Kategoria} | Ilość: {Ilosc,5} | Wartość: {WartoscMagazynu,10:F2}";
        }

        public static double ObliczWartoszMagazynu(Produkt[] produkty)
        {
            double suma = 0;
            foreach(Produkt produkt in produkty)
            {
                suma += produkt.WartoscMagazynu;
            }
            return suma;
        }

        public bool CzyMoznaZamuwic()
        {
            return Ilosc > MinimalnyStan;
        }
    }
}