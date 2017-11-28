using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_8
{
    class Aplication
    {
        public char button;
        public void ReadButton()
        {
            Console.WriteLine("Kasa Fiskalna \n P - Dodaj Produkt do Koszyka \n K - Skopiuj ostatni produkt \n Z - Pokaz zawartosc koszyka \n S - Suma do zapłaty \n X - Storno \n W - Wydrukuj paragon \n N - Nowy klient \n E - Zakoncz dzialanie");
            button = Console.ReadKey().KeyChar;
        }
        public void action()
        {
        switch(button)
        {
            case 'p':
                    Console.WriteLine("Dodawanie Produktu");
                    Console.Beep(5000, 500);
                    //klient.insert();
                    break;
            case 'k':
                    Console.WriteLine("Dodaj ostatni Produkt");
                    System.Threading.Thread.Sleep(2000);
                    break;
            case 'z':
                    Console.WriteLine("Pokaz Koszyk");
                    System.Threading.Thread.Sleep(2000);
                    break;
            case 's':
                    Console.WriteLine("Suma do Zaplaty");
                    System.Threading.Thread.Sleep(2000);
                    break;
            case 'x':
                    Console.WriteLine("Storno");
                    System.Threading.Thread.Sleep(2000);
                    break;
            case 'w':
                    Console.WriteLine("Wydrukuj Paragon");
                    System.Threading.Thread.Sleep(2000);
                    break;
            case 'n':
                    Console.WriteLine("Nowy Klient");
                    List<item> klient = new List<item>();
                    System.Threading.Thread.Sleep(2000);
                    break;
            case 'e':
                    Console.WriteLine("BEEB BOOP SHUTTING DOWN BEEB BOOP");
                    System.Threading.Thread.Sleep(2000);
                    break;
              
        }
        }
    }
}
