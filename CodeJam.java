/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package codejam;

import java.util.*;

/**
 *
 * @author EliteBook
 */
public class CodeJam {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        //What is the output of this code?
        Test1();//40

        /*
         What is the output?
         Exception
         Jen
         Bob
         */
        Test2();//Jen

        //What is the output of this code?
        Test3();//goblin

        //What is the output of this code?
        Test4();//hi

        //What is the output of this code?
        //s
        //a
        Test5();

        /*
         What is the output of this code?
         Infinity
         -Infinity
         NaN
         Compilation error
         */
        Test6();//-8 -Infinity

        /*
         What is the output of this code?
         45
         44
         566
         44.56
         */
        Test7();//44

        /*
         What is the correct extension for java file? 
         R/ .java
         .exe
         .jv
         .c
         */

        /*
         Can an interface be instantiated directly?
         R/ Yes
         No
         */
        
        //What is the output of this code?
        Test8();//7

        //What is the output of this code?
        Test9();//6

        //What is the output of this code?
        Test10();//4

        //Which of the following is a valid array declaration containing 3 elements?
        //int a[] = int { 0,0,0 };
        //int[] a = int[3];
        //int[] a = new int { 0, 0, 0 };
        //R/ int[] a = new int[3];  
        
        //What is the output of this code?
        Test11();//1

        //What is the output of this code?
        Test12();//15

        //What is the output of this code?
        Test13();//3

        //How many times will the following loop run?
        Test14();//2

        //What is the output of this code?
        Test15();//19

        //What is the output of this code?
        Test16();//26

        //What is the output of this code?
        Test17();//1

        //What is the output of this code?
        Test18();//5

        //What will be the result?
            /*
         12
         11
         14
         13
         */
        Test19();//13

        //What is the output of this code?
        Test20();

        //What is the output of this code?
        /*
         h
         this
         error
         is
         */
        Test21();//h

        //What is the output of this code?
        Test22();//9

        //What is the output of this code?
        /*
         str
         str null
         null str
         null null
         */
        Test23();//null str

        //What is the output of this code?
        /*
         Won't compile
         Output is 5
         Output is 0
         Output is 9
         */
        //Test24();
        
        //What is the output of this code?
        Test25();//4

        /*
         How many values a bool can accept?
         0
         it depends
         R/ 2
         1
         */
        
        //What is the output of this code?
        Test26();//25

        //What is the output of this code?
        Test29();//20

        //What is the output of this code?
        Test31();//15            

        //What is the output of this code?
        Test33();//1

        /*
         Which of these data types take a number?
         R/ double
         String
         boolean
         R/ int
         */
        
        //What is the output of this code?
        Test34();//11

        //What is the output of this code?
        Test35();//00

        //What is the output of this code?
        Test36();//1

        //What is the output of this code?
        /*
         :(
         R/ :)
         */
        Test37();

        //What is the output of this code?
        Test38();//ab381

        //What is the output of this code?
        Test39();//utonom

