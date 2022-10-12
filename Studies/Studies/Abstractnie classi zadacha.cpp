#include<iostream>
#include<math.h>
using namespace std;


class Abstrakt {
public:
	virtual void Show() = 0;
};


class Lineup :public Abstrakt {
public:
	int a = 0;
	int b = 0;
	Lineup():Lineup{0,0}{}
	Lineup(int ap, int bp) {
		a = ap;
		b = bp;
	}
	virtual void Show() {
		cout << "Znachenie dannogo uravneniya ravnyaetsya " << (b / a) << endl;
		
	}
};


class Kvadrat :public Abstrakt {
public:
	int a = 0;
	int b = 0;
	int c = 0;
	Kvadrat():Kvadrat{0,0,0}{}
	Kvadrat(int ap, int bp, int cp) {
		a = ap;
		b = bp;
		c = cp;
	}
	virtual void Show() {
		int x = 0;
		int D = 0;
		D = (b * b) - 4*a*c;
		if (D < 0) {
			cout << "Net korney " << endl;
		}
		else if (D == 0) {
			cout << "x = " << (-b / 2 * a) << endl;
		}
		else {
			cout << "x1 ravnyaetsa " << (-b + sqrt(D)) / (2 * a) << endl;
			cout << "x2 ravnyaetsa " << (-b - sqrt(D)) / (2 * a) << endl;
		}
	}
};


int main() {
	Abstrakt* shlak[2]{new Lineup(3,9), new Kvadrat(3,-7,2)};

	for (int i = 0; i < 2; i++) {
		shlak[i]->Show();
	}


	return 0;
}