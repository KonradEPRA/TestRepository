// Lab_14_g3.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Student {
private :
    string Name;
public :
    Student(string Name = "") :Name(Name) {};
    Student* next=NULL;
    string GetName() { return Name; }
};

class Group {
public:
    Student* first=NULL;
    void AddStudent(Student* student)
    {
        if (first == NULL)
        {
            first = student;
        }
        else
        {
            Student* _s = first;
            while (_s->next != NULL)
            {
                _s = _s->next;
            }
            _s->next = student;
        }
    };

    void Clear() {
        Student* _s = first;
        first = NULL;
        Student* ptr = NULL;
        while (_s->next != NULL)
        {
            ptr = _s;
            _s = _s->next;
            delete ptr;
        }
    }

    friend ostream& operator<<(ostream& str, Group s) {
        Student* ptr;
        if (s.first != NULL)
        {
            ptr = s.first;
            while (ptr != NULL)
            {
                str << ptr->GetName()<<endl;
                ptr = ptr->next;
            }
        }
        return str;
    }
};
int main()
{
    Group g;
    for (int j = 0; j < 10; j++) 
    {
        for (int i = 0; i < 30000; i++) 
        {
            g.AddStudent(new Student("Adam"));
            g.AddStudent(new Student("Benio"));
            g.AddStudent(new Student("Cypis"));
        }
        g.Clear();
    }
    std::cout << g;
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
