using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;


namespace WpfLibraryTry
{
    public class ClassMyTry:INotifyPropertyChanged
    {
        private int _count;

        private int _factor=1;

        private string _name;


        /*  public List<ClassMyTry> people = new List<ClassMyTry>()
          {
              new ClassMyTry{Counter=9999, BestName="Winner1"},
              new ClassMyTry{Counter=333, BestName="Winner2"},
              new ClassMyTry{Counter=111, BestName="W3"}
          };
        */
               
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        public int Factor
        {
            get
            {
                return _factor;
            }
            set
            {
                _factor = value;
                OnPropertyChanged("Factor");
            }
        }
        public int Counter
        {
            get => _count;
            
            set
            {
                _count = value;
                OnPropertyChanged("Counter");
            }
        }

        public string BestName 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("BestName");
            }
        }

       
        public int BestCounter
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("BestCounter");
            }
        }
        public int SecondCounter
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("SecondCounter");
            }
        }
        public int ThirdCounter
    {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("ThirdCounter");
            }
        }
        public int FourthCounter
    {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("FourthCounter");
            }
        }
    }
}
