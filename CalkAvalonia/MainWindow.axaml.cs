using Avalonia.Controls;
using System.Net.NetworkInformation;
using System;

namespace CalkAvalonia
{
    public partial class MainWindow : Window
    {
        string numb;
        double choc;
        double choc2;

        public MainWindow()
        {
            InitializeComponent();

            /*Инициализация кнопок  методов для них
            Обращение с помощью имени созданной кнопки
            Методы для кнопок ксати сами созддавались когда я прописывал кнопки
            */
            zero.Click += Zero_Click;
            one.Click += One_Click;
            two.Click += Two_Click;
            three.Click += Three_Click;
            four.Click += Four_Click;
            five.Click += Five_Click;
            six.Click += Six_Click;
            seven.Click += Seven_Click;
            eight.Click += Eight_Click;
            nine.Click += Nine_Click;

            SineButton.Click += SineButton_Click;
            SquareButton.Click += SquareButton_Click;
            FactorialButton.Click += FactorialButton_Click;
            CosineButton.Click += CosineButton_Click;
            DmsButton.Click += DmsButton_Click;
            TangentButton.Click += TangentButton_Click;
            NaturalLogButton.Click += NaturalLogButton_Click;
            OpenParenthesisButton.Click += OpenParenthesisButton_Click;
            CloseParenthesisButton.Click += CloseParenthesisButton_Click;
            ExponentButton.Click += ExponentButton_Click;
            PiButton.Click += PiButton_Click;
            CubeButton.Click += CubeButton_Click;
            PowerButton.Click += PowerButton_Click;
            SquareButton.Click += SquareButton_Click1;
            CubedButton.Click += CubedButton_Click;
            PiButton2.Click += PiButton2_Click;
            Log.Click += Log_Click;

            BackspaceButton.Click += BackspaceButton_Click;
            ClearEntryButton.Click += ClearEntryButton_Click;
            ClearButton.Click += ClearButton_Click;
            Ravno.Click += Ravno_Click;
            RootButton.Click += RootButton_Click;
            DivideButton.Click += DivideButton_Click;
            MultiplyButton.Click += MultiplyButton_Click;
            PercentButton.Click += PercentButton_Click;
            ReciprocalButton.Click += ReciprocalButton_Click;
            Minus.Click += Minus_Click;
            DecimalButton.Click += DecimalButton_Click;
            Plus.Click += Plus_Click;
            MemoryRecallButton.Click += MemoryRecallButton_Click;
            MemorySaveButton.Click += MemorySaveButton_Click;
            MemorySubtractButton.Click += MemorySubtractButton_Click;
            MemoryAddButton.Click += MemoryAddButton_Click;
            NegateButton.Click += NegateButton_Click;
            MemoryClearButton.Click += MemoryClearButton_Click;
            

        }

       

        private void Plus_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)//Минус 
        {
            numb = "+";

            choc = Convert.ToDouble(TextBox.Text);
            string number = "";
            TextBox.Text = number;
        }

