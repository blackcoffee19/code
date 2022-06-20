import java.io.*;
public class Defender implements Serializable {
    private String CodeName;
    private String Gender;
    private int CombatE;
    private String LoB;
    private String Race;
    private double Height;
    public Defender(String codename, String gender, int ce, String lob, String race,double height){
        this.CodeName = codename;
        this.Gender = gender;
        this.CombatE = ce;
        this.LoB = lob;
        this.Race = race;
        this.Height = height;
    }
    public String GetCodeName(){
        return this.CodeName;
    } 
    public String GetGender(){
        return this.Gender;
    } 
    public int GetCB(){
        return this.CombatE;
    } 
    public String GetLoB(){
        return this.LoB;
    } 
    public String GetRace(){
        return this.Race;
    } 
    public double GetHeight(){
        return this.Height;
    }
    public void SetCodeName(String newcode){
        this.CodeName = newcode;
    } 
    public void SetCB(int combat){
        this.CombatE = combat;
    } 
    public void SetLoB(String newLoB){
        this.LoB = newLoB;
    } 
    public void GetRace(String newrace){
        this.Race = newrace;
    } 
    public void GetHeight(double NewHeight){
        this.Height = NewHeight;
    }
    public String toString(){
        return String.format("Defender: %s\nGender: %s\nCombat Experience: %d\nPlace of birth: %s\nRace: %s\nHeight: %.2f\n", CodeName,Gender,CombatE,LoB,Race, Height);
    }
}
