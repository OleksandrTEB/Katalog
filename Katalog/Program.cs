using Katalog;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Produkt procesor = new Produkt("Procesor", 899.00, "Electronic", 1);

Produkt ram = new Produkt("Pamięć RAM", 565.05, "Electronic", 1);

Produkt ssd = new Produkt("Dysk SSD", 44.99, "Electronic", 1);

Produkt zasilacz = new Produkt("Zasilacz", 189.99, "Electronic", 5);

Produkt[] produkty = [procesor, ram, ssd, zasilacz];

double minimalnaCena = produkty[0].Cena;
double maksymalnaCena = produkty[0].Cena;

double suma = 0;

foreach (Produkt produkt in produkty)
{
    Console.WriteLine($"Nazwa: {produkt.Nazwa,-25} | Cena: {produkt.Cena,10} | Kategoria: {produkt.Kategoria} | Ilość: {produkt.Ilosc,5} | Wartość: {produkt.WartoscMagazynu,10:F2}");
    if(minimalnaCena > produkt.Cena)
        minimalnaCena = produkt.Cena;

    if (maksymalnaCena < produkt.Cena)
        maksymalnaCena = produkt.Cena;

    suma += produkt.Cena;
}

double sredniaCena = suma / produkty.Length;

Console.WriteLine($"Minimalna cena: {minimalnaCena:F2} zł");
Console.WriteLine($"Średnia cena: {sredniaCena:F2} zł");
Console.WriteLine($"Maksymalna cena: {maksymalnaCena:F2} zł");



//string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz", "Laptop" };
//double[] ceny = { 899.00, 249.50, 379.00, 189.99, 700.99 };


//double suma = 0;
//int licznik = 0;

////Zatrzymiuje 1 raz ostatni element jest więkrzy niż 500 zł
//for (int i = 0; i < nazwy.Length; i++)
//{
//    // Do sumy trafiają tylko produkty droższe niż 200 zł
//    if (ceny[i] > 400)
//    {
//        // Suma po 2 iteracji 1148.5
//        suma = suma + ceny[i];
//        licznik++;
//    }
//}

//// Uwaga: przy pustym liczniku byłoby dzielenie przez zero
//double srednia = suma / licznik;
//Console.WriteLine($"Średnia cena: {srednia:F0} zł z {licznik} produktów");
//Console.WriteLine($"Średnia cena: {srednia:F2} zł z {licznik} produktów");
//Console.WriteLine($"Średnia cena: {srednia:N2} zł z {licznik} produktów");

//Console.WriteLine($"{000.5:F2}");