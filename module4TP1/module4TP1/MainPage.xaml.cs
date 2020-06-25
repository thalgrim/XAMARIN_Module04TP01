using module4TP1.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace module4TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITweeterService tweeterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
        }
        private void Connection_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Connection is clicked");
            String utilisateur = this.identifiant.Text;
            String mdp = this.motDePasse.Text;
            Boolean isMemorise = this.memorisation.IsToggled;
            this.errorMessage.IsVisible = false;
            if (String.IsNullOrEmpty(utilisateur) || utilisateur.Length<3) 
            {
                this.errorMessage.Text = "Identifiant avec au moins 3 caractères";
                this.errorMessage.IsVisible = true;
                return;
            }
            if (String.IsNullOrEmpty(mdp) || mdp.Length < 6)
            {
                this.errorMessage.Text = "Mot de passe avec au moins 6 caractères";
                this.errorMessage.IsVisible = true;
                return;
            }

            if (this.tweeterService.authenticate(utilisateur, mdp))
            {
                this.connexion.IsVisible = false;
                this.tweets.IsVisible = true;
            }
            else 
            {
                this.errorMessage.Text = "login/mot de passe incorrect";
                this.errorMessage.IsVisible = true;
                return;
            }

            if (Connectivity.NetworkAccess != NetworkAccess.Internet) 
            {
                this.errorMessage.Text = "Pas d'internet";
                this.errorMessage.IsVisible = true;
                return;
            }


            

        }
    }
}
