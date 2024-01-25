// See https://aka.ms/new-console-template for more information
using BuilderExample;
Director director = new Director();
PBuilder carBuilder = new Car("Nissan");
director.construct(carBuilder);
Product car = carBuilder.getCar();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($" The car {car.show()}");
