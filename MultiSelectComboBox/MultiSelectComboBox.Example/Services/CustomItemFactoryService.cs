using System.Globalization;
using Sdl.MultiSelectComboBox.API;
using Sdl.MultiSelectComboBox.Example.Models;

namespace Sdl.MultiSelectComboBox.Example.Services
{
    public sealed class CustomItemFactoryService : IItemFactoryService
    {
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