        //What is the output of this code?
        Test40();//2  
    }

    public static void Test40() {

        int[][] tab1 = new int[][]{{2, 3}, {7, 4}};
        int[][] tab2 = new int[][]{{8, 1}, {6, 5}};

        System.out.println(tab1[1][0] % tab2[1][1]);
    }

    public static void Test39() {
        String x = "";
        char[] y = ("autonoma").toCharArray();

        for (int i = 0; i < y.length; i++) {
            if (y[i] > 'f') {
                x += y[i];
            }
        }

        System.out.println(x);
    }

    public static void Test38() {
        int a = 20;
        int b = 68;
        int c = 381;
        System.out.println("a" + "b" + c);
    }

    public static void Test37() {
        String myname = "user";
        if (myname.contains("us")) {
            System.out.println(":)");
        } else {
            System.out.println(":(");
        }
    }

    public static void Test36() {
        int x = 2;
        int y = ++x + x++;
        int z = --y - x--;
        System.out.println(z);
    }

    public static void Test35() {
        System.out.println("0" + "0");
    }

    public static void Test34() {
        int x = 5;
        x += ++x;
        System.out.println(x);
    }

    public static void Test33() {
        int x = 15;
        x /= 7;
        x %= 1;

        System.out.println(++x);
    }

    public static void Test31() {
        int n = 10;
        int x = 15;

        if (n > x) {
            System.out.println(n);
        } else {
            System.out.println(x);
        }
    }

    public static void Test29() {
        int x = 10;
        do {
            x *= 2;
        } while (x <= 5);

        System.out.println(x);
    }

    public static void Test26() {
        int x = 1;
        int[] arr = {2, 4, 7, 5};

        x += arr[1];
        x *= arr[3];

        System.out.println(x);
    }

    public static void Test25() {
        int x = 3;
        int y = 6;
        int z = x + y % 2;

        System.out.println(++z);
    }

    public static void Test24() {
        for (int i = 0; i < 10; i++) {
            //System out print ln(i);
            i = -5;
        }
    }

    public static void Test23() {
        String str = null;

        System.out.println(str + " str");
    }

    public static void Test22() {
        int j = 0;
        for (int i = 0; i < 10; i++) {
            j = i;
        }

        System.out.println(j);
    }

    public static void Test21() {
        String[][] listOfWords = {
            {"this", "is"},
            {"2d", "array"}
        };

        System.out.println((listOfWords[0][0]).toCharArray()[1]);
    }

    public static void Test20() {
        int x = 1;
        int[][] m = new int[][]{
            {2, 1, 3},
            {3, 5, 4},
            {4, 3, 5}
        };

        for (int i = 0; i <= 2; i++) {
            x *= m[i][2 - i];
        }

        System.out.println(x);
    }

    public static void Test19() {
        int n;
        n = (7 * 5 > 6 * 6)
                ? (7 * 9 > 8 * 8) ? 11 : 12
                : (7 * 8 > 9 * 6) ? 13 : 14;

        System.out.println(n);
    }

    public static void Test18() {
        int a = 4;
        int b = ++a;

        if (b > 5) {
            System.out.println(b);
        } else {
            System.out.println(a);
        }
    }

    public static void Test17() {
        int a = 9;
        int b = a / 18;
        ++b;

        System.out.println(b);
    }

    public static void Test16() {
        int x = 6;
        int y = 13;
        int z = y % x + 5 * 5;

        System.out.println(z);
    }

    public static void Test15() {
        int y = 9;
        int x = y++;

        System.out.println(x + y);
    }

    public static void Test14() {
        int a = 5;
        do {
            System.out.println(a);
        } while (++a <= 6);
    }

    public static void Test13() {
        int x = 6, y = 4;
        int z = ++x - y--;

        System.out.println(z);
    }

    public static void Test12() {
        int x = 10;
        do {
            x += 5;
        } while (x < 15);

        System.out.println(x);
    }

    public static int increase(int a) {
        a += 5;
        return a;
    }

    public static void Test11() {
        int a = 1, b;
        b = increase(a);
        System.out.println(a);
    }

    public static void Test1() {
        int x = 8;
        int y = 5;
        int z = (x > y) ? x * y : x + y;
        System.out.println(z);
    }

    static class P {

        public String N1;

        public String getN1() {
            return "Jen";
        }

        public void setN1(String N1) {

        }
    }

    public static void Test2() {
        P p = new P();
        p.setN1("Bob");
        System.out.println(p.getN1());
    }

    public static void Test3() {
        String[] race = new String[]{"dwarf", "elf", "goblin", "human"};
        System.out.println(race[2]);
    }

    public static void Test4() {
        int x = 1;
        String output = (x == 1) ? "hi" : "bye";
        System.out.println(output);
    }

    static class Person {

        public String name;
        public String country;

        public Person() {
            name = "Petar";
            country = "Bulgaria";
        }
    }

    public static void Test5() {
        Person p1 = new Person();
        p1.name = "Gosho";
        System.out.print(p1.name.toCharArray()[2]);
        System.out.println(p1.country.toCharArray()[4]);
    }

    public static void Test6() {
        double x = 2 / -0.0;
        System.out.println(x);
    }

    public static void Test7() {
        int y;
        double x = 44.566;
        y = (int) (x);
        System.out.println(y);
    }

    public static void Test8() {
        int n = 5;
        int m = 7;
        int z = 6;
        if (++n < m && z == n++) {
            System.out.println(m);
        } else {
            System.out.println(n);
        }
    }

    public static void Test9() {
        int i;
        for (i = 1; i < 9; i++) {
            if (i % 2 != 0) {
                continue;
            }

            if (i % 3 == 0) {
                break;
            }
        }
        System.out.println(i);
    }

    public static void Test10() {
        int x = 16;
        int y = 3;
        x %= y * 2;
        System.out.println(x++);
    }
}
