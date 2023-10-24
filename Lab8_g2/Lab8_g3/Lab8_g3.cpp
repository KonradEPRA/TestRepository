// Lab8_g3.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class vector {
public :
    int X1;
    int Y1;
    int X2;
    int Y2;
    vector() {};
    vector(int X1, int Y1, int X2, int Y2) {
        this->X1 = X1;
        this->Y1 = Y1;
        this->X2 = X2;
        this->Y2 = Y2;
    }
    static  vector * Add(vector& a, vector& b);
};

vector* vector::Add(vector& a, vector& b) {
    return new vector(a.X1 + b.X1, a.Y1 + b.Y1, a.X2 + b.X2, a.Y2 + b.Y2);
}


class Singleton {
private :
    static Singleton*  Instance;
    Singleton() {};
public :
    static Singleton * GetInstance()
    {
        if (Instance == nullptr) Instance = new Singleton();
        return Instance;
    }
};

Singleton * Singleton::Instance;

int main()
{
    vector _a;
    vector _b;

    vector::Add(_a, _b);

    //Singleton* _s1 = Singleton::GetInstance();
    //Singleton* _s2 = _s1->GetInstance();
    //Singleton* _s3 = Singleton::GetInstance();
    //cout << _s1 << endl;
    //cout << _s2 << endl;
    //cout << _s3 << endl;
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
