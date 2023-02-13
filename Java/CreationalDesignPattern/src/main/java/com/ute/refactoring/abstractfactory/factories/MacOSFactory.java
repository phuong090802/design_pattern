package com.ute.refactoring.abstractfactory.factories;

import com.ute.refactoring.abstractfactory.buttons.Button;
import com.ute.refactoring.abstractfactory.buttons.MacOSButton;
import com.ute.refactoring.abstractfactory.checkboxes.Checkbox;
import com.ute.refactoring.abstractfactory.checkboxes.MacOSCheckbox;

public class MacOSFactory implements GUIFactory{
    @Override
    public Button createButton() {
        return new MacOSButton();
    }

    @Override
    public Checkbox createCheckbox() {
        return new MacOSCheckbox();
    }
}
