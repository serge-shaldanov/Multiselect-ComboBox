using System;
using System.Windows.Input;

namespace Sdl.MultiSelectComboBox.Commands
{
    public sealed class AddNewItemCommand : ICommand
    {
        private readonly Themes.Generic.MultiSelectComboBox _control;

        public AddNewItemCommand(Themes.Generic.MultiSelectComboBox control)
        {
            _control = control;
        }

        public bool CanExecute(object parameter)
        {
            return _control.CanAddNewItem;
        }

        public void Execute(object parameter)
        {
            _control.AddNewSelectedItem();
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, System.EventArgs.Empty);
        }
    }
}