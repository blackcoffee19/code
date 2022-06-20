import java.io.*;
import java.util.*;

public class GameSave implements Serializable{
    public Player player;
    public Enemy enemy;
    public String name;
    public static final long serialVersionUID = 1L;
    public GameSave(String name){
        this.name = name;
        this.player = new Player(name);
    }
    public void Save()throws IOException,FileNotFoundException, ClassNotFoundException{
        FileOutputStream fileOutputStream = new FileOutputStream(this.name+".txt");
        ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
        objectOutputStream.writeObject(player);
    }
    public Player Load() throws IOException,FileNotFoundException,ClassNotFoundException{
        FileInputStream fileInputStream = new FileInputStream(this.name+".txt");
        ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
        player = (Player) objectInputStream.readObject();
        return player;
    }
    public static void Fighting(Player player){
        Random rand = new Random();
        int enemyCreate = rand.nextInt(5)+1;
        for(int i = 0; i < enemyCreate; i++){
            Enemy enemy = new Enemy();
            while(enemy.getHp() > 0){
                enemy.enemyLossHp(player.getPlayerDmg());
                player.LossHp(enemy.getDmg());
            }
            System.out.println("/nDefeat 1 enemy");
            System.out.println("You get: "+enemy.getDropCoin()+"coins \n");
            player.GetCoin(enemy.getDropCoin());
            Adventure.addDelay(2000);
        }
    }
}
