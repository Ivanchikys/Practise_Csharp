using Task1;

var calc = new Calculator(10, 20);
Console.WriteLine(
                $"sum ([x,y] = [{calc.X},{calc.Y}]) = {calc.Sum()}\n" +
                $"difference ([x,y] = [{calc.X},{calc.Y}]) = {calc.Difference()}\n" +
                $"multiply ([x,y] = [{calc.X},{calc.Y}]) = {calc.Multiply()}\n" +
                $"divide ([x,y] = [{calc.X},{calc.Y}]) = {calc.Divide()}"
                );