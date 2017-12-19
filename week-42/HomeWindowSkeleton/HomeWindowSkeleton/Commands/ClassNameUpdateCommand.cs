using HomeWindowSkeleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeWindowSkeleton.Commands
{
    internal class ClassNameUpdateCommand : ICommand
    {
        public ClassNameUpdateCommand(ClassNameViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return _ViewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }

        private ClassNameViewModel _ViewModel;

        public event EventHandler CanExecuteChanged { 
            add {CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
