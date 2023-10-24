// Kolokwium_2.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
class Napoj {
private:
    double ilosc;  // Ilość napoju w Litrach
    double cukier; // Ilość cukru w napoju w Litrach
public :
    Napoj(double ilosc, double cukier) {
        this->ilosc = ilosc; this->cukier = cukier;
    };
    Napoj operator+(Napoj nap) {
        return Napoj(this->ilosc + nap.ilosc, this->cukier + nap.cukier);
    };
    Napoj operator*(double mnoznik){
        return Napoj(this->ilosc * mnoznik, this->cukier * mnoznik);
    }
    friend Napoj operator *(double, Napoj);
};

Napoj operator*(double mnożnik, Napoj nap) {
    return nap * mnożnik;
};

int main()
{
    Napoj n1(1, 1);
    Napoj n2 = 2 * n1;
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
