using System;

namespace homework_console
{
    class Program
    {   static bool isdigit(char arr) {
            if (arr >= '0' && arr <= '9')
                return true;
            else
                return false;

        }
        static int chartoint(char[] arr, int first, int last) {
            int index = last - first;
            int num = 0;
            for (int i = 0; i <= index; i++) {
                if (isdigit(arr[first + i]))
                {   
                    
                    num += ((int)(arr[first + i]) - (int)('0')) * (int)Math.Pow(10,index - i);
                }
                else
                {
                    Console.WriteLine("wrong!");
                    Environment.Exit(0);
                }
               

            }
           // Console.WriteLine("text num is :{0}", num);
            return num;
        }
        static int findcal(char[] arr,int length) {
            for (int i = 0; i < length; i++) {
                if (arr[i] == '+' || arr[i] == '-' || arr[i] == '*' || arr[i] == '/') {
                    return i;
                }
                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string num;
            Console.WriteLine("\t\t\t**this is a simple calculator**");
            Console.Write("please input equation:");
            num = Console.ReadLine();
            char[] getinput = num.ToCharArray();
            int length = getinput.Length;
            //num转char数组 getinput
            int cal = findcal(getinput,length);
            if (cal == -1) {
                Console.WriteLine("wrong！");
                Environment.Exit(0);

            }
            int num1 = chartoint(getinput, 0, cal - 1);
            int num2 = chartoint(getinput, cal + 1, length - 1);
            int num3 = 0;
            double num4 = 0;
            switch (getinput[cal])
            {
                case '+':
                    num3 = num1 + num2;
                    break;
                case '-':
                    num3 = num1 - num2;
                    break;
                case '*': 
                    num3 = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("wrong!");
                        Environment.Exit(0);
                    }
                    num4 = (double)num1 / (double)num2;
                    break;
                default:
                    Console.WriteLine("wrong!");
                    Environment.Exit(0);
                    break;
            }
            if (getinput[cal] != '/')
                Console.WriteLine("answer is {0}", num3);
            else
                Console.WriteLine("answer is {0}",num4);
            
 
            
        }
    }
}
