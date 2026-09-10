
// Console.WriteLine("Автор: Козубенко Елена");
// Console.WriteLine("Год: 2026");

// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Elena";

// Console.WriteLine(name);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);
// Console.WriteLine(age);

// Console.WriteLine($"Привет от {name}");

// var chislo = 44.2;
// Console.WriteLine(chislo);

// Console.WriteLine("векдите имя");
// string name1 = Console.ReadLine();
// Console.WriteLine($"Привет, {name1}");

// Console.WriteLine("векдите chislo:");
// string chislo2 = Console.ReadLine();
// int chislo1 = int.Parse(chislo2);
// Console.WriteLine(chislo1 + 1);

// string firstname = "Elena";
// string lastname = "Kozubenko";
// string group = "ISP-241";
// int birthyear = 2008;
// double gpa = 4.6;
// bool hasschoolaership = true;

// int currentyear = 2026;
// int age = currentyear - birthyear;

// Console.WriteLine($"Студ удостоверение:");
// Console.WriteLine($"name: {firstname} {lastname}");
// Console.WriteLine($"group: {group}");
// Console.WriteLine($"age: {age}");
// Console.WriteLine($"sredniy bal: {gpa}");
// Console.WriteLine($"stipendia: {hasschoolaership}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично {firstname} Любит {subject}");

// int a = 15;
// int b = 4;
// Console.WriteLine($"Summa: {a + b}");
// Console.WriteLine($"diff: {a - b}");
// Console.WriteLine($"proisv: {a * b}");
// Console.WriteLine($"chastnoe: {a / b}");
// Console.WriteLine($"ostatok: {a % b}");

// double result = (double)a / b;
// Console.WriteLine($"chastnoe double: {result}");

// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));

// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Summa: {num1 + num2}");
// Console.WriteLine($"diff: {num1 - num2}");
// Console.WriteLine($"proisv: {num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"Chastnoe: {num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль нельзя");

// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MinValue);

// Console.WriteLine("");
// Console.Write("");
// Console.ReadLine();

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
string birthyear = int.Parse(Console.ReadLine());
Console.Write("Введите ваш средний балл(напр 4.5): ");
string gpa = double.Parse(Console.ReadLine());

int age = 2026 - birthyear;
bool isExcellent = gpa >= 4.5;
// string status;
// if (isExcellent) status = "Отличник";
// else status = "Хорошист";

string status = isExcellent ? "Отличник" : "Хорошист";

Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст {age}");
Console.WriteLine($"Средний балл {gpa}");
Console.WriteLine($"Статус {status}");
Console.WriteLine($"Лет до 30 {30 - age}");

Console.WriteLine("Нажмите enter для выхода");
Console.ReadLine();