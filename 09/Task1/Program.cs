using Task1;

ShoppingCart cart = new ShoppingCart();

Product p1 = new Product(1, "Шашлык", 10.59m);
Product p2 = new Product(2, "Сыр-косичка", 5.50m);
Product p3 = new Product(3, "Соус барбекю", 3.29m);

cart.AddProduct(p1);
cart.AddProduct(p2);
cart.AddProduct(p3);
cart.DisplayCart();
cart.RemoveProduct(2);
cart.DisplayCart();
cart.SortProductsByPrice();
Product found = cart.FindProduct(1);
Console.WriteLine(found != null ? $"\nНайден продукт: {found}" : "Продукт не найден.");