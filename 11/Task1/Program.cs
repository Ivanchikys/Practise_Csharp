using Task1;

var manager = DiscountManager.GetInstance();

manager.SetDiscount("Ноутбук", 15.5);

var discount = manager.GetDiscount("Ноутбук");
Console.WriteLine($"Скидка на ноутбук: {discount}%");

var anotherManager = DiscountManager.GetInstance();
Console.WriteLine($"Это один и тот же объект? {manager == anotherManager}");