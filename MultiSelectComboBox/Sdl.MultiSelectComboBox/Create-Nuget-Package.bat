@echo off

nuget pack Sdl.MultiSelectComboBox.nuspec -Version 1.0.1812 -properties Id=Sdl.MultiSelectComboBox.Net46;Title=Sdl.MultiSelectComboBox.Net46;Description="Fork of Sdl.MultiSelectComboBox with .Net 4.6 support. Removed item grouping feature as it is not supported in .Net 4.6. I also added the ability to create selection items on the fly (see EnableNewItemsCreation and ItemFactoryService) properties"