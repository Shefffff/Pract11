using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace RegexApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindButton1_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox1.Text;
            string pattern = "ab[a-z]*a";
            ShowResults(input, pattern);
        }

        private void FindButton2_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox2.Text;
            string pattern = "a[^a-zA-Z0-9]b";
            ShowResults(input, pattern);
        }

        private void ShowResults(string input, string pattern)
        {
            string result = "";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                result += match.Value + " ";
            }
            ResultTextBlock.Text = "Результат: " + result.Trim();
        }
    }
}