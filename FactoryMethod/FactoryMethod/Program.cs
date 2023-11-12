

using FactoryMethod;

ShapeFactory circleFactory = new CircleFactory();
Shape circle = circleFactory.CreateShape();
circle.Draw();


ShapeFactory rectangleFactory = new RectangleFactory();
Shape rectangle = rectangleFactory.CreateShape();
rectangle.Draw();
