﻿// PolaStatyczne.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//
using namespace std;

#include <iostream>

class Pojazd
{
public :
	static int IlocsPojazdow;
	Pojazd(){
		cout << "konstruktor" << endl;
		IlocsPojazdow++;
	}
	~Pojazd() {
		cout << "destruktor" << endl;
		IlocsPojazdow--;
	}
	static void Pomaluj(Pojazd& _pojazd)
	{

	}
};

int Pojazd::IlocsPojazdow = 0;

class samochod :public Pojazd {};
class samolot :public Pojazd {};
class statek :public Pojazd {};


int main() {

	samochod sam;

	Pojazd::Pomaluj(sam);


	cout << "Ile chcesz pojazdow" << endl;
	int ilepojazdow;
	cin >> ilepojazdow;

	Pojazd* tab = new Pojazd[ilepojazdow]();

	cout << "Ile chcesz samochodow" << endl;
	ilepojazdow;
	cin >> ilepojazdow;

	samochod* tab1 = new samochod[ilepojazdow]();

	cout << "Ile chcesz statkow" << endl;
	ilepojazdow;
	cin >> ilepojazdow;

	statek* tab2 = new statek[ilepojazdow]();


	cout << Pojazd::IlocsPojazdow<<endl;
}

// Uruchomienie programu: Ctrl + F5 lub menu Debugowanie > Uruchom bez debugowania
// Debugowanie programu: F5 lub menu Debugowanie > Rozpocznij debugowanie

// Porady dotyczące rozpoczynania pracy:
//   1. Użyj okna Eksploratora rozwiązań, aby dodać pliki i zarządzać nimi
//   2. Użyj okna programu Team Explorer, aby nawiązać połączenie z kontrolą źródła
//   3. Użyj okna Dane wyjściowe, aby sprawdzić dane wyjściowe kompilacji i inne komunikaty
//   4. Użyj okna Lista błędów, aby zobaczyć błędy
//   5. Wybierz pozycję Projekt > Dodaj nowy element, aby utworzyć nowe pliki kodu, lub wybierz pozycję Projekt > Dodaj istniejący element, aby dodać istniejące pliku kodu do projektu
//   6. Aby w przyszłości ponownie otworzyć ten projekt, przejdź do pozycji Plik > Otwórz > Projekt i wybierz plik sln
