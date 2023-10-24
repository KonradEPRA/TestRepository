// Lab9_g2.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Car {
public:
    string Marka;
    string Model;
    string* Wersja;
    string* Kolory = nullptr;

    int IleKolorow = 0;

    void setWersja(string wer)
    {
        *Wersja = wer;
    };

    void DodajKolor(string nowyKolor)
    {
        string* result = new string[++IleKolorow];
        if (Kolory != nullptr)
        {
            for (int i = 0; i < IleKolorow - 1; i++)
                result[i] = Kolory[i];
        }
        result[IleKolorow - 1] = nowyKolor;
        delete[] Kolory;
        Kolory = result;
    }

    void OdejmijKolor(string nowyKolor)
    {
        if (Kolory = nullptr) return;
        bool czy_istnieje_kolor = false;

        for (int i = 0; i < IleKolorow - 1; i++)
            if (Kolory[i] == nowyKolor)
                czy_istnieje_kolor = true;
        if (!czy_istnieje_kolor) return;

        string* result = new string[--IleKolorow];
        if (Kolory != nullptr)
        {
            for (int i = 0; i < IleKolorow - 1; i++)
                result[i] = Kolory[i];
        }
        result[IleKolorow - 1] = nowyKolor;
        delete[] Kolory;
        Kolory = result;
    }
    void WypiszKolory()
    {
        if (Kolory == nullptr)
            return;
        for (int i = 0; i < IleKolorow; i++)
            cout << this->Kolory[i] << " ";
        cout << endl;
    };
    Car() {
        Wersja = new string();
        IleKolorow = 0;
    };

    Car(const Car & car)
    {
        Marka = car.Marka;
        Model = car.Model;
        Wersja = new string();
        *Wersja = *car.Wersja;
        IleKolorow = car.IleKolorow;
        this->Kolory = new string[IleKolorow];
        for (int i = 0; i < IleKolorow; i++)
            Kolory[i] = car.Kolory[i];
    }
};

int main()
{
    Car auto1;
    auto1.Marka = "Audi";
    auto1.Model = "A3";
    auto1.setWersja("Standard");
    auto1.DodajKolor("Czerwony");
    auto1.DodajKolor("Niebieski");
    auto1.DodajKolor("Zielony");

    Car auto2 = auto1;
    auto2.Marka = "Volwo";
    auto2.Model = "V50";
    auto2.setWersja("Sport");
    auto2.Kolory[0] = "Biały";

    cout << auto1.Marka << " " << auto1.Model << " " << *auto1.Wersja << endl;
    auto1.WypiszKolory();
    cout << auto2.Marka << " " << auto2.Model << " " << *auto2.Wersja << endl;
    auto2.WypiszKolory();
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