        private void Minus_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)//Плюс
        {
            numb = "-";
            choc = Convert.ToDouble(TextBox.Text);
            string number = "";
            TextBox.Text = number;
        }

        private void MemoryClearButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
           
        }

        private void NegateButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MemoryAddButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MemorySubtractButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MemorySaveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MemoryRecallButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

       
        

        private void DecimalButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // запятая 
        {
            if ((TextBox.Text.IndexOf(",") == -1) && (TextBox.Text.IndexOf(" ") == -1))
                TextBox.Text += ",";
                
        }

      

        private void ReciprocalButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PercentButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void RootButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void ClearButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // C

        {   //Подсмотрел на гит но чет фигня какаято
             choc = choc2 = 0.0d;
            string numebr = "";
            TextBox.Text = numebr;
        }

        private void ClearEntryButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // CE
        {
            string number = "";
            TextBox.Text = number;
        }

        private void BackspaceButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) //?
        {    // удаление последнего символа из Text.box
            if(!string.IsNullOrEmpty(TextBox.Text)) 
            {
              TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            
            }
        }





        // Ниже Алгелебра там и Тригонометрия и т.п

        void Ravno_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (numb == "+") //сложение 
            {
                choc2 = Convert.ToDouble(TextBox.Text);
                double number1 = Convert.ToDouble(choc);
                double number2 = Convert.ToDouble(choc2);
                double answer = Convert.ToDouble(number1 + number2);
                choc = answer;
                TextBox.Text = Convert.ToString(choc);
            }
            else if (numb == "10x")
            {
                double number1 = Convert.ToDouble(choc);
                double number2 = 10;
                double number = Convert.ToDouble(Math.Pow(number2, number1));
                TextBox.Text = $"{number}";
            }
            else if (numb == "-") // вычетание 
            {
                choc2 = Convert.ToDouble(TextBox.Text);
                double number1 = Convert.ToDouble(choc);
                double number2 = Convert.ToDouble(choc2);
                double answer = Convert.ToDouble(number1 - number2);
                choc = answer;
                TextBox.Text = Convert.ToString(choc);

            }
            else if (numb == "*") // умножение 
            {
                choc2 += Convert.ToDouble(TextBox.Text);
                double number1 = Convert.ToDouble(choc);
                double number2 = Convert.ToDouble(choc2);
                double result = Convert.ToDouble(number1 * number2);
                choc = result;
                TextBox.Text = $"{choc}";

            }
            else if (numb == "/") // деление 
            {
                choc2 += Convert.ToDouble(TextBox.Text);
                double number1 = Convert.ToDouble(choc);
                double number2 = Convert.ToDouble(choc2);
                double result = Convert.ToDouble(number1 / number2);
                choc = result;
                TextBox.Text = $"{choc}";


            }


        }




        private void MultiplyButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // умножение 
        {
            numb = "*";
            choc = Convert.ToDouble(TextBox.Text);
            string numebr = "";
            TextBox.Text = numebr;
        }

        private void DivideButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // деление
        {
            numb = "/";
            choc = Convert.ToDouble(TextBox.Text);
            string number = "";
            TextBox.Text = number;
        }


        private void PiButton2_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CubedButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SquareButton_Click1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PowerButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CubeButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)// Возведение в Куб
        {
            double NumberOne = Convert.ToDouble(TextBox.Text);
            double NumberTwo = 10;
            double Number = Convert.ToDouble(Math.Pow(NumberTwo, NumberOne));
            TextBox.Text = $"{Number}";

        }

        private void PiButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // число Pi
        {
            string Pi = "3,1415926535897932384626433832795";
            double result = Convert.ToDouble(Pi);
            TextBox.Text = $"{result}";
        }

        private void ExponentButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)// Возводит число в указанную степень 
        {
            double NumberOne = Convert.ToDouble(TextBox.Text);
            double NumberTwo = 10;
            double Number = Convert.ToDouble(Math.Pow(NumberTwo, NumberOne));
            TextBox.Text = $"{Number}";
        }

        private void CloseParenthesisButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // Скобка закрывается
        {
            string number = ")";
            TextBox.Text += number;
        }

        private void OpenParenthesisButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // скобка открывается 
        {
            string number = "(";
            TextBox.Text += number;
        }

        private void NaturalLogButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)//Возвращает логарифм с основанием 10 указанного числа.
        {
            double number1 = Convert.ToDouble(TextBox.Text);
            double number = Math.Log10(number1);
            TextBox.Text = Convert.ToString(number);

        }
        private void Log_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)//Возвращает натуральный логарифм (с основанием e) указанного числа.
        {
            double number1 = Convert.ToDouble(TextBox.Text);
            double number = Math.Log(number1);
            TextBox.Text = Convert.ToString(number);
        }



        private void TangentButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) //Возвращает тангенс указанного угла.
        {
            double number1 = Convert.ToDouble(TextBox.Text);
            double number = Math.Tan(number1);
            TextBox.Text = Convert.ToString(number);
        }

        private void DmsButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CosineButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) //Возвращает косинус указанного угла
        {
            double number1 = Convert.ToDouble(TextBox.Text);
            double number = Math.Cos(number1);
            TextBox.Text = Convert.ToString(number); ;
        }

        private void FactorialButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SquareButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // Возведение в 2-ю степень 
        {

            // Почему-то не работает, а должно
           double number1 = Convert.ToDouble(TextBox.Text);
            double number = number1 * number1;
            double result = Convert.ToDouble(number);
            TextBox.Text = $"{result}";
        }

        private void SineButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) // Возвращает синус указанного угла. 


        {
            double number1 = Convert.ToDouble(TextBox.Text);
            double number = Math.Sin(number1);
            TextBox.Text = Convert.ToString(number);
        }




        // Ниже цифарки 






        private void Nine_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "9";
            TextBox.Text += number;
        }

        private void Eight_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "8";
            TextBox.Text += number;
        }

        private void Seven_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "7";
            TextBox.Text += number;
        }

        private void Six_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "6";
            TextBox.Text += number;
        }

        private void Five_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "5";
            TextBox.Text += number;
        }

        private void Four_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "4";
            TextBox.Text += number;
        }

        private void Three_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "3";
            TextBox.Text += number;
        }

        private void Two_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "2";
            TextBox.Text += number;
        }

        private void One_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "1";
            TextBox.Text += number;
        }

        private void Zero_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "0";
            TextBox.Text += number;
        }
    }
}