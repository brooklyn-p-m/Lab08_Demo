
Console.Clear();
Console.Write("Number of Students: ");
int studentCount = GetInt();
Console.Write("Number of Assignments: ");
int assignmentCount = GetInt();

string[] students = new string[studentCount];

for (int i = 0; i < students.Length; i++)
{
    Console.Write($"Student {i + 1}'s Name: ");
    students[i] = Console.ReadLine();
}

double[,] grades = new double[studentCount, assignmentCount];

for (int i = 0; i < students.Length; i++)
{
    for (int j = 0; j < grades.GetLength(1); j++)
    {
        Console.Write($"Please enter {students[i]}'s Grade for Assignment {j + 1}: ");
        grades[i, j] = GetDouble();
    }
}


//Printing Gradebook
Console.Clear();
Console.WriteLine("GRADEBOOK");
Console.Write("Name      ");
for (int i = 0; i < grades.GetLength(1); i++) 
{
    Console.Write($"| Assignment{i + 1} ");
}

Console.WriteLine();
for (int i = 0; i < students.Length; i++) 
{
    Console.Write($"{students[i],-10}");
    for (int j = 0; j < grades.GetLength(1); j++)
    {
        Console.Write($"| {grades[i, j],-12}");
    }
    Console.WriteLine();
}


//Methods
double GetDouble()
{
    while (true)
    {
        string input = Console.ReadLine();
        double valid;
        if (double.TryParse(input, out valid)) return valid;
        else Console.Write("Enter valid number: ");
    }
}
int GetInt()
{
    while (true)
    {
        string input = Console.ReadLine();
        int valid;
        if (int.TryParse(input, out valid)) return valid;
        else Console.Write("Enter valid number: ");
    }
}