namespace Assignment1
{
    /// <summary>
    /// GUI things are determined here
    /// </summary>
    public partial class Zoo : Form
    {
        public Zoo()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// GUI intiialization 
        /// </summary>
        private void InitializeGUI(){
            string[] genderArray = { "male", "female", "other" };
            string[] speciesArray = { "mammal", "reptile" };
            //string[] mammalArray = { "" }
            genderlistbox.DataSource = genderArray;
            specieslistbox.DataSource= speciesArray;
        }

        /// <summary>
        /// If the user clicks on the species the animals of that species are displayed in the animals box
        /// </summary>
        private void specieslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //the animals of the species are added here dependent on the selected index
            if(specieslistbox.SelectedIndex == 0)
            {
                string[] mammalsAnimalArray = { "Asiatic lion", "Gorilla" };
                animallistbox.DataSource = mammalsAnimalArray;
            }
            else if(specieslistbox.SelectedIndex == 1)
            {
                string[] reptilesAnimalArray = { "Gharial", "Gila Monster" };
                animallistbox.DataSource = reptilesAnimalArray;
            }
        }
    }
}