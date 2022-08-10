using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace WinStarDate
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calcola_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(data.Date.Date.ToUniversalTime().ToString("dd")) + 1;
            String s = "" + i;
            if (s.Length == 1)
                s = "0" + s;
            risultato.Text = data.Date.Date.ToUniversalTime().ToString("yy") + data.Date.Date.ToUniversalTime().ToString("MM") + "." + s;
        }
    }
}
