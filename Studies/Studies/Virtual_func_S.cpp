#include<iostream>
using namespace std;


class Figura {
public:
	virtual int Square() = 0;

};


class Rectangle :public Figura {
public:
	int a = 0;
	int b = 0;
	Rectangle():Rectangle{ 0,0 }{}
	Rectangle(int ap, int bp):Figura() {
		a = ap;
		b = bp;
	}

	virtual int Square() {
		int S = 0;
		S = a * b;
		cout << "Ploshad' pryamougol'nika ravna " << S << endl;
		return S;
	}

};

class Triangle :public Figura {
public:
	int a = 0;
	int b = 0;
	Triangle() :Triangle{ 0,0 } {}
	Triangle(int ap, int bp) {
		a = ap;
		b = bp;
	}

	virtual int Square() {
		int S = 0;
		S = (a * b)/2;
		cout << "Ploshad' pryamougol'nogo treugol'nika ravna " << S << endl;
		return S;
	}

};

class Circle :public Figura {
public:
	int a = 0;
	
	Circle() :Circle{ 0 } {}
	Circle(int ap) {
		a = ap;
		
	}

	virtual int Square() {
		int S = 0;
		int P = 3;
		S = (a * P)*(a*P);
		cout << "Ploshad' kruga ravna " << S << endl;
		return S;
	}

};



int main() {
	Figura* Pl[3]{ new Rectangle(3, 5), new Triangle(8, 5), new Circle(5) };

	for (int i = 0; i < 3; i++) {
		Pl[i]->Square();
	}

	return 0;
}