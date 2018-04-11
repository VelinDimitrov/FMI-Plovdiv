package com.uni;


import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        Student s1=new Student("Goshko","432423532432","4214142341");
        Teacher t1=new Teacher(30.50,"Bachelor","Pesho","141341342");
        Person p1 =new Person("Tania", "4143141321");

        Subject sub1=new Subject("OOP",6);
        s1.addGrade(sub1);
        s1.addGrade(new Subject("Matematika",3));

        ArrayList<Person> list =new ArrayList<>();

        list.add(s1);
        list.add(t1);
        list.add(p1);

        for (Person p :
                list) {
            System.out.println(p.printInfo());
        }
    }
}
