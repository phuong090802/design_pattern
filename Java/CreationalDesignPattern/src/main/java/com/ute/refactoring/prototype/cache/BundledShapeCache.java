package com.ute.refactoring.prototype.cache;

import com.ute.refactoring.prototype.shapes.Circle;
import com.ute.refactoring.prototype.shapes.Rectangle;

import java.util.HashMap;
import java.util.Map;

public class BundledShapeCache {
    private final Map<String, com.ute.refactoring.prototype.shapes.Shape> cache = new HashMap<>();
    public BundledShapeCache() {
        Circle circle = new Circle();
        circle.x = 5;
        circle.y = 7;
        circle.radius = 45;
        circle.color = "Green";

        Rectangle rectangle = new Rectangle();
        rectangle.x = 6;
        rectangle.y = 9;
        rectangle.width = 8;
        rectangle.height = 10;
        rectangle.color = "Blue";

        cache.put("Big green circle", circle);
        cache.put("Medium blue rectangle", rectangle);
    }

    public com.ute.refactoring.prototype.shapes.Shape put(String key, com.ute.refactoring.prototype.shapes.Shape shape) {
        cache.put(key, shape);
        return shape;
    }

    public com.ute.refactoring.prototype.shapes.Shape get(String key) {
        return cache.get(key).clone();
    }
}
