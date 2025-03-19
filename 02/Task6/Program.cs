/*12. Дан номер масти m ( 1<= m <= 4 ) и номер достоинства карты k (
6 <= k <= 14). Определить полное название соответствующей карты в виде &quot;дама
пик&quot;, &quot;шестерка бубен&quot; и т.д.*/

using Task6;

Card card = new Card();
Console.Write("Введите номер масти" + 
    "\n1 - Пика" +
    "\n2 - Червь" +
    "\n3 - Буба" +
    "\n4 - Крести\n "
    );
byte n = byte.Parse(Console.ReadLine());
card.Kart(n);

Console.Write("Выбрать карту" +
    "\n 6 - шестерка" +
    "\n 7 - семёрка" +
    "\n 8 - восьмёрка" +
    "\n 9 - девятка" +
    "\n 10 - десятка" +
    "\n 11 - валет" +
    "\n 12 - дама" +
    "\n 13 - король" +
    "\n 14 - туз\n"
    );
byte k = byte.Parse(Console.ReadLine());
card.Mast(k);

Console.WriteLine($"Карта: {card.kart} {card.mast}");