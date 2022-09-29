// // Вид 1!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// void Method1()
// {
//     Console.WriteLine("Метод 1");
// }
// // Вызов метода
// Method1();

// // Вид 2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Вызов метода
// Method2(msg: "Текст сообщения");

// void Method2(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Вызов метода
// Method2(msg: "Текст сообщения", count: 4);  //Не обязательно явно именованные аргументы писать по порядку

// // Вид 3!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// int Method3()
// {
//     return DataTime.Now.Year;
// }
// // Вызов метода
// int year = Method3();
// Console.WriteLine(year);


// // Вид 4!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 string Method4(int count, string text)
 {
     int i=0;
     string result = String.Empty;
    
     while (i<count)
     {
         result = result + text;
         i++;
     }
     return result;
 }

 string res = Method4(10,"asdf");
 Console.WriteLine(res);
