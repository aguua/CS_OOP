/*Twoja firma opracowuje program dla banku. Twoim zadaniem jest stworzenie i przetestowanie klasy Konto. 
Klasa Konto posiada nastêpuj¹ce pola:
	Wlasciciel – typu Osoba (Imie i Nazwisko)
	saldo – typu decimal
	pin – typu int
Pola saldo i pin powinny byæ zainicjalizowane wartoœci¹ zero. 
Pole pin mo¿na zmieniæ tylko podaj¹c obecn¹ wartoœæ pola. 
Wyp³atê z konta (zmniejszenie wartoœci pola saldo) mo¿na uzyskaæ tylko po podaniu prawid³owego PIN-u. 
Na koncie nie wolno zrobiæ debetu. 
Dodaj metodê, która zwraca informacje o koncie, oczywiœcie pod warunkiem, ¿e zosta³ podany prawid³owy PIN.*/
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