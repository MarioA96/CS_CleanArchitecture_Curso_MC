
Console.WriteLine(Tomorrow());
Console.WriteLine(TomorrowPure(new DateTime(2024, 05, 01, 00, 00, 00)));
Console.WriteLine("\n\n");

//* Recuerda! Las clases y Array, se pasan por referencia en C#, los Struct y demas primitivos se pasan por valor

var beer = new Beer()
{
    Name = "Heineken"
};
Console.WriteLine(ToUpper(beer).Name); // Aqui se modifica
Console.WriteLine(beer.Name); // Se modifico la salida, por lo que la funcion no es pura
Console.WriteLine("\n\n");

var beer2 = new Beer()
{
    Name = "Heineken"
};
Console.WriteLine(ToUpperPure(beer2).Name); // Aqui No se modifica
Console.WriteLine(beer2.Name); // No se modifico la salida, por lo que la funcion es pura
Console.WriteLine("\n\n");

var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2024, 05, 01, 0, 0, 0)));
Console.WriteLine("\n\n");

// Los action son un tipo de Delegado para definir funciones y el tipado de funciones
Action<string> show = Console.WriteLine; // Void + Generics + Delegates
show("Hola");

// Expresiones Lambda o notacion flecha | funciones anonimas
Action<string> hi = name => Console.WriteLine($"Hola {name}");
hi("Mario");
Action<int, int> add = (a, b) => show((a + b).ToString());
add(5, 6);

// Los delegados Func siempre regresan algo, podemos definir que no lo haga pero como tal retorna algo
Func<int, int, int> mul = (a, b) => a * b;
show(mul(3, 4).ToString());
Func<int, int, string> mulString = (a, b) =>
{
    var res = a * b;
    return res.ToString();
};
show(mulString(10, 50));

// Funciones de orden superior
List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var numbers2 = Filter(numbers, number => number % 2 == 0);
var numbers3 = Filter(numbers, number => number > 5);

foreach (var number in numbers2)
{
    Console.WriteLine(number);
}
foreach (var number in numbers3)
{
    Console.WriteLine(number);
}

List<int> Filter(List<int> list, Func<int, bool> condition)
{
    var resultList = new List<int>();
    foreach (var element in list)
    {
        if (condition(element))
        {
            resultList.Add(element);
        }
    }

    return resultList;
}
;

// Predicados, tipo Predicate, solo recibe un parametro y devuelve unicamente un booleano
Predicate<int> condition1 = x => x % 2 == 0;
Predicate<int> condition2 = x => x > 5;

var numbers4 = FilterPredicate(numbers, condition1);
var numbers5 = FilterPredicate(numbers, condition2);
Console.WriteLine("\n\n");

foreach (var number in numbers4)
{
    Console.WriteLine(number);
}
foreach (var number in numbers5)
{
    Console.WriteLine(number);
}

List<int> FilterPredicate(List<int> list, Predicate<int> condition)
{
    var resultList = new List<int>();
    foreach (var element in list)
    {
        if (condition(element))
        {
            resultList.Add(element);
        }
    }

    return resultList;
}
;




// Funcion No Pura
DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1);
}
Beer ToUpper(Beer beer)
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}


// Funcion Pura
DateTime TomorrowPure(DateTime date)
{
    return date.AddDays(1);
}
Beer ToUpperPure(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };

    return beer2;
}


public class Beer
{
    public required string Name { get; set; }
}

