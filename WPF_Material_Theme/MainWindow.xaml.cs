using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using System.Windows;
using System.Windows.Media;

namespace WPF_Material_Theme
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Customizing the MaterialDark theme settings
            MaterialDarkThemeSettings materialDarkThemeSettings = new MaterialDarkThemeSettings();
            materialDarkThemeSettings.PrimaryBackground = new SolidColorBrush(Colors.Red);
            materialDarkThemeSettings.PrimaryForeground = new SolidColorBrush(Colors.Yellow);
            materialDarkThemeSettings.BodyFontSize = 15;
            materialDarkThemeSettings.HeaderFontSize = 18;
            materialDarkThemeSettings.SubHeaderFontSize = 17;
            materialDarkThemeSettings.TitleFontSize = 17;
            materialDarkThemeSettings.SubTitleFontSize = 16;
            materialDarkThemeSettings.FontFamily = new FontFamily("Callibri");

            //Register the customized MaterialDark theme
            SfSkinManager.RegisterThemeSettings("MaterialDark", materialDarkThemeSettings);

            //Setting the customized MaterialDark theme to the Window
            SfSkinManager.SetTheme(this, new Theme("MaterialDark"));
            InitializeComponent();
        }
    }
}
