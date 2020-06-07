#include <iostream>

typedef struct node {
	int value;
	node* next;
} node;

void addNode(int value, node** head) {
	node* lastNode;
	node* newNode = (node*)malloc(sizeof(node));
	newNode->value = value;
	newNode->next = NULL;

	if (*head == NULL) {
		*head = newNode;
		return;
	}
	lastNode = *head;
	while(lastNode->next != NULL) {
		lastNode = lastNode->next;
	}
	lastNode->next = newNode;
}

int main() {
	node* head = NULL;
	addNode(2, &head);
	addNode(3, &head);
	addNode(4, &head);
	node* currNode = head;
	while(currNode != NULL) {
		printf("%d\n", currNode->value);
		currNode = currNode->next;
	}
	return 0;
}