// Lab10.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Zespolona
{
public:
//private:
    int re =0;
    int im =0;
//public:
    Zespolona() {}
    Zespolona(int r, int i) { this->re = r; this->im = i; }
    //Zespolona operator+(Zespolona z)
    //{
    //    return Zespolona(this->re + z.re, this->im + z.im);
    //}
    Zespolona operator-(Zespolona z)
    {
        return Zespolona(this->re - z.re, this->im - z.im);
    }
    Zespolona operator*(Zespolona z)
    {
        int re = this->re * z.re - this->im * z.im;
        int im = this->im * z.re + this->re * z.im;

        return Zespolona(re,im);
    }
    friend ostream& operator<<(ostream&, Zespolona);
    friend bool operator ==(Zespolona, Zespolona);
};


Zespolona operator+(Zespolona z1, Zespolona z2 )
{
    return Zespolona(z1.re+z2.re , z1.im + z2.im);
}


bool operator == (Zespolona z1, Zespolona z2)
{
    if (z1.re == z2.re && z1.im == z2.im)
        return true;
    return false;
};

class Student {
public :
    int nrIndexu = 0;
    string Imie;
    string Nazwisko;
    int semestr = 1;
    Student(int nr, string im, string naz) {
        nrIndexu = nr; Imie = im; Nazwisko = Nazwisko;
    }
    Student& operator++() { semestr++;  return *this; }

    Student& operator--() { semestr--;  return *this; }

    bool operator==(Student s) {
         return nrIndexu == s.nrIndexu ? true : false;
    }
    friend ostream& operator<< (ostream&, Student);
    friend istream& operator>> (istream&, Student&);
};
ostream& operator << (ostream& str, Student s)
{
    return str << "Student nr indexu : "<<s.nrIndexu<<" semestr : "
        <<s.semestr<<" Imie: "<<s.Imie;
}
istream& operator >> (istream& str, Student& s)
{
    cout << "Student nr indexu : ";
    str >> s.nrIndexu;
    cout << "Imie : ";
    str >> s.Imie;

    return str;
}



ostream& operator <<(ostream& str, Zespolona z) {
    str << "Rzeczywista :"<<z.re << " Urojona"<<z.im;
    return str;
}



int main()
{
    //Student s1(1, "Jan", "Kowalski");
    //Student s2(1, "Jan", "Kowalski");

    //bool czyTenSam = s1 == s2;
    //cin >> s1;
    //cout << s1;

    Zespolona z1(1,2);
    Zespolona z2(3,4);

    Zespolona  z3 = z1 + z2;

    cout << z3;

    //cout << z1;
    //cout << z2;
    //PoleUprawne pole1 (10, 10);
    //PoleUprawne pole2 (20, 10);


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
