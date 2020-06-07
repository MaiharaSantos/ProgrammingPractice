#include <iostream>

typedef struct node {
	int value;
	node* next;
} node;

typedef struct linkedList {
	node* head;
	node* tail;
} linkedList;

void addNode(int value, node* head) {
	node* lastNode = head;
	node* newNode = (node*)malloc(sizeof(node));
	newNode->value = value;
	newNode->next = NULL;
	while(lastNode->next != NULL) {
		lastNode = lastNode->next;
	}
	lastNode->next = newNode;
}

int main() {
	node* head = (node*)malloc(sizeof(node));
	head->next = NULL;
	addNode(2, head);
	addNode(3, head);
	addNode(4, head);
	node* currNode = head->next;
	while(currNode != NULL) {
		printf("%d\n", currNode->value);
		currNode = currNode->next;
	}
	return 0;
}