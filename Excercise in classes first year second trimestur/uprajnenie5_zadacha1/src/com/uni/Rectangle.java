package com.uni;

import java.io.IOException;

public class Rectangle {
    private double a;
    private double b;
//constructors
    public Rectangle(double a, double b) throws IOException {
        if (checkValues(a,b)) {
            this.a = a;
            this.b = b;
        }
        else {
            throw new IOException();
        }
    }
    public Rectangle(double a) throws IOException {
        if (checkValues(a)) {
            this.a = a;
            this.b = a;
        }
        else {
            throw new IOException();
        }
    }

    // get and set values
    public double getA() {
        return a;
    }

    public void setA(double a) {
        if (checkValues(a)) {
            this.a = a;
        }
        else{
            System.out.println("Negative values");
        }
    }

    public double getB() {
        return b;
    }

    public void setB(double b) {
        if (checkValues(b)) {
            this.b = b;
        }
        else{
            System.out.println("Negative values");
        }
    }
// methods
    public double calculateArea(){
        return a*b;
    }
    public double calculatePerimeter(){
        return 2*a+2*b;
    }
    private boolean checkValues(double a, double b) {
        if (a>=0&&b>=0) {
            return true;
        }
        return false;
    }
    private boolean checkValues(double number) {
        if (number>=0) {
            return true;
        }
        return false;
    }
}
