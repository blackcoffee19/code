import java.util.*;
import java.io.*;

public class Enemy implements Serializable{
    private int _dmg;
    private int _hp;
    private int _dropcoin;
    public Enemy(){
        this._dmg = 10;
        this._hp = 10;
        this._dropcoin = randomCoin();
    }
    public String toString(){
        return "Enemy: Dmg "+this._dmg+" | Hp: "+this._hp+" | Drop coin = "+this._dropcoin;
    }
    public int randomCoin(){
        Random randomCoin = new Random();
        return randomCoin.nextInt(20)+1; 
    }
    public int getDmg(){
        return this._dmg;
    }
    public int getHp(){
        return this._hp;
    }
    public int getDropCoin(){
        return this._dropcoin;
    }
    public void enemyLossHp(int dame){
        this._hp -= dame;
    }
}
