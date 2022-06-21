import java.io.*;
public class Player implements Serializable {
    private String _name;
    private int _dmg;
    private int _hp;
    private int _coin;
    public Player(String name){
        this._name = name;
        this._dmg = 50;
        this._hp = 100;
        this._coin = 0;
    }
    public String toString(){
        return "\nPlayer: "+this._name+"\nHeath: "+this._hp+"\nDamage: "+this._dmg+"\nPlayer's coin: "+this._coin+"\n";
    }
    public int getPlayerHp(){
        return this._hp;
    }
    public int getPlayerDmg(){
        return this._dmg;
    }
    public int getCoin(){
        return this._coin;
    }
    public void Buff(){
        System.out.println("Damage +5");
        this._dmg += 5;
    }
    public void Heal(){
        if(this._hp > 90 && this._coin > 20){
            this._hp = 100;
            this._coin -= 20;
            System.out.println("Hp +5\n Your hp: "+this._hp+"\n Your coin now: "+this._coin+"\n ");
        }else if(this._hp < 100 && this._coin > 20){
            this._hp += 10;
            this._coin -= 20;
            System.out.println("Hp +5\n Your hp: "+this._hp+"\n Your coin now: "+this._coin+"\n ");
        }
    }
    public void LossHp(int dame){
        System.out.println("HP -"+ dame);
        this._hp -= dame;
    }
    public void GetCoin(int coin){
        this._coin += coin;
    }
    public String getName(){
        return this._name;
    }
    
}