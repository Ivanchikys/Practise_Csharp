using Task2;

CircularBufferManager<int> manager = new CircularBufferManager<int>(3);

manager.AddItem(1);
manager.AddItem(2);
manager.AddItem(3);

manager.PeekItem();

manager.AddItem(4);
manager.RemoveItem();

manager.PeekItem();