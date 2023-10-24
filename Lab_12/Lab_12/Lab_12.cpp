// Lab_12.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//
#include <iostream>
using namespace std;

class animal {
public:
    void virtual  move() = 0;
};
class bird :public animal {
public :
    void move() {
        std::cout << "fly" << endl;
    };
};
class fish :public animal {
public:
    void move() {
        std::cout << "swim" << endl;
    };
};
class lion :public animal {
public:
    void move() {
        std::cout << "walk" << endl;
    };
};
#include <iostream>

int main()
{
    //animal a1;
    //a1.move();
    animal* Animals[3];
    Animals[0] = new bird();
    Animals[1] = new lion();
    Animals[2] = new fish();

    for (size_t i = 0; i < 3; i++)
    {
        Animals[i]->move();
    }
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
