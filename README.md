# How to create material design (material theme) applications in WPF?

Syncfusion provides [material theme](https://help.syncfusion.com/wpf/themes/skin-manager#themes-list) that can be applied to WPF applications (.NET Core and also .NET Framework) using the [skin manager](https://help.syncfusion.com/wpf/themes/skin-manager) to create material design applications. Also, skin manager allows to custom the primary colors, typography in few lines of code for an application or control. In addition, [WPF Theme Studio](https://help.syncfusion.com/wpf/themes/theme-studio) can be used to create custom themes based on material design. Below are the list of four material theme variants supported for WPF.
1.	Material Light Theme - [NuGet](https://www.nuget.org/packages/Syncfusion.Themes.MaterialLight.WPF/)
2.	Material Dark Theme - [NuGet](https://www.nuget.org/packages/Syncfusion.Themes.MaterialDark.WPF/)
3.	Material Light Blue Theme - [NuGet](https://www.nuget.org/packages/Syncfusion.Themes.MaterialLightBlue.WPF/)
4.	Material Dark Blue Theme - [NuGet](https://www.nuget.org/packages/Syncfusion.Themes.MaterialDarkBlue.WPF/)

## Add Material Light Theme and Skin Manager NuGet packages
Add the following NuGet packages to WPF application.
*	[Syncfusion.Shared.WPF](https://www.nuget.org/packages/Syncfusion.Shared.WPF/)
*	[Syncfusion.SfSkinManager.WPF](https://www.nuget.org/packages/Syncfusion.SfSkinManager.WPF/)
*	[Syncfusion.Themes.MaterialLight.WPF](https://www.nuget.org/packages/Syncfusion.Themes.MaterialLight.WPF/)

If you want to apply other material theme variants also by referring corresponding [NuGet](https://www.nuget.org/packages?q=syncfusion+wpf+material+theme). 

## Applying Material Light Theme to WPF application
Themes will be applied to both Syncfusion and framework controls by using the Theme attached property of the SfSkinManager. When a theme is applied to a Window or any element, skin manager inherits the same theme to all its descendants.
Code [XAML]:

```
<Window x:Class="WPF_Material_Theme.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
        Title="Credit Card Payment" 
        xmlns:syncfusionskin ="clr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPF"
        syncfusionskin:SfSkinManager.Theme="{syncfusionskin:SkinManagerExtension ThemeName=MaterialLight}">
</Window>
```
