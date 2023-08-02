//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Delegaterepeat
//{
//    internal class PracticeDelegate
//    {

        //public delegate void ChangeStr(string str);

        //public delegate void CheckLength(string str);

        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(StrToLower);
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(StrToUpper);
        //}

        //public int GetLength(string text)
        //{
        //    return text.Length;
        //}

        //public delegate bool CheckNums(int num);

      

        //public bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number > 5;
        //}

        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}


        //public void ExecuteMetod()
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9, 12 };

        //    var result = numbers.Where(m => m % 2 == 1).Sum(m => m);
        //    Console.WriteLine(result);

        //    GetString("Salam", StrToUpper);

        //    Action<string> func = new Action<string>(StrToUpper);

        //    func.Invoke("Salamlar");

        //    GetStringLength("salammm", GetLength);
        //}

        //private void GetStringLength(string str, CheckLength func)
        //{
        //    Console.WriteLine(func(str));
        //}

        //private void SumNumbers(List<int> numbers, CheckNums func)
        //{
        //    int sum = 0;

        //    foreach (var number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

    //}

    //private void GetString(string str, ChangeStr func)
    //{
    //    func(str);
    //}
    
//}
