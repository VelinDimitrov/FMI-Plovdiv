package com.uni;

import java.io.IOException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input =new Scanner(System.in);
        Rectangle rec1,kvadrat;
        try {
            rec1 =new Rectangle(input.nextDouble(),input.nextDouble());
            System.out.println(rec1.calculateArea());
            System.out.println(rec1.calculatePerimeter());
            kvadrat =new Rectangle(input.nextDouble());
            System.out.println(kvadrat.calculatePerimeter());
            System.out.println(kvadrat.calculateArea());
        }catch (IOException ex){
            System.out.println("Negative values");
        }


    }
}
