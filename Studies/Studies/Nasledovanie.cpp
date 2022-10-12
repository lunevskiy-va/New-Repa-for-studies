#include<iostream>
using namespace std;

class Student {
public:
	string name;
	int group;
	int age;
	Student():Student{"Vitaly",1,18}{}
	Student(string namep, int groupp, int agep) {
		name = namep;
		group = groupp;
		age = agep;
	}
	int SetAge(int agep) {
		age = agep;
		return age;
	}
	int SetGroup(int groupp) {
		group = groupp;
		return group;
	}
	
};

class Aspirant :public Student {
public:
	int day_of_ex;
	int grade;
	Aspirant(int day_of_exp, int gradep) {
		day_of_ex = day_of_exp;
		grade = gradep;
	}

	void Show() {
		cout << "Student is gropy " << group << " vozrastom " << age <<" let po imeni " << name << " dney do examena " << day_of_ex << " predvaritelnaya ocenka " << grade << endl;
	}
};

int main101() {
	Aspirant Vitaly(15, 4);
	Vitaly.Show();
	Vitaly.SetAge(31);
	Vitaly.SetGroup(3);
	Vitaly.Show();
	return 0;
}