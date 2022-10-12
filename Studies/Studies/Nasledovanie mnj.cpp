#include<iostream>
using namespace std;



class Kolesa  {
public:
	int diametr = 0;
	string firma="Null";
	Kolesa():Kolesa{0, "Null"} {}
	Kolesa(int diametrp, string firmap) {
		diametr = diametrp;
		firma = firmap;
	}
};

class Dvijka {
public:
	int volume = 0;
	int pony = 0;
	Dvijka():Dvijka{0,0}{}
	Dvijka(int volumep, int ponyp) {
		volume = volumep;
		pony = ponyp;
	}
	
};

class Doors {
public:
	int dveri = 0;
	Doors():Doors{0}{}
	Doors(int dverip) {
		dveri = dverip;
	}
};

class Kuzov {
public:
	string kuzov ;
	Kuzov():Kuzov{"sedan"}{}
	Kuzov(string kuzovp) {
		kuzov = kuzovp;
	}
};

class Auto:public Dvijka,public Kolesa,public Kuzov,public Doors {
public:
	string name="Tachka";
	//Auto():Auto{"Tachka"}{}
	Auto(string namep,int volumep,int ponyp,int diametrp,string firmap,int dverip,string kuzovp) {
		name = namep;
		volume = volumep;
		pony = ponyp;
		diametr = diametrp;
		firma = firmap;
		dveri= dverip ;
		kuzov = kuzovp;
	}
	void Show() {
		cout << "Nazvanie avto " << name <<" -  Dvigatel ob'emom "<<volume<<" litra moshnost'yu "<<pony<<" loshadok, kolesami - diametrom "<<diametr<<" firmy "<<firma<<" kuzovom "<<kuzov<<" s"<<dveri<< "dveryami" << endl;
	}
};


int main() {

	Auto Tachka("Lastochka", 2, 135, 17, "Pirelli", 4, "Universal");
	Tachka.Show();

	return 0;
}