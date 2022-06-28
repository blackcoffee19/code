import java.lang.*;
import java.io.*;

public class School<T> implements Replaced<T> {
    private T name;
    public School(T name){
        this.name = name;
    }
    public T getName(){
        return this.name;
    }
    @Override
    public void replace(T name){
        this.name = name;
    }
}
