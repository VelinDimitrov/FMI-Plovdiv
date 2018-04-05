package com.uni;

public class Triangle  {
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c) throws Exception {
        if (checkIfEligeble()) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        else{

            throw new Exception();
        }
    }
    private boolean checkIfEligeble() {
        boolean AIsPresent=b+c>=a;
        boolean BIsPresent=a+c>=b;
        boolean CIsPresent=b+a>=c;
        if (AIsPresent&&BIsPresent&&CIsPresent) {
            return true;
        }
        return false;
    }
    public double getPerimeter(){
        return a+b+c;
    }
    public double getArea(){
        double semiPerimeter=getPerimeter()/2;
        return Math.sqrt(semiPerimeter*(semiPerimeter-a)*(semiPerimeter-b)*(semiPerimeter-c));
    }
    public void getInfo(){
        if (checkIfEligeble()) {
            System.out.println("Perimeter:"+getPerimeter());
            System.out.println("Area:"+getArea());
        }
    }

}
