// Lab9_g3.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Car {
private :
	int IloscKolorow =0;
public:
	string Marka;
	string Model;
	string* Wersja = nullptr;
	string* Kolor = nullptr;

	Car() {	Wersja = new string;};
	//~Car() { delete[] Kolor; delete Wersja; };
	Car(const Car& car) {
		this->Marka = car.Marka;
		this->Model = car.Model;
		Wersja = new string;
		*Wersja = *car.Wersja;
		IloscKolorow = car.IloscKolorow;

		Kolor = new string[IloscKolorow];
		for (int i = 0; i < IloscKolorow; i++)
			Kolor[i] = car.Kolor[i];
	};

	void setWersja(string wersja)
	{
		*Wersja = wersja;
	}
	void DodajKolor(string NowyKolor)
	{
		string* result = new string[++IloscKolorow];
		for (int i = 0; i < IloscKolorow - 1; i++)
			result[i] = Kolor[i];
		//if (Kolor != nullptr)
		//	delete[] Kolor;
		result[IloscKolorow - 1] = NowyKolor;
		Kolor = result;
	}
	void WypiszKolory()
	{
		if (Kolor == nullptr) return;
		for (int i = 0; i < IloscKolorow; i++)
			cout << " " << Kolor[i];
		cout << endl;
	}
};

int main()
{
	Car auto1;
	auto1.Marka = "Fiat";
	auto1.Model = "Uno  ";
	auto1.setWersja("Standard");
	auto1.DodajKolor("Czerwony");
	auto1.DodajKolor("Niebieski");

	Car auto2 = auto1;
	auto2.Model = "Punto";
	auto2.setWersja("Sport");
	auto2.Kolor[0] = "Czarny";

	for (int i = 0; i < 10000; i++)
		auto2.DodajKolor("Jakiś" );


	cout << auto1.Marka << " " << auto1.Model << " " << *auto1.Wersja<<" "<< endl;
	auto1.WypiszKolory();
	cout << auto2.Marka << " " << auto2.Model << " " << *auto2.Wersja << " " << endl;
	auto2.WypiszKolory();
	int i;
	cin >> i;
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
