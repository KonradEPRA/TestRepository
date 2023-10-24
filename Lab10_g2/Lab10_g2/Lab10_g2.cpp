// Lab10_g2.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Student
{
public:
    int nrIndexu = 0;
    string Imie;
    string Nazwisko;
    int Semestr=1;
    Student(int nrIndexu, string imie, string Nazwisko) {
        this->nrIndexu = nrIndexu;
        this->Imie = imie; 
        this->Nazwisko = Nazwisko;
    }
    Student& operator ++() {
        this->Semestr++;
        return *this;
    }



};

ostream& operator <<(ostream& str, Student s) {
    str << "Index :" << s.nrIndexu << " Imie :" 
        << s.Imie<<" Nazwisko :"
        <<s.Nazwisko<<" Semestr: "<<s.Semestr;
    return str;
};

istream& operator >>(istream& str, Student &s) {
    cout << "Index ";
    str >> s.nrIndexu;
    cout << "Imie ";
    str >> s.Imie;
    cout << "Nazwisko";
    str >> s.Nazwisko;
    return str;
};

bool operator==(Student s1,Student s2) {
    if (s1.nrIndexu == s2.nrIndexu)
        return true;
    return false;
}

bool operator!=(Student s1, Student s2) {
    if (s1.nrIndexu != s2.nrIndexu)
        return true;
    return false;
}


int main()
{
    Student s1(1, "Jan", "Kowalski");
    Student s2(2, "Jan", "Kowalski");
    ++s2;
    ++s2;
    ++s2;
    cin >> s2;
    cout << " "<<s2;
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
