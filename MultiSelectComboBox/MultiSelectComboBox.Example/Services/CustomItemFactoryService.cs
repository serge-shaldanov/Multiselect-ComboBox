using Sdl.MultiSelectComboBox.API;
using Sdl.MultiSelectComboBox.Example.Models;

namespace Sdl.MultiSelectComboBox.Example.Services
{
    public sealed class CustomItemFactoryService : IItemFactoryService
    {
        public bool CanCreate(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        public object CreateNewItem(string text)
        {
            return new LanguageItem
            {
                Name = text,
                Id = text
            };
        }
    }
}
