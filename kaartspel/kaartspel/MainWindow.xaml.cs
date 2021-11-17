using System;
using System.Collections.Generic;
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


namespace kaartspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bewerkingen b = new Bewerkingen();
        int EindeSpel1 = 0;
        int EindeSpel2 = 0;
        Speler s1 = new Speler(100, "Speler 1");
        Speler s2 = new Speler(100, "Speler 2");

        public MainWindow()
        {
            InitializeComponent();

            gewonnen1.Visibility = Visibility.Hidden;
            gewonnen2.Visibility = Visibility.Hidden;
            reset.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (EindeSpel1 == 0 && EindeSpel2 == 0)
            {
                gewonnen1.Visibility = Visibility.Hidden;
                gewonnen2.Visibility = Visibility.Hidden;

                kaart1.Visibility = Visibility.Visible;
                kaart2.Visibility = Visibility.Visible;
                score1.Visibility = Visibility.Visible;
                score2.Visibility = Visibility.Visible;
                play.Visibility = Visibility.Visible;
                Speler1.Visibility = Visibility.Visible;
                Speler2.Visibility = Visibility.Visible;
                titel.Visibility = Visibility.Visible;

                s1.kaart.trekKaart();
                kaart1.Source = new BitmapImage(new Uri(s1.kaart.arrayPicture[s1.kaart.Soort - 1, s1.kaart.Waarde - 1], UriKind.Relative));


                s2.kaart.trekKaart();
                s2.kaart.trekKaart();
                kaart2.Source = new BitmapImage(new Uri(s2.kaart.arrayPicture[s2.kaart.Soort - 1, s2.kaart.Waarde - 1], UriKind.Relative));

                b.VergelijkenNummer(s1, s2);

                EindeSpel1 = b.Einde(s1);
                EindeSpel2 = b.Einde(s2);

                score1.Text = s1.ToString();
                score2.Text = s2.ToString();
            }

            if(EindeSpel1 != 0 || EindeSpel2 != 0)
            {
                kaart1.Visibility = Visibility.Hidden;
                kaart2.Visibility = Visibility.Hidden;
                score1.Visibility = Visibility.Hidden;
                score2.Visibility = Visibility.Hidden;
                play.Visibility = Visibility.Hidden;
                Speler1.Visibility = Visibility.Hidden;
                Speler2.Visibility = Visibility.Hidden;
                titel.Visibility = Visibility.Hidden;

              
                if (EindeSpel1 == 1)
                {
                    gewonnen1.Visibility = Visibility.Visible;
                    reset.Visibility = Visibility.Visible;
                }
                if (EindeSpel2 == 1)
                {
                    gewonnen2.Visibility = Visibility.Visible;
                    reset.Visibility = Visibility.Visible;
                }
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            s1.reset();
            s2.reset();
            score1.Text = s1.ToString();
            score2.Text = s2.ToString();
            EindeSpel1 = 0;
            EindeSpel2 = 0;

            kaart1.Visibility = Visibility.Visible;
            kaart2.Visibility = Visibility.Visible;
            score1.Visibility = Visibility.Visible;
            score2.Visibility = Visibility.Visible;
            play.Visibility = Visibility.Visible;
            Speler1.Visibility = Visibility.Visible;
            Speler2.Visibility = Visibility.Visible;
            titel.Visibility = Visibility.Visible;

            gewonnen1.Visibility = Visibility.Hidden;
            gewonnen2.Visibility = Visibility.Hidden;
            reset.Visibility = Visibility.Hidden;
        }
    }
}
