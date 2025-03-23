using Task2;
Actor actor1 = new Actor("Мария Александровна");
Actor actor2 = new Actor("Иван Сергеевич");
Actor actor3 = new Actor("Кирилл Андреевич");

List<Actor> actors1 = new List<Actor> { actor1, actor2 };
List<Actor> actors2 = new List<Actor> { actor2, actor3 };

Theater theater1 = new Theater("Большой Театр", "Главная сцена", actors1);
Theater theater2 = new Theater("Малый Театр", "Малая сцена", actors2);

Audience audience1 = new Audience("Павел");
Audience audience2 = new Audience("Мария");

theater1.AddAudience(audience1);
theater1.AddAudience(audience2);
Theater[] theaters = { theater1, theater2 };
foreach (var theater in theaters)
{
    theater.PerformPlay();
}