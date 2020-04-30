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

namespace Quantiti1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue<int> a = new Queue<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] arr = textbox.Text.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                a.Enqueue(Convert.ToInt32(arr[i]));
            }
            textbox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listbox.Items.Clear();
            foreach(var i in a)
            {
                listbox.Items.Add(i.ToString());
            }

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            listbox.Items.Clear();
            int n = Convert.ToInt32(textbox.Text);
            int count = 0;
            foreach(var i in a)
            {
                if(count==n)
                    listbox.Items.Add(i.ToString());

                count++;

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
            int n = Convert.ToInt32(textbox.Text);
            for (int i = 0; i < a.Count+1; i++)
            {
                if (i == n)
                {
                    if (a.Any())
                    {
                        a.Dequeue();
                        
                    }
                }
                else
                {
                    if (a.Any())
                    {
                        a.Enqueue(a.Peek());
                        a.Dequeue();
                    }
                }

            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            listbox.Items.Clear();
            if (a.Any())
            {
                listbox.Items.Add("not empty");
            }
            else
            {
                listbox.Items.Add("empty");
            }
        }
    }
    
}
