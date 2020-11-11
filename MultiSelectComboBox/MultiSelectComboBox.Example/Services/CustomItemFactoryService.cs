using Sdl.MultiSelectComboBox.API;
using Sdl.MultiSelectComboBox.Example.Models;
using Sdl.MultiSelectComboBox.Services;

namespace Sdl.MultiSelectComboBox.Example.Services
{
    public sealed class CustomItemFactoryService : IItemFactoryService
    {
        public bool CanCreate(SelectionContext context)
        {
            if (string.IsNullOrWhiteSpace(context.CurrentText))
            {
                return false;
            }

            foreach (object selectedItem in context.SelectedItems)
            {
                LanguageItem item = selectedItem as LanguageItem;

                if (item is null)
                {
                    continue;
                }

                if (item.Id == context.CurrentText || item.Name == context.CurrentText)
                {
                    return false;
                }
            }

            return true;
        }

        public object CreateNewItem(SelectionContext context)
        {
            return new LanguageItem
            {
                Name = context.CurrentText,
                Id = context.CurrentText
            };
        }
    }
}
