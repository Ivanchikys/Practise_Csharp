/*Проверить, содержит ли строка только буквы одного регистра.*/

string str = "duffy";
bool isOneRegistr = false;

for (int i = 0; i < str.Length; i++)
{
    if ((char.IsLower(str[i]) & char.IsLower(str[(i + 1) % str.Length]) || (char.IsUpper(str[i])) & char.IsUpper(str[(i + 1) % str.Length])))
    {
        isOneRegistr = true;
    }
    else { isOneRegistr = false; break; }
}

Console.WriteLine(isOneRegistr ? "Один" : "Разный");