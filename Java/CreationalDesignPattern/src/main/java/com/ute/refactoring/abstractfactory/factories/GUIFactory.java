package com.ute.refactoring.abstractfactory.factories;

import com.ute.refactoring.abstractfactory.buttons.Button;
import com.ute.refactoring.abstractfactory.checkboxes.Checkbox;

public interface GUIFactory {
    Button createButton();
    Checkbox createCheckbox();
}
