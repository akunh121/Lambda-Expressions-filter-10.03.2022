
public class c
{
    delegate bool filter(int num);
    delegate bool MyFirstDelegate(int name);
    //filter nc1 = new filter(AddNum);


    static int[] GetFiltered(int[] q, MyFirstDelegate j)
    {
        int[] ret = new int[0];
        foreach (int i in q)
        {
            if (j(i))
            {

                Array.Resize(ref ret, ret.Length + 1);
                ret[(ret.Length) - 1] = i;
            }

        }

        return ret;
    }
    //static MyFirstDelegate Even = (int a) => { return a % 2 == 0; ; };
    //static MyFirstDelegate IsNotEven = (int a) => { return !(first1(a)); };
    //static MyFirstDelegate Has3 = (int a) => { string num = a.ToString(); foreach (var item in num) { if (item == '3') { return true; } } return false; };
    //static MyFirstDelegate HasSameNumberSequance = (int a) => { string temp = a.ToString(); if (temp.Length == 1) { return true; } else { for (int i = 0; i < temp.Length - 1; i++) { if (temp[i] == temp[i + 1]) { return true; } } } return false; };
    static void Print(int[] f)
    {

        foreach (var item in f)
        {
            Console.Write(item + "\t");
        }
        Console.WriteLine();

    }
    //static bool first1(int a)
    //{
    //    return a % 2 == 0;


    //}
    //static bool IsNotEven(int a)
    //{
    //    return !(first1(a));


    //}


    //static bool HasSameNumberSequance(int a)
    //{
    //    string temp = a.ToString();
    //    if (temp.Length == 1)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        for (int i = 0; i < temp.Length - 1; i++)
    //        {
    //            if (temp[i] == temp[i + 1])
    //            {
    //                return true;
    //            }

    //        }
    //    }

    //    return false;

    //}
    ////static bool Has3(int a)
    ////{
    ////    string num = a.ToString();
    ////    foreach (var item in num)
    ////    {
    ////        if (item == '3')
    ////        {
    ////            return true;
    ////        }

    ////    }
    ////    return false;



    ////}

    static void Main(string[] args)
    {

        int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
        int[] evenArray = GetFiltered(array, (int a) => { return a % 2 == 0; ; });


        int[] notEvenArray = GetFiltered(array, (int a) => { return !(a % 2 == 0); });
        int[] has3Array = GetFiltered(array, (int a) => { string num = a.ToString(); foreach (var item in num) { if (item == '3') { return true; } } return false; });
        int[] hasSameNumberArray = GetFiltered(array, (int a) => { string temp = a.ToString(); if (temp.Length == 1) { return true; } else { for (int i = 0; i < temp.Length - 1; i++) { if (temp[i] == temp[i + 1]) { return true; } } } return false; });

        System.Console.WriteLine("Original array items:");
        Print(array);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Even array items:");
        Print(evenArray);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Not even array items:");
        Print(notEvenArray);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Has 3 array items:");
        Print(has3Array);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Has same number array items:");
        Print(hasSameNumberArray);
        System.Console.WriteLine("\n********************");



    }
}
//delegate int filter(int[] x);
//filter IsEven = new filter();


//static int GetFiltered(int[] x, filter a)
//{

//}
//static int IsEven(int[])
//{
//    return 2;
//}
