// Singleton.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Global {
public :
    static string Login;
    static string PathToDir;
};

string Global::Login = "";
string Global::PathToDir = "";

class singleton {
private :
    static singleton* instance;
    singleton() {
        cout << "KOnstruktor ";
    };

public:
    static singleton *  getInstance()
    {
        if (instance == nullptr)
            instance = new singleton();
        return instance;

    }
};
singleton * singleton::instance = nullptr;
int main()


{

    singleton * _s = singleton::getInstance();
    singleton* _a = singleton::getInstance();

    cout << _s;
    cout << _a;


    Global::Login = "Konrad";
    Global A;
    Global B;

    std::cout << A.Login << "\n";
    
    std::cout <<B.Login<< "\n";
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
