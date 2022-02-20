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
using System.Collections.ObjectModel;




namespace WpfLibraryTry
{

   
    public class EmployeeList
    {       
        public List<Best> List { get; set; } = new List<Best>();

    }

   
    public class Best 
    {
        public string Name { get; set; }
        public int Counter { get; set; }

        //public List<Best> best; 
    }



    public class View
    {
     
        public EmployeeList EmployeeList { get; set; }
        public View()
        {

           List<Best> bestList = new List<Best>();
           Person person = new Person();
           
           
            EmployeeList = new EmployeeList()
            {
                List = { person.best }
            };
            
            

        }

    }
}

