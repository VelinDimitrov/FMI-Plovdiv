package com.uni;

import java.util.ArrayList;
import java.util.StringJoiner;

public class Student extends Person {
    private String fakNumber;
    private int year;
    private boolean isRegular;
    private ArrayList<Subject> grade = new ArrayList<>();

    public Student(String name, String EGN, String fakNumber) {
        super(name, EGN);
        this.fakNumber = fakNumber;
    }

    @Override
    public String toString() {
        return "Original" + super.toString() +
                "\nStudent{" +
                "fakNumber='" + fakNumber + '\'' +
                ", year=" + year +
                ", isRegular=" + isRegular +
                ", age=" + getAge() +
                ", name='" + getName() + '\'' +
                ", gender='" + getGender() + '\'' +
                ", EGN='" + getEGN() + '\'' +
                "} " + super.toString();
    }

    public void addGrade(Subject sub){
        grade.add(sub);
    }
    public String showAllGrades(){
        String result="";
        for (Subject someGrade:grade) {
            result+=someGrade.getName() + " " +someGrade.getGrade()+'\n';
        }
        return result;
    }
    public String printInfo() {
        return "Name " + getName() + " fakNumber = " + fakNumber +'\n'+showAllGrades();
    }
}
