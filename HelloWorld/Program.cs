
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

string firstname = "Elena";
string lastname = "Kozubenko";
string group = "ISP-241";
int birthyear = 2008;
double gpa = 4.6;
bool hasschoolaership = true;

int currentyear = 2026;
int age = currentyear - birthyear;

Console.WriteLine($"Студ удостоверение:");
Console.WriteLine($"name: {firstname} {lastname}");
Console.WriteLine($"group: {group}");
Console.WriteLine($"age: {age}");
Console.WriteLine($"sredniy bal: {gpa}");
Console.WriteLine($"stipendia: {hasschoolaership}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично {firstname} Любит {subject}");
