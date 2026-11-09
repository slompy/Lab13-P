// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^ _ ^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
//     Console.WriteLine("Дата формирования отчёта: 9 ноября 2026 года"); 
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("     Конец программы");
//     Console.WriteLine("X_X");
// }


// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }

// PrintStudentCard("Егор", 18, "ИСП-250");
// PrintStudentCard("Валерия", 17, "ИСП-267");


// double baseScholarship = 2000;
// double currentAverageGrade = 4.6; 

// if (IsEligibleForBonus(currentAverageGrade)) {
//     double result = CalculateScholarship(baseScholarship, 15);
//     Console.WriteLine($"Стипендия с надбавкой: {result}");
// } else {
//     double result = CalculateScholarship(baseScholarship, 0);
//     Console.WriteLine($"Обычная стипендия: {result}");
// }

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// Console.WriteLine($"Средний балл: {average}");

// int fivesCount = CountFives(grades);
// Console.WriteLine($"Количество пятерок в массиве: {fivesCount}");

// double CalculateAverageGrade(int[] grades) {
//     int sum = 0;
//     foreach (int grade in grades) {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades) {
//     int count = 0;
//     foreach (int grade in grades) {
//         if (grade == 5) {
//             count++;
//         }
//     }
//     return count;
// }

// // Задача А

// Console.WriteLine("Текст перед первым разделителем");
//     PrintDivider();

// Console.WriteLine("Текст перед вторым разделителем");
//     PrintDivider();

// Console.WriteLine("Текст перед третьим разделителем");
//     PrintDivider();
    
// static void PrintDivider() {
//     Console.WriteLine("========================================");
// }

// // Задача Б

// PrintPerson("Иван", 20);
// PrintPerson("Даня", 18);
// PrintPerson("Илюша", 25);

// static void PrintPerson(string name, int age) {
//     Console.WriteLine($"Человек: {name}, возраст: {age} лет");
// }




// Вариант 1

Console.WriteLine("Вариант 1. void PrintSeparator()");
Console.WriteLine();

Console.WriteLine("Первый банан");
PrintSeparator();

Console.WriteLine("Второй банан");
PrintSeparator();

Console.WriteLine("Третий банан");
PrintSeparator();
        
Console.WriteLine("Четвертый банан");

    static void PrintSeparator() {
        Console.WriteLine("=========================================");
    }

// Вариант 2

Console.WriteLine();
Console.WriteLine("Вариант 2. double CalculateArea(double width, double height)");
Console.WriteLine();

double area1 = CalculateArea(5.5, 4.0);
Console.WriteLine($"Площадь первого прямоугольника: {area1}");
double area2 = CalculateArea(10.2, 3.5);
Console.WriteLine($"Площадь второго прямоугольника: {area2}");
    

static double CalculateArea(double width, double height) {
    return width * height;
}