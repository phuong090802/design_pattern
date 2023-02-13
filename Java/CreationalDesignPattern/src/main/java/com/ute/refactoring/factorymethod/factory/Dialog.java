package com.ute.refactoring.factorymethod.factory;

import com.ute.refactoring.factorymethod.buttons.Button;

public abstract class Dialog {
    public void renderWindows() {
        Button okButton = createButton();
        okButton.render();
    }

    public abstract Button createButton();
}
