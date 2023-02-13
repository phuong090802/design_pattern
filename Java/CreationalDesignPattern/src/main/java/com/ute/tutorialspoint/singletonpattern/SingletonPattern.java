package com.ute.tutorialspoint.singletonpattern;

public class SingletonPattern {
    private static final SingletonPattern singletonPattern = new SingletonPattern();

    private SingletonPattern() {
    }

    public static SingletonPattern getSinglePattern() {
        return singletonPattern;
    }

    public void showMessage() {
        System.out.println("Hello World!");
    }
}
