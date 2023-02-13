package com.ute.refactoring.factorymethod.factory;

import com.ute.refactoring.factorymethod.buttons.Button;
import com.ute.refactoring.factorymethod.buttons.WindowsButton;

public class WindowsDialog extends Dialog{
    @Override
    public Button createButton() {
        return new WindowsButton();
    }
}
