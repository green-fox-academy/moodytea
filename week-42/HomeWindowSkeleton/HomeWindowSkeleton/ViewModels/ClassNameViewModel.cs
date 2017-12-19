using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWindowSkeleton.Models;
using System.Diagnostics;
using System.Windows.Input;
using HomeWindowSkeleton.Commands;

namespace HomeWindowSkeleton.Models
{
    internal class ClassNameViewModel
    {
        public ClassNameViewModel()
        {
            _ClassName = new ClassName("TheSharpestC");
            UpdateCommand = new ClassNameUpdateCommand(this);
        }

        private ClassName _ClassName;

        public ClassName ClassName
        {
            get
            {
                return _ClassName;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;

        }
        public bool CanUpdate
        {
            get
            {
                if (ClassName == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(ClassName.Name);
            }
        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", ClassName));
        }
    }
}
