package com.uni;

public class Subject {
    private String name;
    private int grade;
    //constructor
    public Subject(String name, int grade) {
        this.name = name;
        this.grade = grade;
    }
    //getter setter
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getGrade() {
        return grade;
    }

    public void setGrade(int grade) {
        this.grade = grade;
    }
    //methods

}
