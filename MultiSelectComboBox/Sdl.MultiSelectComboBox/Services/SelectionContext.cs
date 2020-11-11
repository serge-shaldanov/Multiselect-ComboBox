using System.Collections;

namespace Sdl.MultiSelectComboBox.Services
{
    public sealed class SelectionContext
    {
        public SelectionContext(string currentText, IList selectedItems)
        {
            CurrentText = currentText;
            SelectedItems = selectedItems;
        }

        public string CurrentText { get; }

        public IList SelectedItems { get; }
    }
}