using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MUMU
{
    class Program
    {
        /// <summary>
        /// With Out Linq 
        /// </summary>
        /// <param name="a"> arraly of int </param>
        /// <returns></returns>
        public static int Is_Stipped(int[] a)
        {
            int len = a.Length;
            for (int i = 0; i <len ; i++)
            {
                int countOfEachItem = 0;
                for (int j=0; j<len; j++)
                {
                    if(a[i] == a[j])
                        countOfEachItem++;
                }
                if (countOfEachItem < 3)
                    return 0;
               
                //is  array in  boundarie  
                if (i + 1 < len)
                {
                    //is not in descinding orders 
                    if (a[i + 1] < a[i])
                        return 0;
                }

            }
            return 1;
        }
        /// <summary>
        /// . A number is called digit-increasing if it is equal to n + nn + nnn + ... 
        /// for some digit n between 1 and 9. For example 24 is digit-increasing because it equals 2 + 22 (here n = 2)
        /// </summary>
        /// <param name="a"> arry of integars </param>
        /// <returns> 0 or 1</returns>
        public static int Is_digit_Increasing (int n)
        {
            int temp = n;
            int digitCount = 0;
            while(n >= 1)
            {
                temp = temp / 10;
                digitCount++;
            }
            for (int i = 1; i <= 9; i++)
            {
                int sum = 0;
                int digit = 0;

                for (int j = 1; j <= digitCount; j++)
                {
                    int ten = 1;
                    if (j > 1)
                        ten *= 10;
                    sum = sum * ten;
                    sum += i;

                    digit += sum;
                }

                if (digit == n) return 1;
            }
            return 0;
            

        }
        /// <summary>
        /// Define an array to be a Martian array if the number
        /// of 1s is greater than the number of 2s and no two adjacent elements are equal. Write a function named isMartian that returns 1 if its array argument is a Martian array, otherwise it returns 0.
        /// </summary>
        public static int IsMartin(int []a)
        {
            int i;int k = 1; int countOfOnes=0;int countOfTwos=0;int len = a.Length;
            if (a.Length == 0 || a == null)
                return 0;
            if (len ==1)
            {
                if (a[0] == 1)
                    return 1;
                else if (a[0] == 2)
                    return 0;
            }
            for (i = 0 ; i < a.Length; i++)
            {
                if(k<a.Length)
                if (a[i] == a[k] )
                    return 0;
                if (a[i] == 1)
                    countOfOnes++;
                if (a[i] == 2)
                    countOfTwos++;
                k++;

            }
            if (countOfOnes <= countOfTwos)
                return 0;

                return 1;
        }
        public static int  Is121Array(int []a)
        {
            int i = 0;
            int countOfOnes = 0;
            int countOfTwos = 0;

            //int countOfOnesInTheLast = 0;
            //Because the first element of the array is not a 1.
            if (a[i] != 1 && i == 0)
                return 0;
            //the last elemet not equal to 1
            if (a[a.Length - 1] != 1)
                return 0;
            for (i=0; i< a.Length; i++)
            {
                if (a[i] != 1 && a[i] != 2)
                    return 0;
                if (a[i] == 1)
                    countOfOnes++;
                if (a[i] == 2)
                    countOfTwos++;

            }
            if (countOfOnes % 2 != 0)
                return 0;
            if (countOfTwos == 0)
                return 0;
            return 1;
        }
        public static int Twin_Paired(int[]a)
        {
            int[] odd  = { };
             int [] even = { };
            if (a.Length == 0 || a == null || a.Length == 1)
                return 1;
            for ( int i=0; i<a.Length;i++)
            {
                for (int k = 1; k < a.Length; k++)
                {
                    if (a[i] % 2 == 0)
                    {
                        if(a[k]%2==0)
                        if (a[k] < a[i] && k>i)
                            return 0;
                    }
                    else
                    {
                        if (a[k] % 2 != 0)
                            if (a[k] < a[i] && k>i)
                                return 0;
                    }
                    
                }
            }
            return 1; 
        }
        public static int Is_Self_Refrential(int[] a , int len )
        {
            if (len == 0 || a == null)
                return 0;
            for (int i = 0; i < len; i++)
            {
                int count = 0;
                for (int k=0;k<len;k++)
                {
                    if (a[k] == i)
                        count++;
                }
                if (count != a[i])
                    return 0;
            }
            return 1;
            
        }
        /// <summary>
        ///  the weighted sum of an array to be 2 * the sum of the even valued elements + 3 
        ///  * the sum of the odd valued elements.
        ///  the function return the 2* the sum and 3* the even valued 
        /// </summary>
        public static int computeWeightedSum(int[]a)
        {
            int len = a.Length;
            int sumOfEven = 0;
            int sumOfOdd = 0;
            int Total = 0;
            if (a.Length == 0 || a == null)
                return Total;
            for(int i=0; i<len;i++)
            {
                //Sum Of Even numbers 
                if (a[i] % 2 == 0)
                {
                    sumOfEven += a[i];
                }
                else
                {
                    sumOfOdd += a[i];
                }
            }
            return (2 * sumOfEven + 3 * sumOfOdd);
        }
        public static int IsOnionArray(int[] a)
        {
            int k = 0;
            int j = a.Length-1;
            if (a.Length ==0)
                return 1;
            for( k=0; k<a.Length; k++, j--)
            {
                if (j != k)
                {
                    if (a[k] + a[j] > 10)
                        return 0;
                }
            }
            return 1;
        }


        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            // A = [1, 3, 6, 4, 1, 2];
            var list = A.ToList();
            var sortedlist = list.OrderBy(x => x).ToList();
            foreach (var item in sortedlist)
            {
                var nextItem = item + 1;
                var find = sortedlist.Find(x => x == nextItem);
                if (find <= 0)
                {
                  //  Console.WriteLine("the item which not founded " + nextItem);
                    if(nextItem > 0)
                       return nextItem;
                }
            }
            return 1;
            //int [] TestedArray = {1,2,8,9};
            //var testarray = TestedArray.ToList().OrderBy(x => x);
            //List<int> lst = A.OfType<int>().ToList();
            //var sortedlist = lst.OrderBy(x=>x);

        }



       

        /// <summary>
        ///  
        /// </summary>
        /// <param name="args"></param>
        public static string solution2(string S, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            StringBuilder sb = new StringBuilder(S);
            var round = 0;
            for (int i = 0; i < sb.Length -1; i++)
            {
                
                var currentChar = sb[i];
                
                var nextChar = sb[i + 1];
                var value = currentChar.CompareTo(nextChar);
                var temp = 'v';
                   
                if(value > 0) {
                    temp = nextChar;
                    nextChar = currentChar;
                    currentChar= temp;
                    
                    sb[i] =currentChar  ;
                    sb[i+1] = nextChar;

                    round++;
                    
                    
                }
                
                //do what you want here
            }
            if (round == K)
            {
                S = sb.ToString();
                return S;
            }
            else
                return solution2(sb.ToString(), round);
               // return S;
        }

        public static string Numbers(string[] A, string[] B, string P)
        {
            var numbersList = B.ToList();
            var namesList = A.ToList();
            var result = numbersList.Where(x=>x.Contains(P)).ToList();
            var returnname = "";
            if (result.Count() > 0 && result.Count() <2)
            {
                string item = result.FirstOrDefault();
                var found = numbersList.FindIndex(x=>x ==item);
                if (found != -1)
                    return namesList[found];
            }
            else if(result.Count()> 1)
            {
                var arraynumbersindex = new List<int>();
                var newResultArray = new List<string>();

                foreach (var item in result)
                {
                    var found = numbersList.FindIndex(x => x == item);
                    if (found != -1)
                       arraynumbersindex.Add(found);
                }
                foreach(var n in arraynumbersindex)
                {
                    newResultArray.Add(namesList[n]);
                }
                var name = newResultArray.OrderBy(x => x).FirstOrDefault();
                return name;

            }
            else
            {
                return "NO CONTACT";
            }
           
            
            
            return returnname;

        }
        public static string PhonePhrmat(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            sb.Replace(" ", "-");
            sb.Replace("-", "");
            s = sb.ToString().Trim();
            var length = s.Length;
           
            var number = Regex.Replace(s, ".{3}", "$0-");
            return number;

        }
        public static bool vaccation(int Y, string A, string B, string W)
        {
            var days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
           
            var monthlenth = new Dictionary<string, int>() {
            {"January", 31},
            {"February", 28},
            {"March", 31},
            {"April", 30},
            {"May", 31},
            {"June", 30},
            {"July", 31},
            {"August", 31},
            {"September", 30},

            {"October", 31},
            {"November", 30},
            {"December", 31},

            };
            var leapyearMonthlenth = new Dictionary<string, int>() {
            {"January", 31},
            {"February", 28},
            {"March", 31},
            {"April", 30},
            {"May", 31},
            {"June", 30},

            {"July", 31},
            {"August", 31},
            {"September", 30},

            {"October", 31},
            {"November", 30},
            {"December", 31},

            };
            bool isLeapYear = Y % 4 == 0;
            if (isLeapYear)
                monthlenth = leapyearMonthlenth;
            int startMonth = monthlenth[A] ;
            int endMonth = monthlenth[B];
            DateTime monthStart = new DateTime(Y, startMonth, 1);
            var firstmonday = Enumerable.Range(0, DateTime.DaysInMonth(Y, startMonth))
                .Select(day => monthStart.AddDays(day))
                .Where(date => date.DayOfWeek == DayOfWeek.Monday)
                .Select(date => date.Day).FirstOrDefault();
            var lastSunday = Enumerable.Range(0, DateTime.DaysInMonth(Y, startMonth))
                .Select(day => monthStart.AddDays(day))
                .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                .Select(date => date.Day) .LastOrDefault();
            var currentday = Enumerable.Range(0, DateTime.DaysInMonth(Y, startMonth))
                .Select(day => monthStart.AddDays(day))
                .Where(date => date.DayOfWeek.ToString() == W).FirstOrDefault();
            var startDay = 0;
            var endDay = 0;
            
            return true;

        }
        static void Main(string[] args)
        {
            string[] a = {"fady","mic","kero"};
            string[] b = { "01202", "01504", "01604" };
            string p = "015";
            Console.WriteLine(Numbers( a, b, p));
            Console.WriteLine(PhonePhrmat("00-44 48 5555 8361"));
            Console.WriteLine(vaccation(2014,"April","May", "Wednesday"));

            string p2 = "015";
            //  Console.WriteLine(solution2("decade", 4));
            //  Console.WriteLine(solution2("decade", 4));

            // Console.WriteLine( solution(a));
            //int[] b = { 1, 3, 5 };
            //int[] c = { 2, 4, 6 };
            //int[] d = { 1 };
            //int[] e = { 2 };
            //int[] f = { 0, 0, 0, 0, 0 };
            //int[] g = { 2, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1 };
            //int[] h = { 1, 1, 1, 2, 2, 2, 1, 1, 2, 2 };
            //int[] i= { 2, 2, 2 };




            //int result =   IsOnionArray(a);
            //int res2=   Is_Self_Refrential(b, b.Length);
            //Console.WriteLine(Is121Array(a).ToString() + a.ToString());
            //Console.WriteLine(Is121Array(b).ToString()+ b.ToString());
            //Console.WriteLine(Is121Array(c).ToString()+ c.ToString());
            //Console.WriteLine(Is121Array(d).ToString() + d.ToString());
            //Console.WriteLine(Is121Array(e).ToString() + e.ToString());
            //Console.WriteLine(Is121Array(f).ToString() + f.ToString());
            //Console.WriteLine(Is121Array(g).ToString() + g.ToString());
            //Console.WriteLine(Is121Array(h).ToString() + h.ToString());
            //Console.WriteLine(Is121Array(i).ToString() + a.ToString());

            //List<int[]> _list = new List<int[]>
            //{
            //     new  int [] {1, 1, 1, 5, 5, 5, 5, 8, 8, 8},
            //new  int [] {1, 1, 5, 5, 5, 5, 8, 8, 8}  ,
            //   new  int [] {5, 5, 5, 15} ,
            //   new  int [] {3, 3, 3, 2, 2, 2, 5, 5, 5} ,

            //   new  int [] {3, 3, 3, 2, 2, 2, 1, 1, 1},
            //  new  int [] {1, 1, 1} ,
            // new  int []  {1, 1, 1, 1, 1, 1, 1},
            // new  int []  {1},

            //};
            //foreach(var item in _list)
            //{
            //Console.WriteLine(Is_Stipped(item).ToString());
            //}
        }



    }
}
