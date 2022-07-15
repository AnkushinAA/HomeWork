List<string>? list = new List<string> { "Мама", "Мимоза", "Папа", "Пипоза", "Квадроцикл"};
List<string>? list2 = new List<string> { "1.txt", "1.txt", "3.txt", "1.gpj", "2.gpj", "3.gpj", "4.cls", "12.txt"};
IEnumerable<string> ResultList = from item in list
                                 where item.StartsWith("М") && item.EndsWith("а")
                                 select item;
foreach (var result in ResultList)
{
    Console.WriteLine(result);
}
void ShowSelect(string extension, List<string> file)
{
    int counter=0;
    IEnumerable<string>? list = from item in file
                                where item.Substring(item.IndexOf('.') + 1) == extension
                                select item;
    counter = list.Count();
    Console.WriteLine($"В списке {file.GetType().Name} {counter} файлов с расширением {extension}");
}
ShowSelect("txt", list2);

