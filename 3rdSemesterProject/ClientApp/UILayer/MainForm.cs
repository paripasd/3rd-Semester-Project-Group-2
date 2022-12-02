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
using System.Globalization;

namespace ClientApp.UILayer
{
    public partial class MainForm : Form
    {
        private ApiDeveloperDataAccess developerApi;
        private ApiGameDataAccess gameApi;
        private ApiEventDataAccess eventApi;
        private ApiEventMemberDataAccess eventMemberApi;
        public MainForm()
        {
            InitializeComponent();
            developerApi = new ApiDeveloperDataAccess("https://localhost:7023/api/v1/Developer");
            gameApi = new ApiGameDataAccess("https://localhost:7023/api/v1/Game");
            eventApi = new ApiEventDataAccess("https://localhost:7023/ap1/v1/Event");
            eventMemberApi = new ApiEventMemberDataAccess("https://localhost:7023/api/v1/EventMember");
            GetAllDevsFromApi();
            ClearDeveloperInputFields();
            ShowAllEvent();
            ClearEventInputFields();
            panelCreateDeveloper.Visible = false;
            panelCreateEvent.Visible = false;
        }
        #region Developer Page Wiring
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
        #endregion
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


        #region Event Page Methods
        public void ShowAllEvent()
        {
            listBoxEvent.Items.Clear();
            IEnumerable<Event> eventList = eventApi.GetAllEvents();
            foreach (var e in eventList)
            {
                listBoxEvent.Items.Add(e.Name);
            }
        }

        public Event GetSelectedEventObjectFromList()
        {
            Event eventToShow = new Event();
            IEnumerable<Event> eventList = eventApi.GetAllEvents();
            foreach (Event e in eventList)
            {
                if (e.Name.Equals(listBoxEvent.SelectedItem))
                {
                    eventToShow = e;
                }
            }
            return eventToShow;
        }

        public void ClearEventInputFields()
        {
            textBoxEventId.Clear();
            textBoxEventGameId.Clear();
            textBoxEventName.Clear();
            textBoxEventDescription.Clear();
            labelEventNamePanel.ResetText();
            listBoxEventMember.Items.Clear();
            textBoxEventCapacity.Clear();
            dateTimePickerEventStartDate.ResetText();
            dateTimePickerEventEndDate.ResetText();
            dateTimePickerEventStartDateTime.ResetText();
            dateTimePickerEventEndDateTime.ResetText();
        }

        public void SetEventInputFields(Event e)
        {
            textBoxEventId.Text = e.EventID.ToString();
            textBoxEventGameId.Text = e.GameID.ToString();
            textBoxEventName.Text = e.Name;
            textBoxEventDescription.Text = e.Description;
            labelEventNamePanel.Text = e.Name;
            //set method for member list
            textBoxEventCapacity.Text = e.Capacity.ToString();
            dateTimePickerEventStartDate.Text = e.StartDate.Date.ToString();
            dateTimePickerEventEndDate.Text = e.EndDate.Date.ToString();
            dateTimePickerEventStartDateTime.Text = e.StartDate.Hour.ToString()+ ":" + e.StartDate.Minute.ToString() + ":" + e.StartDate.Second.ToString();//HH:mm:ss
            dateTimePickerEventEndDateTime.Text = e.EndDate.Hour.ToString() + ":" + e.EndDate.Minute.ToString() + ":" + e.EndDate.Second.ToString();
        }

        public void UpdateEvent()
        {

            DateTime startDate = DateTime.ParseExact(dateTimePickerEventStartDate.Text + " " + dateTimePickerEventStartDateTime.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(dateTimePickerEventEndDate.Text + " " + dateTimePickerEventEndDateTime.Text,"yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Event eventToUpdate = new Event();
            eventToUpdate.EventID = int.Parse(textBoxEventId.Text);
            eventToUpdate.Name = textBoxEventName.Text;
            eventToUpdate.Description = textBoxEventDescription.Text;
            eventToUpdate.StartDate = startDate;
            eventToUpdate.EndDate = endDate;
            eventApi.UpdateEvent(eventToUpdate);
        }

        public void DeleteEvent()
        {
            try
            {
                Event eventToDelete = GetSelectedEventObjectFromList();
                eventApi.DeleteEvent(eventToDelete);
                ShowAllEvent();

            }
            catch (Exception ex)
            {

                //error handling
            }
        }

        public bool CreateNewEvent()
        {   
            if (textBoxCreateEventGameId.Text.Length > 0 && textBoxCreateDeveloperName.Text.Length > 0 && textBoxCreateDeveloperDescription.Text.Length > 0 && textBoxCreateEventCapacity.Text.Length > 0 && textBoxCreateEventStartDate.Text.Length > 0 && textBoxCreateEventEndDate.Text.Length > 0)
            {
                Event e = new Event();
                e.GameID = int.Parse(textBoxCreateEventGameId.Text);
                e.Name = textBoxCreateDeveloperName.Text;
                e.Description = textBoxCreateDeveloperDescription.Text;
                e.Capacity = int.Parse(textBoxCreateEventCapacity.Text);
                e.StartDate = DateTime.Parse(textBoxCreateEventStartDate.Text);
                e.EndDate = DateTime.Parse(textBoxCreateEventEndDate.Text);
                eventApi.CreateEvent(e);
                return true;
            }
            return false;
        }

        public void ClearEventCreateFields()
        {
            textBoxCreateEventCapacity.Clear();
            textBoxCreateEventName.Clear();
            textBoxCreateEventGameId.Clear();
            textBoxCreateEventDescription.Clear();
            textBoxCreateEventStartDate.Clear();
            textBoxCreateEventEndDate.Clear();
        }

        #endregion
        private void buttonShowAllEvent_Click(object sender, EventArgs e)
        {
            ClearEventInputFields();
            ShowAllEvent();
        }

        private void listBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearEventInputFields();
            SetEventInputFields(GetSelectedEventObjectFromList());
        }

        private void buttonUpdateEvent_Click(object sender, EventArgs e)
        {
            UpdateEvent();
            ClearEventInputFields();
            ShowAllEvent();
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            DeleteEvent();
            ClearEventInputFields();
        }

        private void buttonCreateEventFinish_Click(object sender, EventArgs e)
        {
            if (CreateNewEvent() == true)
            {
                panelCreateEvent.Visible = false;
            }
            ClearEventCreateFields();
        }

        private void buttonCreateNewEvent_Click(object sender, EventArgs e)
        {
            panelCreateEvent.Visible = true;
            ClearEventCreateFields();
        }

        private void buttonCreateEventCancel_Click(object sender, EventArgs e)
        {
            panelCreateEvent.Visible = false;
            ClearEventCreateFields();
        }

        private void labelEventendDateHour_Click(object sender, EventArgs e)
        {

        }
    }
}
