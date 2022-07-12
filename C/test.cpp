#include <stdio.h>
int main(){

	int n, tmp = 10;
	n = ++tmp;
	printf("%d\t%d\n",n,tmp);
	int m, mpt = 10;
	m = mpt++;
	printf("%d\t%d\n",m,mpt);
 return 0;
}
