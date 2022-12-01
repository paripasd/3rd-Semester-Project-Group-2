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
        public MainForm()
        {
            InitializeComponent();
            developerApi = new ApiDeveloperDataAccess("https://localhost:7023/api/v1/Developer");
            GetAllDevsFromApi();
            ClearDeveloperInputFields();
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
            UpdateDeveloper();
            ClearDeveloperInputFields();
            ShowAllDeveloper();
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


        }
        #region Methods

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
    }
}
