package com.uni;

public class Teacher extends Person {
    private double payment;
    private String degree;

    public Teacher(double payment, String degree, String name, String EGN) {
        super(name, EGN);
        this.payment = payment;
        this.degree = degree;
    }
    public double calculatePayment(){
        return payment*40*4;
    }
    @Override
    public String printInfo(){
        return "Name = "+ getName()+ " payment = "+calculatePayment();
    }

}
