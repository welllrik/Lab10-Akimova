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


string[] studentsNamed = { "Аня", "Борис", "Вика" };
int number = 1;
foreach (string student in studentsNamed)
{
    Console.WriteLine($"{number}. {student}");
    number++;
}


int[] numsA = { 2, 7, 4, 9, 1 };
int sumA = 0;
foreach (int value in numsA)
{
    Console.WriteLine(value);
    sumA += value;
}
Console.WriteLine($"Сумма чисел: {sumA}");


string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
foreach (string day in days)
{
    Console.WriteLine($"{day}!");
}




Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


string word = "программирование";
int consonants = 0;

foreach (char c in word)
{
    char lower = char.ToLower(c);
    if (lower != 'а' && lower != 'е' && lower != 'ё' && lower != 'и' &&
        lower != 'о' && lower != 'у' && lower != 'ы' && lower != 'э' &&
        lower != 'ю' && lower != 'я')
    {
        consonants++;
    }
}

Console.WriteLine($"Согласных букв: {consonants}");


string[] books = { "Азбука", "Мёртвые души", "Капитанская дочка" };
string search = "Мёртвые души";
bool found = false;

foreach (string book in books)
{
    if (book == search)
    {
        found = true;
    }
}

Console.WriteLine(found ? "Найдено" : "Не найдено");

