namespace NEWTASK
{
    delegate void TemperatureAlert(int temp);
    delegate void NumberCheck(int number);
    delegate void ExamResult(int score);
    delegate void WordCheck(string word);
    internal class Program
    {
        //Task 1
        // //  static void TooCold(int temp)
        // // {
        // //     if (temp < 10)
        // //         Console.WriteLine("Çox soyuqdur ");
        // // }

        // // static void Normal(int temp)
        // // {
        // //     if (temp >= 10 && temp <= 25)
        // //         Console.WriteLine("Temperatur normaldır ");
        // // }

        // // static void TooHot(int temp)
        // // {
        // //     if (temp > 25)
        // //         Console.WriteLine("İstidir ");
        // // }

        // // static void Main()
        // // {
        // //     Console.Write("Temperaturu daxil edin: ");
        // //     int temp = Convert.ToInt32(Console.ReadLine());

        // //     TemperatureAlert alert = TooCold;
        // //     alert += Normal;
        // //     alert += TooHot;

        // //     alert(temp);
        // }




        //Task 2
        //  static void IsNegative(int number)
        // {
        //     if (number < 0)
        //         Console.WriteLine("Menfi ədəd daxil etdiniz");
        // }

        // static void IsZero(int number)
        // {
        //     if (number == 0)
        //         Console.WriteLine("Sıfır daxil etdiniz");
        // }

        // static void IsPositive(int number)
        // {
        //     if (number > 0)
        //         Console.WriteLine("Müsbət ədəd daxil etdiniz");
        // }

        // static void Main()
        // {
        //     Console.Write("Ədəd daxil edin: ");
        //     int num = Convert.ToInt32(Console.ReadLine());

        //     NumberCheck check = IsNegative;
        //     check += IsZero;
        //     check += IsPositive;

        //     check(num);
        // }



        //Task 3 
        // static void Fail(int score)
        // {
        //     if (score < 51)
        //         Console.WriteLine("İmtahandan keçmədiniz");
        // }

        // static void Average(int score)
        // {
        //     if (score >= 51 && score <= 80)
        //         Console.WriteLine("Orta nəticə");
        // }

        // static void Excellent(int score)
        // {
        //     if (score > 80)
        //         Console.WriteLine("Əla nəticə!");
        // }

        // static void Main()
        // {
        //     Console.Write("Balınızı daxil edin: ");
        //     int score = Convert.ToInt32(Console.ReadLine());

        //     ExamResult result = Fail;
        //     result += Average;
        //     result += Excellent;

        //     result(score);
        // }


        //Task4
        // static void IsLongWord(string word)
        // {
        //     if (word.Length > 7)
        //         Console.WriteLine("Söz çox uzundur ");
        // }

        // static void IsShortWord(string word)
        // {
        //     if (word.Length <= 3)
        //         Console.WriteLine("Söz çox qısadır ");
        // }

        // static void IsNormalWord(string word)
        // {
        //     if (word.Length > 3 && word.Length <= 7)
        //         Console.WriteLine("Söz normal uzunluqdadır ");
        // }

        // static void Main()
        // {
        //     Console.Write("Sözü daxil edin: ");
        //     string word = Console.ReadLine();

        //     WordCheck check = IsLongWord;
        //     check += IsShortWord;
        //     check += IsNormalWord;

        //     check(word);
        // }
    }
}
