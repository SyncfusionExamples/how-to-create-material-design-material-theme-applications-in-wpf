using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialLight.WPF;
using System.Windows;
using System.Windows.Media;

namespace WPF_Material_Theme
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Customizing the MaterialLight theme settings
            MaterialLightThemeSettings materialLightThemeSettings = new MaterialLightThemeSettings();
            materialLightThemeSettings.PrimaryBackground = new SolidColorBrush(Colors.Red);
            materialLightThemeSettings.PrimaryForeground = new SolidColorBrush(Colors.Yellow);
            materialLightThemeSettings.BodyFontSize = 15;
            materialLightThemeSettings.HeaderFontSize = 18;
            materialLightThemeSettings.SubHeaderFontSize = 17;
            materialLightThemeSettings.TitleFontSize = 17;
            materialLightThemeSettings.SubTitleFontSize = 16;
            materialLightThemeSettings.FontFamily = new FontFamily("Callibri");

            //Register the customized MaterialLight theme
            SfSkinManager.RegisterThemeSettings("MaterialLight", materialLightThemeSettings);

            //Setting the customized MaterialLight theme to the Window
            SfSkinManager.SetTheme(this, new Theme("MaterialLight"));
            InitializeComponent();
        }
    }
}
