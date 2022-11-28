using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

//Создаем по нашему формату который мы сами придумали

string phonePattern = @"^\d{1}-\d{3}-\d{3}-\d{2}-\d{2}$";           // Формат который мы задали
Console.WriteLine("Введите номер телефона по формату 8-ХХХ-ХХХ-ХХ-ХХ");
string phone_number = Console.ReadLine();           // Вводим телефон
Regex regex = new Regex(phonePattern);          //Создаем патерн в который мы засовываем наш формат
Console.WriteLine(regex.IsMatch(phone_number) ? "Формат ништяк." : "Неверный формат ввода!");           // Вывод где мы проверяем совпадает ли наш формат с введенным




//Вводим текст, ищем по данному тексту нужный нам кусок и выводим слова в которых встречаются наш кусок, а позже заменяем их на то что нам нужно и выводим весь текст снова

string s = "Расскажи про покупки, про какие покупки про покупки?Про покупки, про покупки, про покупочки..";     //Вводим текст
Regex regex1 = new Regex(@"\w*окуп\w*");        //По какому признаку ищем слова
MatchCollection matches = regex1.Matches(s);    //Объект в патернах который во всем тексте через форич ищет наши слова  
if (matches.Count > 0)
{
    foreach (Match match in matches)                    //ЦИКЛ где ищем
        Console.WriteLine(match.Value);
}
else
{
    Console.WriteLine("Совпадений не найдено");         //Если не найдено   
}

Console.WriteLine(s);       //Выводим наш Текст
Console.WriteLine(Regex.Replace(s, (@"\w*окуп\w*"), "Сучек"));      // Показываем в каких словах меняем и на что