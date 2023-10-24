// Kolokwium_1.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>

class Zespolona {
private:
    double re;
    double im;
public:
    Zespolona(double re, double im) {
        this->re = re;
        this->im = im;
    };
    Zespolona operator+ (Zespolona zesp) {
        return Zespolona(this->re+ zesp.re,this->im+ zesp.im);
    };
    double getRe() { return this->re; };
    double getMi() { return this->im; };
};
class Zespolona_V2 : public Zespolona {
public:
    double getModul() {
        return this->getRe();
    };
};

int main()
{
    Zespolona z1 (2, 3);
    Zespolona z2 (3, 4);
    Zespolona z3 = z1 + z2;

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
