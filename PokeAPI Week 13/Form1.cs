using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PokeAPI;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokeAPI_Week_13;
using System.Security.Cryptography.X509Certificates;

namespace PokeAPI_Week_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
      
        public async void GetSpecies()
        {   // function ties number that is inputted and fetches the information to send into the DisplayPokemonData() function.

            try
            {   // retrieves data from the API
                int speciesName = Convert.ToInt32(txbSpecies.Text);
                PokemonSpecies species = await DataFetcher.GetApiObject<PokemonSpecies>(speciesName);
                if (species != null)
                {
                    DisplayPokemonData(species);
                }
                else
                {
                    MessageBox.Show("Pokemon not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching Pokemon data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void DisplayPokemonData(PokemonSpecies species)
        {   // ties labels on the form to the data pulled from the PokemonAPI and shows it on the form screen.
            lblName.Text = species.Name;
            lblBaseHappiness.Text = species.BaseHappiness.ToString();
            lblCaptureRate.Text = species.CaptureRate.ToString();
            lblHabitat.Text = species.Habitat.Name;
            lblGrowthRate.Text = species.GrowthRate.Name;
            lblFormSwitching.Text = species.FormsAreSwitchable.ToString();
            lblIsLegendary.Text = species.IsLegendary.ToString();

            // Get flavor text (only English)
            string flavorText = "";
            foreach (var flavorEntry in species.FlavorTexts)
            {
                if (flavorEntry.Language.Name == "en")
                {
                    flavorText = flavorEntry.FlavorText;
                    break;
                }
            }
            lblFlavorText.Text = flavorText;
            // get egg group
            string eggGroup = species.EggGroups[0].Name;
            lblEggGroup.Text = eggGroup;
        }

        public async void MoreInformation()
         { // function allows for further information to be displayed to the user such as Hatch Counter and Is Baby information.
            try
            {
                // retrieves data from the API
                int speciesName = Convert.ToInt32(txbSpecies.Text);
                PokemonSpecies species = await DataFetcher.GetApiObject<PokemonSpecies>(speciesName);
                if (species != null)
                    MessageBox.Show($"Hatch Counter: {species.HatchCounter}\nIs Baby: {species.IsBaby}");
                else
                {
                    MessageBox.Show("Pokemon not found!");
                }
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Error fetching Pokemon data: " + ex.Message); 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   // calls the GetSpecies() function on the click of the button within the form.
            GetSpecies();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // calls the MoreInformation() function on the click of the button within the form.
            MoreInformation();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }

}



