System.Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] strArray = {"x > 0 и y > 0","x < 0 и y > 0","x < 0 и y < 0","x < 0 и y < 0","Введённые данные не соответсвуют услоыиям!"};

if (number > 0 && number <5)
    System.Console.WriteLine(strArray[number-1]);
else
    System.Console.WriteLine(strArray[4]);

// switch (number)
// {
//     case 1:
//         System.Console.WriteLine(strArray[0]);
//         break;
//     case 2:
//         System.Console.WriteLine(strArray[1]);
//         break;
//     case 3:
//         System.Console.WriteLine(strArray[2]);
//         break;
//     case 4:
//         System.Console.WriteLine(strArray[3]);
//         break;
//     default:
//         System.Console.WriteLine(strArray[4]);
//         break;
// }