import java.lang.*;
import java.io.*;

public class Staff implements Replaced<String>{
    private String name;
    public Staff(String name){
        this.name = name;
    }
    public String getName(){
        return this.name;
    }
    @Override
    public void replace(String newName){
        this.name =newName;
    }
}
