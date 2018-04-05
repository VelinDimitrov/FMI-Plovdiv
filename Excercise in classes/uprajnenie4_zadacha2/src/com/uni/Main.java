package com.uni;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter number of elements :");
        int numberOfElements = Integer.parseInt(input.nextLine());
//        int[] arrayOfIntegers = new int[numberOfElements];
//        for (int i = 0; i < numberOfElements; i++) {
//            System.out.print("Please enter element "+(i+1)+" :");
//            arrayOfIntegers[i] = input.nextInt();
//
//        }
//        System.out.println(Arrays.toString(arrayOfIntegers));
       String[] array=new String[numberOfElements];
        for (int i = 0; i < array.length; i++) {
            System.out.print("Please enter element "+(i+1)+" :");
            array[i]=input.nextLine();
        }
        System.out.println(Arrays.toString(array));
        for (int i = 0; i < array.length; i++) {
            for (int j = i+1; j < array.length; j++) {
                if (array[i].length()>array[j].length()){
//                    String temp=array[i];
//                    array[i]=array[j];
//                    array[j]=temp;
                    swap(array[i],array[j]);
                }
            }
        }
        System.out.println(Arrays.toString(array));

    }

    private static void swap(String s, String s1) {
        String temp=s;
        s=s1;
        s1=temp;
    }
}
