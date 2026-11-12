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
