public class Main {
    public static void main(String[] args) {
    int nameNumber = 231;
    String nameStr = "Ala";
    School<Integer> school = new School<Integer>(nameNumber);
    System.out.println(school.getName());
    Staff staff = new Staff(nameStr);
    System.out.println(staff.getName());
    school.replace(32);
    System.out.println(school.getName());
    staff.replace("vsd");
    System.out.println(staff.getName());
    }
}
