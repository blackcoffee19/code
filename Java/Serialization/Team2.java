import java.io.*;
public class Team2 implements Serializable{
    private Team1 team;
    public static void main(String[] args) throws IOException, FileNotFoundException,ClassNotFoundException{
    Team1 team = new Team1("TeamOfQueen", "IrisKIII");
    FileInputStream fileInputStream = new FileInputStream("team.txt");
    ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
    Team1 team2 = (Team1) objectInputStream.readObject();
    System.out.println("Team 1: "+team);
    System.out.println("Team 2: "+team2);
}
        
}
