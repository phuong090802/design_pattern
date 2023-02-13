package com.ute.refactoring.abstractfactory.buttons;

import com.ute.refactoring.abstractfactory.buttons.Button;

public class MacOSButton implements Button {
    @Override
    public void paint() {
        System.out.println("You have created MacOSButton.");
    }
}
