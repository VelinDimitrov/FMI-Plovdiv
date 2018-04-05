package com.uni;

import java.util.Scanner;

public class Main {
//    public static int factoriel(int num){
//        if (num == 1) {
//            return 1;
//        }
//        return num*factoriel(num-1);
//    }

    public static void main(String[] args) throws Exception{
        Scanner input=new Scanner(System.in);
        System.out.print("Enter values for a ,b ,c:");
        Triangle tri1;
	     try {
             tri1=new Triangle(input.nextDouble(),input.nextDouble(),input.nextDouble());
             tri1.getInfo();
         }
         catch (Exception e){
             System.out.println("Invalid Triangle");
         }
         //recursion test
//        System.out.println(factoriel(4));

    }
}
