import java.io.*;

public class Team1 implements Serializable{
    private String name;
    private Guard guard;
    private Defender defender; 
    private static final long serialVersionUID = 1L;
    private transient String doctor;
    
    public Team1(String na, String doc){
        this.name = na;
        this.doctor = doc;
        this.guard = new Guard("Lappland", "Felmale", 5, "Siracusa", "Lupo", 1.62);
        this.defender = new Defender("Saria", "Female", 5, "Columbia", "Vouivre", 1.74);
    }
    
     private void writeObject(ObjectOutputStream stream) throws IOException{
        stream.writeObject(this.name);
        stream.writeObject(this.doctor);
        stream.writeObject(this.guard.GetCodeName());
        stream.writeObject(this.guard.GetGender());
        stream.writeInt(this.guard.GetCB());
        stream.writeObject(this.guard.GetLoB());
        stream.writeObject(this.guard.GetRace());
        stream.writeDouble(this.guard.GetHeight());
        stream.writeObject(this.defender);
      }
     private void readObject(ObjectInputStream stream) throws IOException, ClassNotFoundException{
        this.name = (String) stream.readObject();
        this.doctor = (String) stream.readObject();
        String codeName = (String) stream.readObject();
        String gender = (String) stream.readObject();
        int cb = (int) stream.readInt();
        String lob = (String) stream.readObject();
        String race = (String) stream.readObject();
        double height = (double) stream.readDouble();
        this.guard= new Guard(codeName, gender, cb, lob, race, height);
        this.defender = (Defender) stream.readObject(); 
     }
    public String toString(){
        return String.format("Team %s of doctor %s has: \n%s\n%s\n", this.name,this.doctor, this.defender,this.guard);
    }
    public static void main(String[] args) throws FileNotFoundException,IOException,ClassNotFoundException{
        Team1 blackcoffee = new Team1("Team 1","BlackCoffee");
        FileOutputStream fileOutputStream = new FileOutputStream("team.txt");
        ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
        objectOutputStream.writeObject(blackcoffee);
        
        FileInputStream fileInputStream = new FileInputStream("team.txt");
        ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
        Team1 teamCopy = (Team1) objectInputStream.readObject();
        boolean isSameObj = blackcoffee == teamCopy;
        System.out.println("Team (Original):-" + blackcoffee);
        System.out.println("Team (Copy):-" + teamCopy);
        System.out.println("Is same: "+isSameObj);
    }   

}