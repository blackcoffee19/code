#include <stdio.h>
#include <stdbool.h>
bool is_leap_year(int year){
  if(year%4 != 0){
    return false;
  } else{
    if(year %100 != 0){
      return true;
    } else if(year%100 == 0 && year%400 != 0){
      return false;
    } else {
      return true;
    }
  }
}

void add_days_to_date(int* mm, int* dd, int* yy, int days_left_to_add){
  int days_in_month[13] = {0,31,28,31,30,31,30,31,31,30,31,30,31};
  if(is_leap_year(*yy)){
        days_in_month[2] = 29;
  };
  int days_left_in_month = days_in_month[*mm] - *dd;
  while((days_left_to_add - days_left_in_month) >= 0){
    days_left_to_add -=  days_left_in_month;
    *mm += 1;
    if(*mm > 12){
      *yy += 1;
      *mm -= 12;
    };
    if(is_leap_year(*yy)){
      days_in_month[2] = 29;
    };
    days_left_in_month = days_in_month[*mm];
  };
  *dd = days_left_to_add;

}
int main() {
  int mm, dd,yy,days_left_to_add;
  scanf("%d\t%d\t%d\t%d",&mm,&dd,&yy,&days_left_to_add);
  add_days_to_date(&mm,&dd,&yy,days_left_to_add);
  printf("Month: %d \t Day: %d \t Year: %d \n",mm,dd,yy);
}