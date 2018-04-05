package com.softuni.techmodule;

public class SalesPromo {
    private String name;
    private String city;
    private String promoCode;
    private String categorieStock;
    private String accumulatePromo;
    private String percentOfDiscount;
    private String dayOfPromo;
    private String monthOfPromo;
    private String yearOfPromo;

    //contructor
    public SalesPromo(String name, String city, String code) {
        this.name = name;
        this.city = city;
        this.promoCode = code;
        setPromos(code);
    }

    //getter and setter
    public String getName() {
        return name;
    }

    public String getCity() {
        return city;
    }

    public String getPromoCode() {
        return promoCode;
    }

    public String getCategorieStock() {
        return categorieStock;
    }

    public String getAccumulatePromo() {
        return accumulatePromo;
    }

    public String getPercentOfDiscount() {
        return percentOfDiscount;
    }

    public String getDayOfPromo() {
        return dayOfPromo;
    }

    public String getMonthOfPromo() {
        return monthOfPromo;
    }

    public String getYearOfPromo() {
        return yearOfPromo;
    }

    //methods
    public void print(){
        System.out.printf("%s, %s, %s, %s, %s, %s.%s.%s%n",name,city,categorieStock,
                accumulatePromo,percentOfDiscount,dayOfPromo,monthOfPromo,yearOfPromo);

    }
    private void setPromos(String code) {
        char firstNumber = code.charAt(0);
        this.categorieStock = setCategoriesStock(firstNumber);
        char secondNumber = code.charAt(1);
        this.accumulatePromo=setAccumulatePromo(secondNumber);
        String pairOfNumbers =code.substring(2,4);
        this.percentOfDiscount=pairOfNumbers;
        pairOfNumbers =code.substring(4,6);
        this.dayOfPromo=pairOfNumbers;
        pairOfNumbers =code.substring(6,8);
        this.monthOfPromo=setMonth(pairOfNumbers);
        pairOfNumbers =code.substring(8,10);
        this.yearOfPromo="20"+pairOfNumbers;
    }

    private String setMonth(String monthNumber) {
        int month=Integer.parseInt(monthNumber);
        String monthName=null;
        switch(month){
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
                monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
                monthName = "November";
                break;
            case 12:
                monthName = "December";
                break;
            default:
                monthName = "Invalid month";
                break;
        }
        return monthName;
    }


    private String setAccumulatePromo(char secondNumber) {
         String accumulate=null;
         switch (secondNumber){
             case '0':
                 accumulate = "Bez natrupvane";
                 break;
             case '1':
                 accumulate = "S natrupvane";
                 break;
         }
        return accumulate;
    }

    private String setCategoriesStock(char number) {
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


    public boolean isPlovdivAndPefume() {
        if (city.equals("Пловдив")&&categorieStock.equals("perfume")) {
            return true;
        }
            return false;
    }
}
