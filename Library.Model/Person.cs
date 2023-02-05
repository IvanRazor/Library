using System.ComponentModel;

namespace Library.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string secondName;

        public string FirstName {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string SecondName {
            get => secondName;
            set
            {
                secondName = value;
                OnPropertyChanged("SecondName");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
