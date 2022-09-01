#include<iostream>
using namespace std;

class Employer {
public:
	string Name;
	Employer(string namep) {
		Name = namep;
	}
	virtual void Print() = 0;
};

class Manager : public Employer {
public:
	int money = 0;
	Manager(string Name, int moneyp) :Employer(Name) {
		money = moneyp;
	}
	virtual void Print() {
		cout << "Zarobotnaya plata u MAnagera " << Name << " " << money << endl;
	}
};

class Lawyer : public Employer {
public:
	int money = 0;
	Lawyer(string Name, int moneyp) :Employer(Name) {
		money = moneyp;
	}
	virtual void Print() {
		cout << "Zarobotnaya plata u LAwyera " << Name << " " << money << endl;
	}
};

class Economist : public Employer {
public:
	int money = 0;
	Economist(string Name, int moneyp) :Employer(Name) {
		money = moneyp;
	}
	virtual void Print() {
		cout << "Zarobotnaya plata u Economista " << Name << " " << money << endl;
	}
};


int main() {
	Employer* Company[4]{ new Manager("Sergey", 1500),new Lawyer("Danil", 2600),new Economist("Denis", 3200),new Manager("Kirill",5000) };
	for (int i = 0; i < 4; i++) {
		Company[i]->Print();
	}

	return 0;
}