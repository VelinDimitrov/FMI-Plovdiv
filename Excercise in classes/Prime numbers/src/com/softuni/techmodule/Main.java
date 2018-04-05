package com.softuni.techmodule;

public class Main {

    public static void main(String[] args) {
        for (int j = 2; j <= 1000; j++) {
            if (checkPrime(j)) {
                System.out.println(j);
            }
        }
    }

    private static boolean checkPrime(int j) {
        for (int i = 2; i <=Math.sqrt(j) ; i++) {
            if (j % i==0) {
                return false;
            }
        }
        return true;
    }
}
