package com.ute.refactoring.abstractfactory.app;

import com.ute.refactoring.abstractfactory.buttons.Button;
import com.ute.refactoring.abstractfactory.checkboxes.Checkbox;
import com.ute.refactoring.abstractfactory.factories.GUIFactory;

public class Application {
    private final Button button;
    private final Checkbox checkbox;

    public Application(GUIFactory factory){
        button = factory.createButton();
        checkbox = factory.createCheckbox();
    }

    public  void paint(){
        button.paint();
        checkbox.paint();
    }
}
