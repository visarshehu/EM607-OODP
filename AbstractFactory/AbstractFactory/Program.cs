using AbstractFactory;

ColorShapeAbstractFactory blueRectangle = new BlueRectangleFactory();
Shape rectangle = blueRectangle.CreateShape();
Color blue = blueRectangle.CreateColor();
rectangle.Draw();
blue.Fill();