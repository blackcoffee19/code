#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
// Structures section
struct Race {
  int numberOfLaps;
  int currentLap;
  char firstPlaceDriverName[30];
  char firstPlaceRaceCarColor[30];
};
struct RaceCar{
  char driverName[30];
  char raceCarColor[30];
  int totalLapTime;
};
// Print functions section
void printIntro(){
  printf("Welcome to our main event digital race fans!\nI hope everybody has their snacks because we are about to begin!\n");
}
void printCountDown(){
  printf("Racers Ready! In...\n");
  for(int i = 5; i>0;i--){
    printf("%d\n",i);
  };
  printf("Race!\n");
};
void printFirstPlaceAfterLap(struct Race race){
  printf("After lap number %d\nFirst Place Is: %s in the %s race car!\n\n",race.currentLap,race.firstPlaceDriverName,race.firstPlaceRaceCarColor);
}
void printCongratulation(struct Race race){
  printf("\t Let's all congratulate %s in the %s race car for an amazing performance.\nIt truly was a great race and everybody have a goodnight!\n\n",race.firstPlaceDriverName,race.firstPlaceRaceCarColor);
}
// Logic functions section
int calculateTimeToCompleteLap(){
  int speed = rand()%3+1;
  int acceleration = rand()%3+1;
  int nerves = rand()%3+1;
  // printf("speed: %d \t acceleration: %d \t nerves: %d\n",speed,acceleration,nerves);
  return speed+acceleration+nerves;
}
void updateRaceCar(struct RaceCar* raceCar){
  raceCar->totalLapTime = calculateTimeToCompleteLap();
}
void updateFirstPlace(struct Race* race, struct RaceCar* raceCar1,struct RaceCar* raceCar2){
  char name[30];
  char color[30]; 
  if(raceCar1->totalLapTime < raceCar2->totalLapTime){
    strcpy(race->firstPlaceDriverName,raceCar1->driverName);
    strcpy(race->firstPlaceRaceCarColor,raceCar1->raceCarColor);
  }else if(raceCar1->totalLapTime > raceCar2->totalLapTime){
    strcpy(race->firstPlaceDriverName,raceCar2->driverName);
    strcpy(race->firstPlaceRaceCarColor,raceCar2->raceCarColor);
  } else {
    printf("Equal!");
  }
}
void startRace(struct RaceCar* raceCar1, struct RaceCar* raceCar2){
  struct Race race = {
    .numberOfLaps = 5,
    .currentLap = 1,
    .firstPlaceDriverName = "",
    .firstPlaceRaceCarColor = "",
  };
  for(int i = 1; i <= race.numberOfLaps; i++){
    race.currentLap = i; 
    updateRaceCar(raceCar1);
    updateRaceCar(raceCar2);
    updateFirstPlace(&race,raceCar1,raceCar2);
    printFirstPlaceAfterLap(race);
  };
  printCongratulation(race);
}
int main() {
	srand(time(0));
  printIntro();
  struct RaceCar car1 = {.driverName = "BlackCoffee",.raceCarColor="black"};
  struct RaceCar car2 = {.driverName = "Irisk",.raceCarColor="white"};
  printCountDown();
  startRace(&car1,&car2);
};
