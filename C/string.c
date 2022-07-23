#include <stdio.h>
#include <string.h>

void copy(char* dst, char* src){
	int i = 0;
	while(src[i] != '\0'){
		dst[i] = src[i];
		i++;
	};
}

int main(){
	char *arr[40];
	char **ptr = arr;
	printf("What you name? ");
	char name[40];
	scanf("%s",name);
	ptr[0] = name;
	printf("Your name is: %s\n",arr[0]);
	printf("What your type? ");
	char type[40];
	scanf("%s",type);
	ptr[1] = type;
	for(int i = 0; i < 2; i++){
		printf("%s and \n", ptr[i]);
	}
	return 0;
}
