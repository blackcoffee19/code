import java.util.*;

public class StopWatch{
    private int startTime;
    private int endTime;
        public int GetStartTime() {return startTime;}
        public int GetEndTime() {return endTime;}
        public void stop() {endTime = 0;}
        public void start(){startTime = 0;}
        public StopWatch(int time){
            this.startTime = 0;
            this.endTime = time;
        }
        public void getElapsedTime(){
            while(startTime <= endTime){
                System.out.println(startTime);
                startTime++;
            }
        }
    }
