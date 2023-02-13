package com.ute.refactoring.abstractfactory.factories;

import com.ute.refactoring.abstractfactory.buttons.Button;
import com.ute.refactoring.abstractfactory.buttons.WindowsButton;
import com.ute.refactoring.abstractfactory.checkboxes.Checkbox;
import com.ute.refactoring.abstractfactory.checkboxes.WindowsCheckbox;

public class WindowsFactory implements GUIFactory{
    @Override
    public Button createButton() {
        return new WindowsButton();
    }

    @Override
    public Checkbox createCheckbox() {
        return new WindowsCheckbox();
    }
}
