package com.uni;

public class Main {

    public static void main(String[] args) {
        int[] numbers = {55, 123, 23, 11, -37, 98};
        int sum = 0;
//        for (int i = 0; i <numbers.length ; i++) {
//            sum+=numbers[i];
//        }
        for (int number : numbers) {
            sum += number;
        }
        System.out.println("The sum is:" + sum);
        System.out.println("Average:" + (double)(sum) / numbers.length);
    }
}
