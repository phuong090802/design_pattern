package com.ute.refactoring.factorymethod.factory;

import com.ute.refactoring.factorymethod.buttons.Button;
import com.ute.refactoring.factorymethod.buttons.HtmlButton;

public class HtmlDialog extends Dialog{
    @Override
    public Button createButton() {
        return new HtmlButton();
    }
}
