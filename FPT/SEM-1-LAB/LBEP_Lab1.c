#include <stdio.h>
#include <math.h>

int main(){
	printf("Bài 1: \n");
	printf("Tính bình phương số nguyên n. Nhập n: ");
	int n;
	scanf("%d",&n);
	n *= n;
	printf("Bình phương của n = %d\n", n);
	printf("Bài 2: \nTính tổng các số nguyên từ 1 đến n \nNhập n:");
	scanf("%d",&n);
	int m;
	while(n>0){
	m +=n;
	n--;
	};
	printf("Tổng là: %d\n",m);
	printf("")
	return 0;
}

