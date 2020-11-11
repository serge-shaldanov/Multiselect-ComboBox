using Sdl.MultiSelectComboBox.Services;

namespace Sdl.MultiSelectComboBox.API
{
    public interface IItemFactoryService
    {
        bool CanCreate(SelectionContext context);

        object CreateNewItem(SelectionContext context);
    }
}
