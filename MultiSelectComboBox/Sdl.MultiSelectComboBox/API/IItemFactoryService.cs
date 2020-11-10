namespace Sdl.MultiSelectComboBox.API
{
    public interface IItemFactoryService
    {
        bool CanCreate(string text);

        object CreateNewItem(string text);
    }
}
