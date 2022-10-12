#include <iostream>
#include <string.h>
#include <stdlib.h>
#include <time.h>
#include <stdio.h>
using namespace std;
// структура представл€юща€ элемент дерева
typedef struct tree_element {
	int valve; // корень
	struct tree_element* left; // лева€ ветка
	struct tree_element* right;// права€ ветка
} tree_element;

//создание элемента с заданным значением
tree_element* create_tree_element(int i);

// функци€ поиска элемента в дереве
void seach_into_tree(tree_element* root, int elem);

//вставл€ем элемент elem в дерево с корнем root
void insert_into_tree(tree_element* root, tree_element* elem);

//печать дерева от элемента вниз
void print_tree(tree_element* cur_elem);

tree_element* create_tree_element(int i) {
	tree_element* elem = new tree_element;
	elem->valve = i;
	elem->left = NULL;
	elem->right = NULL;
	return elem;
}

void insert_into_tree(tree_element* root, tree_element* elem) {
	if (elem->valve < root->valve) {
		//идем в левое поддерево
		if (root->left == NULL) {
			// левое поддерево - пустое. —юда и вставл€ем новый элемент.
			root->left = elem;
		}
		else {
			//слева что то есть рекурсивно вставл€ем в левое поддерево
			insert_into_tree(root->left, elem);
		}
	}
	else {
		//идем в правое поддерево
		if (root->right == NULL) {
			root->right = elem;
		}
		else {
			// вставл€ем 
			insert_into_tree(root->right, elem);
		}
	}
}

// создаЄм поиск элемента в дереве
void seach_into_tree(tree_element* root, int seach_val) {
	// доделать дома
	if (root == NULL)
	{
		cout << "root==nullptr";
	}
	else {
		if ((root->valve != NULL) && (seach_val == root->valve)) {
			cout << seach_val << " == root->valve" << endl;
		}
		else
		{
			if ((root->valve != NULL) && (seach_val < root->valve)) {
				seach_into_tree(root->left, seach_val);
			}
			else
			{
				if (root->valve != NULL) {
					seach_into_tree(root->right, seach_val);
				}
				else
				{
					cout << seach_val << " == root->right";
				}
			}
		}
	}
}
void print_tree(tree_element* cur_elem) {
	if (cur_elem->left != NULL) {
		print_tree(cur_elem->left);
	}
	cout << "Valve= " << cur_elem->valve << endl;
	if (cur_elem->right != NULL) {
		print_tree(cur_elem->right);
	}

}

int main()
{
	int seach_val;
	cout << "input value\t";
	cin >> seach_val;
	int a[7] = { -3,1,-5,42,2,-6,8 };
	tree_element* root = create_tree_element(10);
	for (int i = 0; i < 7; i++) {
		tree_element* el = create_tree_element(a[i]);
		insert_into_tree(root, el);
	}
	cout << "My tree:" << endl;
	print_tree(root);
	seach_into_tree(root, seach_val);
	return 0;
}