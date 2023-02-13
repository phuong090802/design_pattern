package com.ute.refactoring.prototype;

import com.ute.refactoring.prototype.shapes.Circle;
import com.ute.refactoring.prototype.shapes.Rectangle;

import java.util.ArrayList;
import java.util.List;

public class Demo {
    public static void main(String[] args) {
        List<com.ute.refactoring.prototype.shapes.Shape> shapes = new ArrayList<>();
        List<com.ute.refactoring.prototype.shapes.Shape> shapesCopy = new ArrayList<>();

        Circle circle = new Circle();
        circle.x = 10;
        circle.y = 10;
        circle.radius = 15;
        circle.color = "red";
        shapes.add(circle);

        Circle anotherCircle = (Circle) circle.clone();
        shapes.add(anotherCircle);

        Rectangle rectangle = new Rectangle();
        rectangle.width = 10;
        rectangle.height = 20;
        rectangle.color = "blue";
        shapes.add(rectangle);
        cloneAndCompare(shapes, shapesCopy);
    }

    private static void cloneAndCompare(List<com.ute.refactoring.prototype.shapes.Shape> shapes, List<com.ute.refactoring.prototype.shapes.Shape> shapesCopy) {
        for (com.ute.refactoring.prototype.shapes.Shape shape : shapes) {
            shapesCopy.add(shape.clone());
        }
        for (int i = 0; i < shapesCopy.size(); i++) {
//            System.out.println(shapes.get(i).toString());
//            System.out.println(shapesCopy.get(i).toString());
            if (shapes.get(i) != shapesCopy.get(i)) {
                System.out.println(i + ": Shapes are different object (yay!)");
                if (shapes.get(i).equals(shapesCopy.get(i))) {
                    System.out.println(i + ": And they are identical (yay!)");
                } else {
                    System.out.println(i + ": But they are not identical (booo!)");
                }
            } else {
                System.out.println(i + ": Shape object are the same (booo!)");
            }
        }
    }
}
