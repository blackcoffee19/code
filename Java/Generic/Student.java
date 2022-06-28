public class Student {
    private String name;
    public Student(String name){
        this.name = name;
    }
    public String getName(){
        return this.name;
    }
    public static <T>boolean isString(T type){
        return type instanceof String;
    }
}