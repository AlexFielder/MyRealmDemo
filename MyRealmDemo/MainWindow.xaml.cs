using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

namespace RealmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeRealm();
        }

        private void InitializeRealm()
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\RealmDesktop";
            bool isDatabaseInitialized = Directory.Exists(path);
            if (!isDatabaseInitialized)
            {
                Directory.CreateDirectory(path);
            }

            string file = $"{path}\\default.realm";

            RealmConfiguration config = new RealmConfiguration(file);
            realm = Realm.GetInstnace(config);
        }
    }
}
