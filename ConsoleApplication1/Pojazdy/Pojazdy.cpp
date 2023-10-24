// Pojazdy.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//
using namespace std;
#include <iostream>
class pojazd {
public :
    string Marka;
    string Typ;
    double wysokosc;
    double szerokosc;
    double dlugosc;
    void Uruchom()
    {
        cout << "Uruchamiam silnik" << endl;
    }
    void Zatrzymaj(){
        cout << "Zatrzymuje silnik" << endl;
    }
    void Poruszajsie() {
        cout << "Poruszam sie" << endl;
    }
};

class samochod :public pojazd
{
public:
    void Jedz() {
        cout << "Jade" << endl;
    };
    void Poruszajsie()
    {
        Jedz();
    }
};
class samolot :public pojazd
{
public :
    void Lec() { cout << "Lece" << endl; };
    void Poruszajsie()
    {
        Lec();
    }
};

class statek :public pojazd
{
public:
    void Plyn() { cout << "Plyne" << endl; };
};

class AAA :public samochod, public samolot
{

};

int main()
{
    AAA _s;
    //_s.Poruszajsie();
    std::cout << "Hello World!\n";
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
