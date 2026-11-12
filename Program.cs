string subject = "Программирование";
foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"Всего букв в слове: {subject.Length}");

int[] grades = { 4, 5, 3, 5, 4 };
int sumGrades = 0;
foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sumGrades += grade;
}
Console.WriteLine($"Сумма оценок: {sumGrades}, средний балл: {(double)sumGrades / grades.Length}");


string[] students = { "Аня", "Ярослав", "Вика" };
int studentCount = 0;
foreach (string student in students)
{
    studentCount++;
}
Console.WriteLine($"Всего учеников: {studentCount}");


int[] points = { 10, 20, 15 };
foreach (int point in points)
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}
foreach (int point in points)
{
    Console.WriteLine(point);
}