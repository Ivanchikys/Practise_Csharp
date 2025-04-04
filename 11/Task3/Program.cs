using Task3;

PromotionManager promotionManager = new PromotionManager();

ICustomer loyal1 = new LoyalCustomer("Иван");
ICustomer loyal2 = new LoyalCustomer("Мария");
ICustomer regular1 = new RegularCustomer("Алексей");
ICustomer regular2 = new RegularCustomer("Екатерина");

promotionManager.Subscribe(loyal1);
promotionManager.Subscribe(loyal2);
promotionManager.Subscribe(regular1);
promotionManager.Subscribe(regular2);

promotionManager.AddPromotion("Скидка 20% на все товары!");

promotionManager.Unsubscribe(regular1);
promotionManager.AddPromotion("Супер акция: Бесплатная доставка!");