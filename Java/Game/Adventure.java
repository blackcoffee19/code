import java.util.*;
import java.io.*;
import java.nio.*;
import java.nio.file.Files;
import java.nio.file.Paths;
public class Adventure {
    public Player player;
    public static void main(String[] args) throws IOException, ClassNotFoundException, FileNotFoundException {
        System.out.println("Welcome to A adventure!");
        System.out.print("Are you ready for your adventure? yes(y) or no(n)");
        Scanner answerInput= new Scanner(System.in);
        String answer = answerInput.next();
        if(answer.equals("y")){
            Scanner answerName = new Scanner(System.in);
            addDelay(1000);
            System.out.print("\nOke nice! Now tell me what your hero name: ");
            String inputName = answerName.next();
            File file = new File(inputName+".txt");
            Player player;
            addDelay(1000);
            if(file.isFile() && file.canRead()){
                System.out.println("Welcome back");
                GameSave oldGame = new GameSave(inputName);
                player = oldGame.Load();
            } else{
                System.out.println("Hello new one");
                GameSave newgame = new GameSave(inputName);
                newgame.Save();
                player = newgame.Load();
            }; 
            addDelay(2000);
            System.out.println(player.toString());
            Random ran = new Random();
            int i = 0;
            while(player.getPlayerHp() > 0 ){
                addDelay(1000);
                i++;
                System.out.println("\nRound "+i+"\n");
                int ran1 = ran.nextInt(10)+1;
                if(ran1 >= 9){
                    player.Buff();
                } else {
                    System.out.println("Found enemy! Fight or Run? f or r");
                    String answerZ = answerName.next().toLowerCase();
                    if(answerZ.equals("f")){
                        GameSave.Fighting(player);
                    } else {
                        addDelay(2000);
                        int ran2 = ran.nextInt(10)+1;
                        if(ran2 < 9 ){
                            System.out.println("Running failure... In battle");
                            GameSave.Fighting(player);
                        } else {
                            System.out.println("Congratulation! Running Successfull!");
                        }
                    }
                };
                Scanner answer2 = new Scanner(System.in);
                addDelay(1000);
                System.out.println(player.toString());
                if(player.getPlayerHp() <= 0){
                    addDelay(2000);
                    System.out.println("You die... Game over");
                    System.out.println("You have total: "+player.getCoin()+" coins");
                    String fileName = player.getName()+".txt";
                    Files.delete(Paths.get(fileName));
                    break;
                };
                addDelay(1000);
                System.out.print("Do you want heal? You will pay 20 coin (y or n): ");
                String answerOne = answer2.next().toLowerCase();
                if(answerOne.equals("y")){
                    System.out.println("Healing ...");
                    addDelay(1000);
                    player.Heal();
                    System.out.println(player.toString());
                };
                System.out.print("Do you want countinue? (y or n)");
                String answerTWo = answer2.next().toLowerCase();
                addDelay(1000);
                if(answerTWo.equals("n")){
                    System.out.print("Do you want save? (y or n)");
                    addDelay(1000);
                    String answerThree = answer2.next().toLowerCase();
                    if(answerThree.equals("y")){
                        FileOutputStream fileOutputStream = new FileOutputStream(player.getName()+".txt");
                        ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
                        objectOutputStream.writeObject(player);
                    };
                    break;
                } else{
                 continue;   
                }
            }
            
        } else {
            System.out.println("So... you're not ready for the game\n See you next time.");
        }
    }
    public static void addDelay(int time){
        try {
            Thread.sleep(time);
          } catch (InterruptedException e) {
            e.printStackTrace();
          }
    }
}
