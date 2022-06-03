public class LinearEquation {
    private int _a, _b, _c, _d, _e, _f;
    public LinearEquation (int a, int b, int c, int d, int e, int f){
        this._a = a;
        this._b = b;
        this._c = c;
        this._d = d;
        this._e = e;
        this._f = f;
    }
    public int GetA(){
        return _a;
    }
    public int GetB(){
        return _b;
    }
    public int GetC(){
        return _c;
    }
    public int GetD(){
        return _d;
    }
    public int GetE(){
        return _e;
    }
    public int GetF(){
        return _f;
    }
    public boolean isSolvable(){
        int x = _a * _d;
        int y = _b * _c;
        int z = x - y;
        if(z != 0){
            return true;
        }else {
            return false;
        }
    }
    public double getX(){
        double re = (_e*_f)-(_b*_f);
        double sult = (_a*_d)-(_b*_c);
        double result = re/sult;
        return result; 
    }
    public double getY(){
        double re = (_a*_f)-(_e*_c);
        double sult = (_a*_d)-(_b*_c);
        double result = re/sult;
        return result; 
    }
}
