#include<iostream>
#include <time.h>

using namespace std;


//���������, �������������� ������� ������
typedef struct tree_element {
	int value;
	struct tree_element* left;
	struct tree_element* right;
}tree_element;

//�������� ������ �������� ������ � �������� ���������
tree_element* create_tree_element(int i) {
	tree_element* elem = new tree_element;
	elem->value = i;
	elem->left = NULL;
	elem->right = NULL;
	return elem;
}

//��������� ����� ������� elem � ������ � ������ root
void insert_into_tree(tree_element* root, tree_element* elem) {
	if (elem->value < root->value) {
		//���� � ����� ���������
		if (root->left == 0) {
			//����� ���������-������. ���� � ��������� ����� �������
			root->left = elem;
		}
		else {
			//����� ���-�� ���� . ���������� ���������� � ����� ���������
			insert_into_tree(root->left, elem);
		}
	}
	else {
		//���� � ������ ���������
		if (root->right == NULL) {
			root->right = elem;
		}
		else {
			insert_into_tree(root->right, elem);
		}
	}
}

void find_into_tree(tree_element* root, int x) {
	if (x < root->value) {
		//���� � ����� ���������
		if (root->value==x) {
			//����� ���������-������. ���� � ��������� ����� �������
			cout << "Element naiden v levom poddereve " << x << endl;
		}
		else {
			//����� ���-�� ���� . ���������� ���������� � ����� ���������
			find_into_tree(root->left, x);
		}
	}
	else {
		//���� � ������ ���������
		if (root->value == x) {
			cout << "Element naiden v pravom poddereve " << x << endl;
		}
		else {
			find_into_tree(root->right,x);
		}
	}
}


void print_tree(tree_element* cur_elem) {
	if (cur_elem->left != NULL) {
		print_tree(cur_elem->left);
	}
	cout << "Value = " << cur_elem->value << endl;
	if (cur_elem->right != NULL) {
		print_tree(cur_elem->right);
	}
}


int main() {
	srand(time(NULL));	
	int a[5];
	tree_element* root = create_tree_element(8);
	for (int i = 0; i < 5; i++) {
		a[i] =-10+ rand() % 20;
		tree_element* el = create_tree_element(a[i]);
		insert_into_tree(root, el);
	}
	cout << "My tree: " << endl;
	print_tree(root);
	find_into_tree(root, 2);
	return 0;
}