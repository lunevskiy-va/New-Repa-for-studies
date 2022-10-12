#include <iostream>
#include <string.h>
#include <stdlib.h>
#include <time.h>
#include <stdio.h>
using namespace std;
// ��������� �������������� ������� ������
typedef struct tree_element {
	int valve; // ������
	struct tree_element* left; // ����� �����
	struct tree_element* right;// ������ �����
} tree_element;

//�������� �������� � �������� ���������
tree_element* create_tree_element(int i);

// ������� ������ �������� � ������
void seach_into_tree(tree_element* root, int elem);

//��������� ������� elem � ������ � ������ root
void insert_into_tree(tree_element* root, tree_element* elem);

//������ ������ �� �������� ����
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
		//���� � ����� ���������
		if (root->left == NULL) {
			// ����� ��������� - ������. ���� � ��������� ����� �������.
			root->left = elem;
		}
		else {
			//����� ��� �� ���� ���������� ��������� � ����� ���������
			insert_into_tree(root->left, elem);
		}
	}
	else {
		//���� � ������ ���������
		if (root->right == NULL) {
			root->right = elem;
		}
		else {
			// ��������� 
			insert_into_tree(root->right, elem);
		}
	}
}

// ������ ����� �������� � ������
void seach_into_tree(tree_element* root, int seach_val) {
	// �������� ����
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