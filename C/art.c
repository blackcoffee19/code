#include <stdio.h>
int main(){
	int num, count=0;
	printf("Enter a number: ");
	scanf("%d",&num);
	for(int i = 0; i< num; i++){
		for(int j = 0; j < (num-i);j++){
			printf(" ");
		};
		for(int k = 0; k < i; k++){
			printf("*");
			count++;
		};
		for(int l = 0; l < i-1;l++){
			printf("*");
			count++;
		};
		printf("\n");
	};
	printf("There are %d starts\n",count);
	return 0;
}
