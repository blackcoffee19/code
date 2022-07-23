#include<stdio.h>

int main() {
  double num = 34.2;
  double* ptr1 = &num;
	printf("Increase and descrease data of address pointer:\n");
  printf("%p\n",ptr1);
  printf("%f\n",*ptr1);
  *ptr1 += 5;
  printf("%p\n",ptr1);
  printf("%f\n",*ptr1);
  *ptr1 -= 4;
  printf("%p\n",ptr1);
  printf("%f\n",*ptr1);
	printf("Increase and descrease pointer to point a new memory address\n");
  printf("%p\n",ptr1);
  printf("%f\n",*ptr1);
  ptr1 += 5;
  printf("%p\n",ptr1);
  printf("%f\n",*ptr1);
	return 0;
}
