using Task_1;


var firstEmployee = new Employee("Arthur", 9500);
firstEmployee += 500;

var secondEmployee = new Employee("Jhon", 8500);
secondEmployee -= 1000;

Console.WriteLine(firstEmployee);
Console.WriteLine(secondEmployee);

Console.WriteLine(firstEmployee == secondEmployee);
Console.WriteLine(firstEmployee > secondEmployee);