using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _30ApP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class LanguageManager
    {
        public CultureInfo CurrentCulture { get; set; }

        public void ChangeLanguage(CultureInfo newCulture)
        {
            // Установка новой культуры приложения
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            // Обновление всех UI-элементов, например, перезагрузка окна
            // или обновление связанных данных с учетом новой культуры
        }
    }

    // Использование LanguageManager
    public partial class MainWindow : Window
    {
        private LanguageManager languageManager;
        bool cmdStatus;
        public MainWindow()
        {
            InitializeComponent();

            languageManager = new LanguageManager();
            languageManager.CurrentCulture = CultureInfo.GetCultureInfo("en-US"); // Установка базовой культуры

            // Загрузка строк на основе текущей культуры
            UpdateUI();
        }

        //private void ChangeLanguageButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Пример смены языка на русский
        //    languageManager.ChangeLanguage(CultureInfo.GetCultureInfo("ru-RU"));
        //    UpdateUI();
        //}

        private void UpdateUI()
        {

            label1.Text = Strings.Hello;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cmdStatus = false; 
            languageManager.ChangeLanguage(CultureInfo.GetCultureInfo("en-US"));
            UpdateUI();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
                
            languageManager.ChangeLanguage(CultureInfo.GetCultureInfo("ru-RU"));
            UpdateUI();
        }
    }
}
