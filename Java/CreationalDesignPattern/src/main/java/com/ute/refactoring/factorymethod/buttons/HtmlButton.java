package com.ute.refactoring.factorymethod.buttons;

public class HtmlButton implements Button{
    @Override
    public void render() {
        System.out.println("<button>Test Button</Button>");
        onClick();
    }

    @Override
    public void onClick() {
        System.out.println("Click! Button says - 'Hello World!'");
    }
}
