#include <stdio.h>
#include <stdbool.h>
int main(){
	bool start = true;
	while(start){
	printf("Input your weight you wanna change (0. exit):  ");
	int weight;
	scanf("%d", &weight);
	if(weight == 0){
		printf("Bye!\n");
		break;
	};
	printf("Choose your planet: \n1.Mercury\n2. Venus\n3. Mars\n4.Jupiter\n5. Saturn\n6. Uranus\n7. Nepturn\n");
	int planet;
	scanf("%d", &planet);
	if(planet < 0 || planet > 7){
		printf("Wrong planet!\n");
	} else {
	switch(planet){
		case 1:
			printf("Your weight in Mercury: %.2f\n",weight*0.38);
			break;
		case 2:
			printf("Your weight in Venus:  %.2f\n", weight*0.91);
			break;
		case 3:
			printf("Your weight in Mars: %.2f\n", weight*0.38);
			break;
		case 4:
			printf("Your weight in Jupiter: %.2f\n", weight*2.34);
			break;
		case 5:
			printf("Your weight in Saturn: %.2f\n", weight*1.06);
			break;
		case 6:
			printf("Your weight in Uranus: %.2f\n", weight*0.92);
			break;
		case 7:
			printf("Your weight in Neptune: %.2f\n", weight*1.19);
			break;
		default:
			printf("NULL");
			break;
	};
	};
	};
	return 0;
}
