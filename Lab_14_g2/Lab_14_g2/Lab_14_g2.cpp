// Lab_14_g2.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

class Student {
private:
    string Name;
public :
    Student(string s="") :Name(s) {};
    Student* next;
    friend ostream& operator<<(ostream& str, Student s);
};

ostream& operator<<(ostream& str, Student s) {
    str << "Name :" << s.Name << endl;
    return str;
}
class Group {
public:
    Student* first = NULL;
    void AddStudent(Student* s) {
        if (first == NULL)
        {
            first = s;
        }else
        {
            Student* _s = first;
            while (_s->next != NULL)
            {
                _s = _s->next;
            }
            _s->next = s;
        }

    }
    void Clear()
    {
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
    friend ostream& operator<<(ostream& str, Group s);
};
ostream& operator<<(ostream& str, Group s) {
    Student* ptr;
    if (s.first != NULL)
    {
        ptr = s.first;
        while (ptr != NULL)
        {
            str << *ptr;
            ptr = ptr->next;
        }
    }
    return str;
}
int main()
{
    Group g;
    for (int j = 0; j < 10; j++) {
        for (int i = 0; i < 10000; i++)
        {
            g.AddStudent(new Student("Ala"));
            g.AddStudent(new Student("Ola"));
            g.AddStudent(new Student("Ela"));
        }
        g.Clear();
    }
    cout << g << endl;

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
