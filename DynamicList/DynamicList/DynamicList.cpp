// DynamicList.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Car {
private:
    int IloscKolorow=0;
public :
    string Marka;
    string Model;
    string* Wersja = nullptr;
    string* Kolory = nullptr;

    Car() {
        Wersja = new string();
    };

    //Car(const Car& c) {
    //    Marka = c.Marka;
    //    Model = c.Model;
    //    this->IloscKolorow = c.IloscKolorow;
    //    this->Kolory = new string[IloscKolorow];
    //    for (int i = 0; i < IloscKolorow; i++)
    //        Kolory[i] = c.Kolory[i];
    //};
    void WypiszKolory()
    {
        if (Kolory == nullptr)
            return;
        for (int i = 0; i < IloscKolorow; i++)
            cout << this->Kolory[i] << " ";
        cout << endl;
    };
    void DodajKolor(string NowyKolor)
    {
        string * result = new string[++IloscKolorow];
        for (int i = 0; i < IloscKolorow - 1; i++)
            result[i] = Kolory[i];
        if (Kolory != nullptr)
            delete [] Kolory;
        result[IloscKolorow - 1] = NowyKolor;
        Kolory = result;
    }
    void setWersja(string wer) { *Wersja = wer; };
};

int main()
{
    Car auto1;
    auto1.Marka = "Fiat";
    auto1.Model = "126";
    //auto1.setWersja("DDDDD");
    auto1.DodajKolor("Czerwony");
    auto1.DodajKolor("Niebieski");
    Car auto2 = auto1;
    auto2.Model = "125";
    auto2.Kolory[0] = "Czarny";
    auto2.DodajKolor("Czerwony");
    //auto2.setWersja("aaaaa");
    cout << auto1.Marka << " " << auto1.Model <<" "<< auto1.Kolory<<" "<<*auto1.Wersja<<endl;
    auto1.WypiszKolory();
    cout << auto2.Marka << " " << auto2.Model << " " << auto2.Kolory<<endl;
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


