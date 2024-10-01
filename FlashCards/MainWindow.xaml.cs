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

namespace FlashCards
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index;
        int previousIndex = -1;
        Random random = new Random();


        public class FlashCard
        {
            public string Question { get; set; }
            public string Answer { get; set; }
        }

        private List<FlashCard> flashCards;

        private void LoadFlashCards()
        {
            flashCards = new List<FlashCard>
            {
                new FlashCard { Question = "What does HTML stand for?", Answer = "HyperText Markup Language" },
                new FlashCard { Question = "What is the main purpose of CSS?", Answer = "To style web pages" },
                new FlashCard { Question = "What does SQL stand for?", Answer = "Structured Query Language" },
                new FlashCard { Question = "What is a variable?", Answer = "A storage location paired with a name" },
                new FlashCard { Question = "What is the purpose of a function?", Answer = "To encapsulate reusable code" },
                new FlashCard { Question = "What does OOP stand for?", Answer = "Object-Oriented Programming" },
                new FlashCard { Question = "What is a loop?", Answer = "A sequence of instructions that repeats" },
                new FlashCard { Question = "What is an API?", Answer = "Application Programming Interface" },
                new FlashCard { Question = "What does IDE stand for?", Answer = "Integrated Development Environment" },
                new FlashCard { Question = "What is the difference between == and === in JavaScript?", Answer = "== checks value, === checks value and type" },
                new FlashCard { Question = "What is a bug in programming?", Answer = "An error or flaw in code" },
                new FlashCard { Question = "What does Git do?", Answer = "Version control for tracking changes" },
                new FlashCard { Question = "What is a class in programming?", Answer = "A blueprint for creating objects" },
                new FlashCard { Question = "What is recursion?", Answer = "A function that calls itself" },
                new FlashCard { Question = "What is a database?", Answer = "A structured set of data" },
                new FlashCard { Question = "What language is primarily used for web development?", Answer = "JavaScript" },
                new FlashCard { Question = "What is the purpose of a compiler?", Answer = "To convert source code into executable code" },
                new FlashCard { Question = "What is syntax in programming?", Answer = "The set of rules that defines combinations of symbols" },
                new FlashCard { Question = "What is debugging?", Answer = "The process of finding and fixing bugs" },
                new FlashCard { Question = "What is a framework?", Answer = "A pre-built structure to facilitate development" }
            };
        }
        public MainWindow()
        {
            InitializeComponent();
            LoadFlashCards();
            ShowQuestion();
        }

        public void ShowQuestion()
        {
            do
            {
                index = random.Next(flashCards.Count);
            } while (index == previousIndex);

            previousIndex = index;
            FlashcardQuestion.Text = flashCards[index].Question;
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            FlashcardAnswer.Text = flashCards[index].Answer;
            FlashcardAnswer.BorderBrush = Brushes.Gray;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            ShowQuestion();
            FlashcardAnswer.Text = "";
            FlashcardAnswer.BorderBrush = Brushes.Gray;
        }

        private void CheckTheAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (FlashcardAnswer.Text.ToLower() == flashCards[index].Answer.ToLower())
            {
                FlashcardAnswer.BorderBrush = Brushes.Green;
            }
            else
            {
                FlashcardAnswer.BorderBrush = Brushes.Red;
            }
        }
    }
}
