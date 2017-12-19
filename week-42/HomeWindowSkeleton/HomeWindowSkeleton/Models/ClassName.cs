
namespace HomeWindowSkeleton.Models
{
    using System;
    using System.ComponentModel;

    public class ClassName : INotifyPropertyChanged
    {
        public ClassName(string TheClassName)
        {
            Name = TheClassName;
        }

        //public enum MyClasses
        //{
        //    CSharp,
        //    Hardware,
        //    Java,
        //    JavaScript
 
        //};

        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
