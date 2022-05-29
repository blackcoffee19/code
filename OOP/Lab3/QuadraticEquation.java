package Lab3;
import java.lang.*;

public class QuadraticEquation {
    private double _a,_b,_c;
    public QuadraticEquation(double a, double b, double c){
        this._a = a;
        this._b = b;
        this._c = c;
    }
    public double GetA(){ return _a;}
    public double GetB(){ return _b;}
    public double GetC(){ return _c;}
    public void SetA(double newA) {this._a = newA;}
    public void SetB(double newB) {this._b = newB;}
    public void SetC(double newC) {this._c = newC;}
    public double getDiscminant() {
        double x = (Math.pow(_b, 2) - (4*_a*_c));
        return x;
    }
}

