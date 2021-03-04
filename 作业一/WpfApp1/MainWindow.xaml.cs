using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;



namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static bool isNumber(string str)
        {
            bool isMatch = Regex.IsMatch(str, @"^\d+$"); // 判断字符串是否为数字 的正则表达式
            return isMatch;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            if (isNumber(n1) && isNumber(n2))
            {
                int int1 = int.Parse(n1);
                int int2 = int.Parse(n2);


                int int3 = int1 + int2;
                string ans = int3.ToString();
                answer.Text = ans;
            }
            else
                answer.Text = "字符错误!";
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            int int1 = int.Parse(n1);
            int int2 = int.Parse(n2);
            int int3 = int1 * int2;
            string ans = int3.ToString();
            answer.Text = ans;
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            int int1 = int.Parse(n1);
            int int2 = int.Parse(n2);
            int int3 = int1 - int2;
            string ans = int3.ToString();
            answer.Text = ans;
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            string ans;
            double int3 = 0;
            string n1 = num1.Text;
            string n2 = num2.Text;
            double int1 = double.Parse(n1);
            double int2 = double.Parse(n2);
            if (int2 == 0)
                ans = "wrong!";
            else
            {
                int3 = int1 / int2;
                ans = int3.ToString();
            }
                answer.Text = ans;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {   // int num;

            // if (!int.TryParse(Text1.Text.Trim(), out num))
            //{
            //  MessageBox.Show("请输入数字");
            //      }
          
            string n1 = num1.Text;
            string n2 = num2.Text;
            int int1, int2, int3 = 0;
            if (isNumber(n1) && isNumber(n2))
            {

                int1 = int.Parse(n1);
                int2 = int.Parse(n2);
                int3 = int1 + int2;
                string ans = int3.ToString();
                answer.Text = ans;
            }
            else
                answer.Text = "字符错误!";
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            
            string n1 = num1.Text;
            string n2 = num2.Text;
            int int1, int2, int3 = 0;

            if (isNumber(n1) && isNumber(n2))
            {
                int1 = int.Parse(n1);
                int2 = int.Parse(n2);
                int3 = int1 - int2;
                string ans = int3.ToString();
                answer.Text = ans;
            }
            else
                answer.Text = "字符错误!";
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
           
            string n1 = num1.Text;
            string n2 = num2.Text;
            int int1, int2 = 0;
            int int3;
            if (isNumber(n1) && isNumber(n2))
            {

                int1 = int.Parse(n1);
                int2 = int.Parse(n2);
                int3 = int1 * int2;
                string ans = int3.ToString();
                answer.Text = ans;
            }
            else
                answer.Text = "字符错误!";
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            
            string ans;
            double int3 = 0;
            string n1 = num1.Text;
            string n2 = num2.Text;
            double int1, int2 = 0;
            if (isNumber(n1) && isNumber(n2))
            {



                int1 = double.Parse(n1);
                int2 = double.Parse(n2);
                if (int2 == 0)
                    ans = "wrong!";
                else
                {
                    int3 = int1 / int2;
                    ans = int3.ToString();
                }
                answer.Text = ans;
            }
            else
                answer.Text = "字符错误";
        }
    }
}



