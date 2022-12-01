using ClientApp.RestClientLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.ModelLayer;
using System.Diagnostics;

namespace ClientApp.UILayer
{
    public partial class MainForm : Form
    {
        private ApiDeveloperDataAccess developerApi;
        private ApiGameDataAccess gameApi;
        public MainForm()
        {
            InitializeComponent();
            developerApi = new ApiDeveloperDataAccess("https://localhost:7023/api/v1/Developer");
            gameApi = new ApiGameDataAccess("https://localhost:7023/api/v1/Game");
            GetAllDevsFromApi();
            ClearDeveloperInputFields();
            panelCreateDeveloper.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteDeveloper_Click(object sender, EventArgs e)
        {
            DeleteDeveloper();
            ClearDeveloperInputFields();
            ShowAllDeveloper();
        }

        private void buttonUpdateDeveloper_Click(object sender, EventArgs e)
        {
            if (CheckInputFieldsForUpdate() == true)
            {
                UpdateDeveloper();
                ClearDeveloperInputFields();
                ShowAllDeveloper();
            }
            else
            {
                //error handling +
                ClearDeveloperInputFields();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowAllDeveloper_Click(object sender, EventArgs e)
        {
            ShowAllDeveloper();
            ClearDeveloperInputFields();
        }

        private void buttonSearchDeveloperByID_Click(object sender, EventArgs e)
        {
            ClearDeveloperInputFields();
            ChangeListToShowOnlyDeveloperBySearch();
            textBoxSearchDeveloper.Clear();
        }

        private void listBoxDeveloperList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDeveloperInputFields();

            Developer developerToShow = GetSelectedDeveloperObjectFromList();

            SetDeveloperInputFields(developerToShow);

            ShowAllGamesForDeveloper();


        }
        #region Developer Page Methods

        public void CreateNewDeveloper()
        {
            Developer dev = new Developer();
            dev.Name = textBoxCreateDeveloperName.Text;
            dev.Email = textBoxCreateDeveloperEmail.Text;
            dev.Description = textBoxCreateDeveloperDescription.Text;
            developerApi.CreateDeveloper(dev);
        }

        public void ClearCreateDeveloperFormFields()
        {
            textBoxCreateDeveloperName.Clear();
            textBoxCreateDeveloperEmail.Clear();
            textBoxCreateDeveloperDescription.Clear();
        }

        public bool CheckInputFieldsForCreate()
        {
            if (textBoxCreateDeveloperName.Text.Length > 0 && textBoxCreateDeveloperEmail.Text.Length > 0 && textBoxCreateDeveloperDescription.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckInputFieldsForUpdate()
        {
            if (textBoxDeveloperName.Text.Length > 0 && textBoxEmail.Text.Length > 0 && textBoxDeveloperDescription.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        public void ChangeListToShowOnlyDeveloperBySearch()
        {
            Developer d = new Developer();
            try
            {
                d = developerApi.FindDeveloperFromId(int.Parse(textBoxSearchDeveloper.Text));
                listBoxDeveloperList.Items.Clear();
                listBoxDeveloperList.Items.Add(d.Name);
            }
            catch (Exception)
            {
                //error handling
            }
        }
        public void ShowAllDeveloper()
        {
            listBoxDeveloperList.Items.Clear();
            IEnumerable<Developer> developerList = developerApi.GetAllDevelopers();
            foreach (var developer in developerList)
            {
                listBoxDeveloperList.Items.Add(developer.Name);
            }
        }

        public void ShowAllGamesForDeveloper()
        {
            listBoxDeveloperGames.Items.Clear();
            IEnumerable<Game> gameList = gameApi.GetGamesByDeveloperId(GetSelectedDeveloperObjectFromList().DeveloperID);
            foreach (var game in gameList)
            {
                listBoxDeveloperGames.Items.Add(game.Title);
            }
        }

        public void DeleteDeveloper()
        {
            try
            {
                Developer developerToDelete = GetSelectedDeveloperObjectFromList();
                developerApi.DeleteDeveloper(developerToDelete);
                ShowAllDeveloper();

            }
            catch (Exception ex)
            {

                //error handling
            }
        }

        public void UpdateDeveloper()
        {
            Developer developerToUpdate = new Developer();
            developerToUpdate.DeveloperID = int.Parse(textBoxDeveloperID.Text);
            developerToUpdate.Name = textBoxDeveloperName.Text;
            developerToUpdate.Email = textBoxEmail.Text;
            developerToUpdate.Description = textBoxDeveloperDescription.Text;
            developerApi.UpdateDeveloper(developerToUpdate);
        }

        public IEnumerable<Developer> GetAllDevsFromApi()
        {
            listBoxDeveloperList.Items.Clear();
            IEnumerable<Developer> developerList = developerApi.GetAllDevelopers();
            foreach (var developer in developerList)
            {
                listBoxDeveloperList.Items.Add(developer.Name);
            }
            return developerList;
        }

        public Developer GetSelectedDeveloperObjectFromList()
        {
            Developer developerToShow = new Developer();
            IEnumerable<Developer> developerList = developerApi.GetAllDevelopers();
            foreach (Developer developer in developerList)
            {
                if (developer.Name.Equals(listBoxDeveloperList.SelectedItem))
                {
                    developerToShow = developer;
                }
            }
            return developerToShow;
        }

        public void ClearDeveloperInputFields()
        {
            textBoxDeveloperID.Clear();
            textBoxDeveloperName.Clear();
            textBoxEmail.Clear();
            textBoxDeveloperDescription.Clear();
            labelDeveloperNamePanel.ResetText();
            listBoxDeveloperGames.Items.Clear();
        }

        public void SetDeveloperInputFields(Developer developer)
        {
            textBoxDeveloperID.Text = developer.DeveloperID.ToString();
            textBoxDeveloperName.Text = developer.Name;
            textBoxEmail.Text = developer.Email;
            textBoxDeveloperDescription.Text = developer.Description;
            labelDeveloperNamePanel.Text = developer.Name;
        }
        #endregion

        private void listBoxDeveloperGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearCreateDeveloperFormFields();
            panelCreateDeveloper.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCreateDeveloper_Click(object sender, EventArgs e)
        {
            panelCreateDeveloper.Visible = true;
            ClearCreateDeveloperFormFields();
        }

        private void buttonFinishDeveloperCreation_Click(object sender, EventArgs e)
        {
            if (CheckInputFieldsForCreate() == true)
            {
                CreateNewDeveloper();
                ClearCreateDeveloperFormFields();
                panelCreateDeveloper.Visible = false;
                ShowAllDeveloper();
            }
            else
            {
                //error handling +
                ClearCreateDeveloperFormFields();
            }
            
        }
    }
}
