package com.softuni.techmodule;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int numberOfPeople;
        do {
            System.out.print("Vuvedete broq na klienti:");
            numberOfPeople = input.nextInt();
        } while (numberOfPeople < 1 || numberOfPeople > 500);
        SalesPromo[] arrayOfSales = new SalesPromo[numberOfPeople];
        // Set info for client,sort it and print it
        for (int i = 0; i < arrayOfSales.length; i++) {
            setClientInfo(arrayOfSales, i);
        }
        sortArray(arrayOfSales);
        System.out.println("List sus danni za vsichki klienti");
        for (SalesPromo sales :
                arrayOfSales) {
            sales.print();
        }
        System.out.println();
        //list for those with perfumes in Plovdiv which is sorted by percentDiscount
        ArrayList<SalesPromo> plovdivPromo = new ArrayList<>();
        for (int i = 0; i < arrayOfSales.length; i++) {
            if (arrayOfSales[i].isPlovdivAndPefume()) {
                plovdivPromo.add(arrayOfSales[i]);
            }
        }
        sortListByPercent(plovdivPromo);
        sortListByPercentAndName(plovdivPromo);
        System.out.println("List sus danni na tezi ot Plovdiv i sus perfume stock");
        for (SalesPromo sales :
                plovdivPromo) {
            sales.print();
        }
        System.out.println("Vuvedete kategoriq na stoka: ");
        String stock = getStock(input.nextInt());
        System.out.println("Max Discount :"+getMaxDiscount(arrayOfSales)+"%");

    }

    private static Double getMaxDiscount(SalesPromo[] arrayOfSales) {
       double maxDiscount=0.0;
        for (int i = 0; i < arrayOfSales.length; i++) {
            if (Double.parseDouble(arrayOfSales[i].getPercentOfDiscount())>maxDiscount) {
                maxDiscount=Double.parseDouble(arrayOfSales[i].getPercentOfDiscount());
            }
        }
            return maxDiscount;
    }

    private static String getStock(int number) {
        String stock = null;
        switch (number) {
            case '1':
                stock = "cosmetics";
                break;
            case '2':
                stock = "perfume";
                break;
            case '3':
                stock = "accessories";
                break;
            case '4':
                stock = "services";
                break;
        }
        return stock;
    }

    private static void sortListByPercentAndName(ArrayList<SalesPromo> plovdivPromo) {
        for (int i = 0; i < plovdivPromo.size(); i++) {
            for (int j = i; j < plovdivPromo.size(); j++) {
                if (Integer.parseInt(plovdivPromo.get(i).getPercentOfDiscount()) ==
                        Integer.parseInt(plovdivPromo.get(j).getPercentOfDiscount())) {
                    if (plovdivPromo.get(i).getName().compareTo(plovdivPromo.get(j).getName()) > 0) {
                        Collections.swap(plovdivPromo, i, j);
                    }
                }
            }
        }
    }

    private static void sortListByPercent(ArrayList<SalesPromo> plovdivPromo) {
        for (int i = 0; i < plovdivPromo.size(); i++) {
            for (int j = i; j < plovdivPromo.size(); j++) {
                if (Integer.parseInt(plovdivPromo.get(i).getPercentOfDiscount()) <
                        Integer.parseInt(plovdivPromo.get(j).getPercentOfDiscount())) {
                    Collections.swap(plovdivPromo, i, j);
                }
            }
        }
    }

    private static void sortArray(SalesPromo[] arrayOfSales) {
        for (int i = 0; i < arrayOfSales.length; i++) {
            for (int j = i; j < arrayOfSales.length; j++) {
                if (arrayOfSales[i].getName().compareTo(arrayOfSales[j].getName()) > 0) {
                    SalesPromo temp = arrayOfSales[i];
                    arrayOfSales[i] = arrayOfSales[j];
                    arrayOfSales[j] = temp;
                }
            }
        }
    }

    private static void setClientInfo(SalesPromo[] arrayOfSales, int i) {
        Scanner input = new Scanner(System.in);
        System.out.println("Vuvedete danni za klient " + (i + 1) + " :");
        System.out.print("Vuvedete ime :");
        String name = input.nextLine();
        System.out.print("Vuvedete grad :");
        String city = input.nextLine();
        System.out.print("Vuvedete Promo Kod :");
        String code = input.nextLine();
        arrayOfSales[i] = new SalesPromo(name, city, code);
    }
}
