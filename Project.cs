internal class Program
{

    private static void Main(string[] args)
    {
        CalcAB();           // Task 1 - Обрахунок суми,різниці,добутку та ділення двох чисел.
        AnsForQuasiont();   // Task 2 - Зчитує відповідь на запитання How are you.
        ReadChar();         // Task 3 - Зчитування та виведення символів.
        PositiveCheck();    // Task 4 - Перевірка, чи обидва ввведених числа є позитивними.
        SqrPerimeter();     // Task 5 - Обрахунок периметру квадрата.
        ProfInfo();         // Task 6 - Зчитування та виведння імені та віку
        SircleCalc();       // Task 7 - Обрахунок параметрів кола
    }
    private static void CalcAB()    
    {
        double a, b;
        Console.WriteLine( " Input a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Input b"); 
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($" {a} + {b} = {a + b:F2}");
        Console.WriteLine($" {a} - {b} = {a - b:F2}");
        Console.WriteLine($" {a} * {b} = {a * b:F2}");
        Console.WriteLine($" {a} / {b} = {a / b:F2}");
        Console.ReadKey();
        Console.Clear();
    }
    private static void AnsForQuasiont()   
    {
        string answer;
        Console.WriteLine( " How are you " );
        answer = Console.ReadLine();
        Console.WriteLine( " You are " + answer );
        Console.ReadKey();
        Console.Clear();
    }
    private static void ReadChar()  
    {
        char first, second, third;
        Console.WriteLine( " Input first character " );
        first = Convert.ToChar(Console.ReadLine());
        Console.WriteLine( " Input second character " );
        second= Convert.ToChar(Console.ReadLine());
        Console.WriteLine( " Input third character " );
        third = Convert.ToChar(Console.ReadLine());
        Console.WriteLine( " You enter " + first + ", " + second + ", " + third );
        Console.ReadKey();
        Console.Clear();
    }
    private static void PositiveCheck() 
    {
        int firstNum, secondNum;
        Console.WriteLine( " Input a first  number " );
        firstNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Input a second  number ");
        secondNum = Convert.ToInt32(Console.ReadLine());
        bool areBothPositive = firstNum > 0 && secondNum > 0;
        if (areBothPositive)
        {
            Console.WriteLine( " Both numbers are positive " );
        }
        else
        {
            Console.WriteLine( " Not all numbers are positive " );
        }
        Console.ReadKey();
        Console.Clear();
    }
    private static void SqrPerimeter()  
    {
        int a,sqrPer;
        Console.WriteLine( "Input the length of a side of a square in SI system " );
        a=Convert.ToInt32(Console.ReadLine());
        sqrPer = 4 * a;
        Console.WriteLine( " Square perimeter is " + sqrPer + " meters " );
        Console.ReadKey();
        Console.Clear();
    }
    private static void ProfInfo() 
    {
        string Name;
        int age;
        Console.WriteLine(" What is your name " );
        Name = Console.ReadLine();
        Console.WriteLine( " How old are you " + Name );
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( " Your name is " + Name + " and you are " + age + " years old " );
        Console.ReadKey();
        Console.Clear();
    }
    private static void SircleCalc()    
    {
        double srclRadius,srcLenght, srclArea, BallVolume;
        Console.WriteLine( " Input radius of a sircle in SI system " );
        srclRadius = Convert.ToDouble(Console.ReadLine());
        srcLenght = 2.0 * Math.PI * srclRadius;
        srclArea = Math.PI * Math.Pow(srclRadius, 2);
        BallVolume = 4.0 / 3.0 * Math.PI * Math.Pow(srclRadius, 3);
        Console.WriteLine(" Lenght of sircle = " + Math.Round(srcLenght,2)  + " meters " );
        Console.WriteLine(" Area of sircle = " + Math.Round(srclArea,2) + " meters " );
        Console.WriteLine(" Volume of ball = " + Math.Round(BallVolume,2) + " meters " );
        Console.ReadKey();
        Console.Clear();
    }
}