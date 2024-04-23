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
        {
            try
            {
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

        private void DisplayPokemonData(PokemonSpecies species)
        {
            lblName.Text = species.Name;
            lblBaseHappiness.Text = species.BaseHappiness.ToString();
            lblCaptureRate.Text = species.CaptureRate.ToString();
            lblHabitat.Text = species.Habitat.Name;
            lblGrowthRate.Text = species.GrowthRate.Name;

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

            // Get first egg group
            string eggGroup = species.EggGroups[0].Name;
            lblEggGroup.Text = eggGroup;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetSpecies();
        }
    }

}
 