// Lab11.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Predkosc {
protected :
	double Wartosc = 0;
	double Mnoznik = 1;
public :
	Predkosc() {  };
	Predkosc(double val)
	{
		this->Wartosc = val;
	};
	double GetWartosc() {
		return this->Wartosc;
	};
	Predkosc operator+(const Predkosc p1)
	{
		return Predkosc(this->Wartosc + p1.Wartosc);
	};
	friend ostream& operator<<(ostream& ostr, Predkosc);
};

class PredkoscKH:public Predkosc {
public:
	PredkoscKH(double val)
	{
		this->Mnoznik = 3.6;
		this->Wartosc = val / Mnoznik;
	};
	PredkoscKH(Predkosc val)
	{
		this->Mnoznik = 3.6;
		this->Wartosc = val.GetWartosc();
	};
	double GetWartosc() {
		return this->Wartosc * this->Mnoznik;
	}
	friend ostream& operator<<(ostream& ostr, PredkoscKH);
};

class PredkoscW :public Predkosc {
public:
	PredkoscW(double val)
	{
		this->Mnoznik = 1.94;
		this->Wartosc = val / Mnoznik;
	};
	PredkoscW(Predkosc val)
	{
		this->Mnoznik = 1.94;
		this->Wartosc = val.GetWartosc();
	};
	double GetWartosc() {
		return this->Wartosc * this->Mnoznik ;
	}
	friend ostream& operator<<(ostream& ostr, PredkoscW);
};

ostream& operator<<(ostream& ostr, Predkosc p) {
	ostr << "Predkosc to : " << p.GetWartosc() << " m/s"<<endl;
	return ostr;
};

ostream& operator<<(ostream& ostr, PredkoscKH p) {
	ostr << "Predkosc to : " << p.GetWartosc() << " K/H" << endl;
	return ostr;
};
ostream& operator<<(ostream& ostr, PredkoscW p) {
	ostr << "Predkosc to : " << p.GetWartosc() << " wezlow" << endl;
	return ostr;
};

int main()
{
	//PredkoscKH _p1 = 1;
	//PredkoscKH _p2 = 1;
	//PredkoscKH _p3 = _p1 + _p2;

	Predkosc _p = 1;
	PredkoscKH _pk = _p;
	PredkoscW _pw = _p;
	cout << _p << _pk << _pw;
};



// Uruchomienie programu: Ctrl + F5 lub menu Debugowanie > Uruchom bez debugowania
// Debugowanie programu: F5 lub menu Debugowanie > Rozpocznij debugowanie

// Porady dotyczące rozpoczynania pracy:
//   1. Użyj okna Eksploratora rozwiązań, aby dodać pliki i zarządzać nimi
//   2. Użyj okna programu Team Explorer, aby nawiązać połączenie z kontrolą źródła
//   3. Użyj okna Dane wyjściowe, aby sprawdzić dane wyjściowe kompilacji i inne komunikaty
//   4. Użyj okna Lista błędów, aby zobaczyć błędy
//   5. Wybierz pozycję Projekt > Dodaj nowy element, aby utworzyć nowe pliki kodu, lub wybierz pozycję Projekt > Dodaj istniejący element, aby dodać istniejące pliku kodu do projektu
//   6. Aby w przyszłości ponownie otworzyć ten projekt, przejdź do pozycji Plik > Otwórz > Projekt i wybierz plik sln
