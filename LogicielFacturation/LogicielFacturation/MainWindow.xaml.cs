using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace LogicielFacturation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        List<Client> Clients = new List<Client>();
        public MainWindow()
        {
            InitializeComponent();


           

            Clients.Add(new Client() { Id = 1, Nom = "De Libero" , Prénom = "Nicolas", Numéro = "0678695043", Adresse = "53 rue cours thomas"});
            Clients.Add(new Client() { Id = 2, Nom = "De Azevedo", Prénom = "Chloé", Numéro = "0678695043", Adresse = "53 rue cours thomas" });
            Clients.Add(new Client() { Id = 3, Nom = "Chanez", Prénom = "Louis", Numéro = "0678695043", Adresse = "53 rue cours thomas" });
            dg_client.ItemsSource = Clients;

        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            Clients.Add(new Client { Id = 1, Nom = tb_Nom.Text, Prénom = tb_Prenom.Text, Adresse = tb_Adresse.Text, Numéro = tb_Numero.Text });
            dg_client.Items.Refresh();
            tb_Prenom.Text = tb_Nom.Text = tb_Adresse.Text = tb_Numero.Text = "";
        }
    }
}
