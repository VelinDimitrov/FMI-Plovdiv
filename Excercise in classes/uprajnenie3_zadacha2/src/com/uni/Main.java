package com.uni;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int number;
        do {
            System.out.println("1.Calculator\n2.Hello\n0.exit\nChoose option from above:");
            number=input.nextInt();
        }while (number<0||number>2);
        switch (number){
            case 1:
                System.out.println(calculate());
                break;
            case 2:
                System.out.println("Hello");
                break;
                default:
                    System.out.println("Programme exited...");
        }

    }

    private static double calculate() {
            Scanner input=new Scanner(System.in);
            System.out.println("Enter two numbers:");
            int number1=input.nextInt();
            int number2=input.nextInt();
            System.out.print("Enter operation:");
            char operation=input.next().charAt(0);
            switch (operation){
                case '+': return number1+number2;
                case '-': return number1-number2;
                case '*': return number1*number2;
                case '/': return number1/number2;
            }
            return 0;
    }
}
