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
using WpfLibraryTry;
using System.Collections.ObjectModel;



namespace WpfMyTry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        ClassMyTry ClassMyIdontknow = new ClassMyTry { Counter = 0, Factor = 1 };
        // public Employee best = new Employee { Name = "...", Counter = 0 };
        
        public int fuckThis = 112323123;
        public string fuckName = "Fucker";
        List<Best> best = new List<Best>();
        

        Person person = new Person { };
        public string name;
        public MainWindow()
        {
            InitializeComponent();            
            this.DataContext = new View();

           /* Binding binding = new Binding();

            binding.ElementName = Convert.ToString(ClassMyIdontknow.Counter); // элемент-источник
            binding.Path = new PropertyPath("Text"); // свойство элемента-источника
            MyVisualBlock.SetBinding(TextBlock.TextProperty, binding);
           */
        }

        public void EndGame(object sender, RoutedEventArgs e)
        {

            person.Name = name;
            person.RecordCounter = ClassMyIdontknow.Counter;
            if (name == "")
            {
                Name = "Unnamed";
            }            
            MessageBox.Show(person.Name + "    "+ person.RecordCounter);

            //person.best=(Name=name, Counter =7373737);// ШО ЦЕ за хуйня

            
           


          //  ClassMyIdontknow.BestCounter = person.RecordCounter;
          //  ClassMyIdontknow.BestName = person.Name;
        }

        private void LeftMouseRseset(object sender, RoutedEventArgs e)
        {
            ClassMyIdontknow.Counter = default;
            ClassMyIdontknow.Factor=1;
            MyVisualBlock.Text = Convert.ToString(ClassMyIdontknow.Counter);
            
        }
        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {            
            ComboBox comboBox = (ComboBox)sender;
            
            ClassMyIdontknow.Factor = Convert.ToInt32((string)comboBox.SelectedValue);
            
        }
        private void LeftMouse(object sender, RoutedEventArgs e)
        {
            ClassMyIdontknow.Counter += ClassMyIdontknow.Factor;

            //int temp = ClassMyIdontknow.Counter;
            MyVisualBlock.Text = Convert.ToString(ClassMyIdontknow.Counter);

            //int temp = ClassMyIdontk

           // ClassForRating.ReSortRating(ClassMyIdontknow.Counter, ClassForRating.Index);
        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            name = textBox1.Text;
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

       /* public class View
        {
            // public Employee best = new Employee {Name = fuckName, Counter = fuckThis };
            /*public Employee second = new Employee { };
            public Employee Third = new Employee { };***


            public EmployeeList EmployeeList { get; set; }
            public View()
            {
                int Counter = 111111111;
                

                EmployeeList = new EmployeeList()
                {
                    List = { best, new Employee("Alex", Counter) }
                };

            }*/

        }








    }

