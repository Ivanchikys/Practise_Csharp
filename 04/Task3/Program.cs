/*В этом задании вам предстоит разработать иерархию классов с использованием abstract и sealed классов. 
 * В каждой задаче у вас должен быть:
 * абстрактный класс (родительский), 
 * sealed класс (конкретная реализация),
 * модельный класс с массивом объектов, 
 * а также два метода бизнес-логики.
*/
/*Система управления интернет-магазином
Создайте систему учета товаров в интернет-магазине.
Структура классов:
    abstract класс Product с полями Name, Category, Price, StockQuantity.
    sealed классы ElectronicsProduct и ClothingProduct.
    OnlineStore (модельный класс) с массивом Product[].
Методы бизнес-логики:
    GetOutOfStockProducts() – находит все товары, которых нет в наличии.
    GetMostExpensiveProduct() – находит самый дорогой товар.
*/  
using Task3;

Product[] products = new Product[]
        {
            new ElectronicsProduct("Laptop", 1000, 5),
            new ClothingProduct("T-Shirt", 20, 0),
            new ElectronicsProduct("Smartphone", 800, 10),
            new ClothingProduct("Jeans", 50, 2),
            new ElectronicsProduct("Headphones", 200, 0)
        };

OnlineStore store = new OnlineStore(products);

Console.WriteLine("Товары, которых нет на складе:");
foreach (var product in store.GetOutOfStockProducts())
{
    Console.WriteLine($"{product.Name} - {product.Category}");
}

var mostExpensive = store.GetMostExpensiveProduct();
if (mostExpensive != null)
{
    Console.WriteLine($"\nСамый дорогой продукт : {mostExpensive.Name} - {mostExpensive.Price:C}");
}