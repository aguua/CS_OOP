/*Twoja firma opracowuje program dla banku. Twoim zadaniem jest stworzenie i przetestowanie klasy Konto. 
Klasa Konto posiada nast�puj�ce pola:
	Wlasciciel � typu Osoba (Imie i Nazwisko)
	saldo � typu decimal
	pin � typu int
Pola saldo i pin powinny by� zainicjalizowane warto�ci� zero. 
Pole pin mo�na zmieni� tylko podaj�c obecn� warto�� pola. 
Wyp�at� z konta (zmniejszenie warto�ci pola saldo) mo�na uzyska� tylko po podaniu prawid�owego PIN-u. 
Na koncie nie wolno zrobi� debetu. 
Dodaj metod�, kt�ra zwraca informacje o koncie, oczywi�cie pod warunkiem, �e zosta� podany prawid�owy PIN.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
	class Osoba{
		public string Imie;
		public string Nazwisko;
	}

	class Konto{
		public Osoba Wlasciciel = new Osoba();
		private decimal saldo = 0;
		private int pin = 0;

		private bool SprawdzPin(int pin){
			if(this.pin == pin)
				return true;
			return false;
		}

		public bool ZmienPin(int stary, int nowy){
			if (SprawdzPin(stary)){
				this.pin = nowy;
				return true;
				}
			return false;
		}

	}
}