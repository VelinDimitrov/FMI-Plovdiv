package com.uni;

public class Person {
    private int age;
    private String name;
    private String gender;
    private  String EGN;


    public Person(String name, String EGN) {
        this.name = name;
        this.EGN = EGN;
    }

    public int getAge() {
        return age;
    }

    public String getName() {
        return name;
    }

    public String getGender() {
        return gender;
    }

    public String getEGN() {
        return EGN;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public void setEGN(String EGN) {
        this.EGN = EGN;
    }
    public String printInfo(){
        return "Name: "+ name +" age "+ age;
    }
    //methods
    @Override
    public String toString() {
        return "Name = " +getName()+
                " age = "+getAge()+
                " gender = "+getGender() +
                " EGN = " + getEGN()+'\n';
    }

}
