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

namespace WpfLibraryTry
{

    public class Person
    {
        public string Name { get; set; }

        public int RecordCounter { get; set; }

        private static int _counter;

        private static string _name="";

        //private List<Best> _best = new List<Best>() { new Best { Name = "fuck", Counter = 12123 } };// Вариант с созданием Листа



        private Best _best = new Best { Name = _name, Counter = _counter };

      //  private Best _best = new Best { Name = "Unnamed", Counter = 0 };  1 works
        

        public Best best
        {
            get 
            {
                return _best;
            }
            set
            {

                this._best.Name = _name;



                this._best.Counter = _counter;

            }
        }


    }
}
