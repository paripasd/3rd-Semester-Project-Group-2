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
using RestSharp.Extensions;
using System.Security.AccessControl;

namespace ClientApp.UILayer
{
    public partial class MainForm : Form
    {
        private ApiDeveloperDataAccess developerApi;
        private ApiGameDataAccess gameApi;
        private ApiEventDataAccess eventApi;
        private ApiEventMemberDataAccess eventMemberApi;
        private ApiMemberDataAccess memberApi;
        private ApiSaleDataAccess saleApi;
        private byte[] CurrentGameFile { get; set; }//not so good clean code wise but works
        public byte[] CurrentGameFileCreate { get; set; }//not so good clean code wise but works
        public MainForm()
        {
            InitializeComponent();
            
            developerApi = new ApiDeveloperDataAccess("https://localhost:7023/api/v1/Developer");
            gameApi = new ApiGameDataAccess("https://localhost:7023/api/v1/Game");
            eventApi = new ApiEventDataAccess("https://localhost:7023/api/v1/Event");
            eventMemberApi = new ApiEventMemberDataAccess("https://localhost:7023/api/v1/eventmember");
            memberApi = new ApiMemberDataAccess("https://localhost:7023/api/v1/Member");
            gameApi = new ApiGameDataAccess("https://localhost:7023/api/v1/Game");
            saleApi = new ApiSaleDataAccess("https://localhost:7023/api/v1/Sale");


            GetAllDevsFromApi();
            ClearDeveloperInputFields();
            ShowAllEvent();
            ClearEventInputFields();
            ShowAllGames();
            ClearGameUpdateInputFields();
            ClearGameCreateInputFields();
            GetAllSales();

            CurrentGameFile = null;
            CurrentGameFileCreate = null;

            panelCreateDeveloper.Visible = false;
            panelCreateEvent.Visible = false;
            panelCreateGame.Visible = false;
            labelCapacityCounter.Visible = false;

            


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

        public IEnumerable<int> GetAllMembersByEvent(int eventId)
        {
            try
            {
                IEnumerable<int> members = eventMemberApi.FindMembersFromEventId(eventId);
                return members;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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

        public void SetSelectedMemberFromMemberToList()
        {
            int counter = 0;
            IEnumerable<Member> memberList = new List<Member>();

            IEnumerable<Member> allMemberObjects = new List<Member>();
            allMemberObjects = memberApi.GetAllMembers();

            IEnumerable<int> memberIdList = new List<int>();
            memberIdList = GetAllMembersByEvent(GetSelectedEventObjectFromList().EventID);

            foreach (int i in memberIdList)
            {
                foreach (Member m in allMemberObjects)
                {
                    if (i == m.MemberID)
                    {
                        listBoxEventMember.Items.Add(m.MemberID + " | " + m.Name + " | " + m.Email);
                        counter += 1;
                    }
                }
            }
            labelCapacityCounter.Text = counter.ToString() + "/" + numericUpDownEventPage.Value.ToString();
            labelCapacityCounter.Visible = true;
        }

        public void ClearEventInputFields()
        {
            textBoxEventId.Clear();
            textBoxEventGameId.Clear();
            textBoxEventName.Clear();
            textBoxEventDescription.Clear();
            labelEventNamePanel.ResetText();
            listBoxEventMember.Items.Clear();
            numericUpDownEventPage.ResetText();
            dateTimePickerEventStartDate.ResetText();
            dateTimePickerEventEndDate.ResetText();
            listBoxEventMember.Items.Clear();
            labelCapacityCounter.Visible = false;
        }

        public int GetSelectedMemberId()
        {
            string phrase = listBoxEventMember.SelectedItem.ToString();
            string[] words = phrase.Split(' ');

            return int.Parse(words[0]);
        }
        public void SetEventInputFields(Event e)
        {
            textBoxEventId.Text = e.EventID.ToString();
            textBoxEventGameId.Text = e.GameID.ToString();
            textBoxEventName.Text = e.Name;
            textBoxEventDescription.Text = e.Description;
            labelEventNamePanel.Text = e.Name;
            numericUpDownEventPage.Text = e.Capacity.ToString();
            dateTimePickerEventStartDate.Text = e.StartDate.ToString();
            dateTimePickerEventEndDate.Text = e.EndDate.ToString();
            SetSelectedMemberFromMemberToList();
        }

        public void UpdateEvent()
        {
            Event eventToUpdate = new Event();
            eventToUpdate.Name = textBoxEventName.Text;
            eventToUpdate.Description = textBoxEventDescription.Text;
            eventToUpdate.StartDate = dateTimePickerEventStartDate.Value.AddHours(1) ;
            eventToUpdate.EndDate = dateTimePickerEventEndDate.Value.AddHours(1);
            eventToUpdate.EventID = int.Parse(textBoxEventId.Text);
            eventApi.UpdateEvent(eventToUpdate);
        }

        public void RemoveMemberFromEvent(int eventId, int memberId)
        {
            EventMember em = new EventMember();
            em.EventID = eventId;
            em.MemberID = memberId;
            eventMemberApi.RemoveMemberFromEvent(em);
        }

        public void DeleteEvent()
        {
            try
            {
                Event eventToDelete = GetSelectedEventObjectFromList();
                eventApi.DeleteEvent(eventToDelete);

            }
            catch (Exception ex)
            {

                //error handling
            }
        }

        public bool CreateNewEvent()
        {   
            if (textBoxCreateEventGameId.Text.Length > 0 && textBoxCreateEventName.Text.Length > 0 && textBoxCreateEventDescription.Text.Length > 0 && numericUpDownCreateEventCapacity.Text.Length > 0 && dateTimePickerCreateEventStartDate.Text.Length > 0 && dateTimePickerCreateEventEndDate.Text.Length > 0)
            {
                Event e = new Event();
                e.GameID = int.Parse(textBoxCreateEventGameId.Text);
                e.Name = textBoxCreateEventName.Text;
                e.Description = textBoxCreateEventDescription.Text;
                e.Capacity = int.Parse(numericUpDownCreateEventCapacity.Text);
                e.StartDate = DateTime.Parse(dateTimePickerCreateEventStartDate.Text).AddHours(1);
                e.EndDate = DateTime.Parse(dateTimePickerCreateEventEndDate.Text).AddHours(1);
                try
                {
                    eventApi.CreateEvent(e);
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                
                return true;
            }
            return false;
        }

        public void ClearEventCreateFields()
        {
            numericUpDownCreateEventCapacity.ResetText();
            textBoxCreateEventName.Clear();
            textBoxCreateEventGameId.Clear();
            textBoxCreateEventDescription.Clear();
            dateTimePickerCreateEventStartDate.ResetText();
            dateTimePickerCreateEventEndDate.ResetText();
        }
        public void FindEventFromId()
        {
            Event e = new Event();
            try
            {
                e = eventApi.FindEventFromId(int.Parse(textBoxEventIdSerach.Text));
                listBoxEvent.Items.Clear();
                listBoxEvent.Items.Add(e.Name);
            }
            catch (Exception)
            {
                //error handling
            }
        }

        #endregion
        #region Event Page Wiring
        private void buttonShowAllEvent_Click(object sender, EventArgs e)
        {
            textBoxEventIdSerach.Clear();
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
            ShowAllEvent();
        }

        private void buttonCreateEventFinish_Click(object sender, EventArgs e)
        {
            bool success = CreateNewEvent();
            if (success == true)
            {
                panelCreateEvent.Visible = false;
            }
            ClearEventCreateFields();
            ShowAllEvent();
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

        private void EventMenuBar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchEventById_Click(object sender, EventArgs e)
        {
            ClearEventInputFields();
            FindEventFromId();
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            if (listBoxEventMember.SelectedItem != null)
            {
                RemoveMemberFromEvent(GetSelectedEventObjectFromList().EventID, GetSelectedMemberId());
                listBoxEventMember.Items.Clear();
                SetSelectedMemberFromMemberToList();
            } 
        }

        private void listBoxEventMember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Game Page Methods
        public void ShowAllGames()
        {
            listBoxGameList.Items.Clear();
            IEnumerable<Game> gameList = gameApi.GetAllGames();
            foreach (var g in gameList)
            {
                listBoxGameList.Items.Add(g.Title);
            }
        }

        public Game GetSelectedGameObjectFromList()
        {
            Game gameToShow = new Game();
            IEnumerable<Game> gameList = gameApi.GetAllGames();
            foreach (Game g in gameList)
            {
                if (g.Title.Equals(listBoxGameList.SelectedItem))
                {
                    gameToShow = g;
                }
            }

            Game gameFile = new Game();
            gameFile = GetSelectedGameFileObject(gameToShow.GameID);
            gameToShow.FileName = gameFile.FileName;
            gameToShow.FileContent = gameFile.FileContent;
            return gameToShow;
        }

        public void SetGameUpdateInputFields(Game game)
        {
            textBoxUpdateGameGameId.Text = game.GameID.ToString();
            textBoxUpdateGameTitle.Text = game.Title;
            textBoxUpdateGameDeveloperId.Text = game.DeveloperID.ToString(); ;
            textBoxUpdateGameType.Text = game.Type;
            textBoxUpdateGameDescription.Text = game.Description;
            numericUpDownUpdateGamePrice.Text = game.Price.ToString(); ;
            labelUpdateGameFileName.Text = game.FileName;
            numericUpDownUpdateGameYearOfRelease.Text = game.YearOfRelease.ToString();
            textBoxUpdateGameSpecifications.Text = game.Specifications;
            labelUpdateGameName.Text = game.Title;
            CurrentGameFile = game.FileContent;

        }

        public void ClearGameUpdateInputFields()
        {
            textBoxUpdateGameGameId.Clear();
            textBoxUpdateGameTitle.Clear();
            textBoxUpdateGameDeveloperId.Clear();
            textBoxUpdateGameType.Clear();
            textBoxUpdateGameDescription.Clear();
            numericUpDownUpdateGamePrice.ResetText();
            labelUpdateGameFileName.Text = "No File";
            numericUpDownUpdateGameYearOfRelease.ResetText();
            textBoxUpdateGameSpecifications.Clear();
            labelUpdateGameName.ResetText();
            CurrentGameFile = null;

        }

        public Game GetSelectedGameFileObject(int gameId)
        {
            Game gameFileToShow = gameApi.GetGameFileByGameId(gameId);
            return gameFileToShow;
        }

        public void UpdateGame()
        {
            if (AllUpdateFieldsAreCorrect() == true)
            {
                Game gameToUpdate = new Game();
                gameToUpdate.GameID = int.Parse(textBoxUpdateGameGameId.Text);
                gameToUpdate.Title = textBoxUpdateGameTitle.Text;
                gameToUpdate.Type = textBoxUpdateGameType.Text;
                gameToUpdate.Description = textBoxUpdateGameDescription.Text;
                gameToUpdate.DeveloperID = int.Parse(textBoxUpdateGameDeveloperId.Text);
                gameToUpdate.Price = float.Parse(numericUpDownUpdateGamePrice.Text);
                gameToUpdate.Specifications = textBoxUpdateGameSpecifications.Text;
                gameToUpdate.YearOfRelease = int.Parse(numericUpDownUpdateGameYearOfRelease.Text);
                gameToUpdate.FileName = labelUpdateGameFileName.Text;
                gameToUpdate.FileContent = CurrentGameFile;
                gameApi.UpdateGame(gameToUpdate);
            }

        }

        public bool AllUpdateFieldsAreCorrect()
        {
            if (textBoxUpdateGameTitle.Text.Length > 0 && textBoxUpdateGameDescription.Text.Length > 0 && numericUpDownUpdateGamePrice.Text.Length > 0 && textBoxUpdateGameDeveloperId.Text.Length > 0 && textBoxUpdateGameSpecifications.Text.Length > 0 && numericUpDownUpdateGameYearOfRelease.Text.Length > 0 && labelUpdateGameFileName.Text.Length > 0 && CurrentGameFile != null)
            {
                return true;
            }
            return false;
        }

        public void SelectFileDialog()
        {
            DialogResult dialog = saveFileDialogGame.ShowDialog();
            saveFileDialogGame.Title = "Choose new game file for updating";
            string path = saveFileDialogGame.FileName;

            if (dialog == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(path))
                {
                    //error
                }
                labelUpdateGameFileName.Text = Path.GetFileName(path);
                CurrentGameFile = File.ReadAllBytes(Path.GetFullPath(path));
            }
            if (dialog == DialogResult.Cancel)
            {
                if (string.IsNullOrEmpty(path))
                {
                    //error
                }
            }
        }

        public void FindGameFromId()
        {
            Game gameSearch = new Game();
            try
            {
                IEnumerable<Game> allGames = new List<Game>();
                allGames = gameApi.GetAllGames();
                foreach (Game game in allGames)
                {
                    if (game.GameID == int.Parse(textBoxSearchGame.Text))
                    {
                        gameSearch = game;
                    }
                }
                listBoxGameList.Items.Clear();
                listBoxGameList.Items.Add(gameSearch.Title);
            }
            catch (Exception)
            {
                //error handling
            }
        }

        //create 
        public void AddNewGame()
        {
            if (AllCreateFieldsAreCorrect() == true)
            {
                Game gameToCreate = new Game();
                gameToCreate.Title = textBoxCreateGameTitle.Text;
                gameToCreate.DeveloperID = int.Parse(textBoxCreateGameDeveloperId.Text);
                gameToCreate.Type = textBoxCreateGameType.Text;
                gameToCreate.Description = textBoxCreateGameDescription.Text;
                gameToCreate.Specifications = textBoxCreateGameSpecifications.Text;
                gameToCreate.Price = float.Parse(numericUpDownCreateGamePrice.Text);
                gameToCreate.YearOfRelease = int.Parse(numericUpDownCreateGameYearOfRelease.Text);
                gameToCreate.FileName = labelCreateGameFileName.Text;
                gameToCreate.FileContent = CurrentGameFileCreate;
                gameApi.CreateGame(gameToCreate);
            }
        }

        public bool AllCreateFieldsAreCorrect()
        {
            if (CurrentGameFileCreate != null && textBoxCreateGameTitle.Text.Length > 0 && textBoxCreateGameDeveloperId.Text.Length > 0 && textBoxCreateGameType.Text.Length > 0 && textBoxCreateGameDescription.Text.Length > 0 && textBoxCreateGameSpecifications.Text.Length > 0 && numericUpDownCreateGamePrice.Text.Length > 0 && numericUpDownCreateGameYearOfRelease.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        public void ClearGameCreateInputFields()
        {
            textBoxCreateGameTitle.Clear();
            textBoxCreateGameDeveloperId.Clear();
            textBoxCreateGameType.Clear();
            textBoxCreateGameDescription.Clear();
            numericUpDownCreateGamePrice.ResetText();
            labelCreateGameFileName.Text = "No File";
            numericUpDownCreateGameYearOfRelease.ResetText();
            textBoxCreateGameSpecifications.Clear();
            CurrentGameFileCreate = null;
        }

        public void SelectFileDialogCreate()
        {
            DialogResult dialog = saveFileDialogCreate.ShowDialog();
            saveFileDialogCreate.Title = "Choose new game file";
            string path = saveFileDialogCreate.FileName;

            if (dialog == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(path))
                {
                    //error
                }
                labelCreateGameFileName.Text = Path.GetFileName(path);
                CurrentGameFileCreate = File.ReadAllBytes(Path.GetFullPath(path));
            }
            if (dialog == DialogResult.Cancel)
            {
                if (string.IsNullOrEmpty(path))
                {
                    //error
                }
            }
        }

        public void DeleteGame()
        {
            gameApi.DeleteGame(GetSelectedGameObjectFromList().GameID);
        }
        #endregion
        #region Game Page Wiring
        private void listBoxGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGameUpdateInputFields();
            SetGameUpdateInputFields(GetSelectedGameObjectFromList());
        }

        private void buttonUpdateGameChangeFile_Click(object sender, EventArgs e)
        {
            SelectFileDialog();
        }

        private void buttonUpdateGame_Click(object sender, EventArgs e)
        {
            UpdateGame();
            ClearGameUpdateInputFields();
            ShowAllGames();
        }

        private void buttonCreateNewGame_Click(object sender, EventArgs e)
        {
            panelCreateGame.Visible = true;
        }

        private void buttonCreateGameCancel_Click(object sender, EventArgs e)
        {
            ClearGameCreateInputFields();
            panelCreateGame.Visible = false;
        }

        private void buttonCreateGameFinish_Click(object sender, EventArgs e)
        {
            AddNewGame();
            ClearGameCreateInputFields();
            panelCreateGame.Visible = false;
            ShowAllGames();
        }

        private void buttonCreateGameFile_Click(object sender, EventArgs e)
        {
            SelectFileDialogCreate();
        }

        private void buttonShowAllGame_Click(object sender, EventArgs e)
        {
            ClearGameUpdateInputFields();
            ShowAllGames();
        }

        private void buttonDeleteGame_Click(object sender, EventArgs e)
        {
            DeleteGame();
            ClearGameUpdateInputFields();
            ShowAllGames();
        }

        private void buttonSearchGame_Click(object sender, EventArgs e)
        {
            FindGameFromId();
            ClearGameUpdateInputFields();
            textBoxSearchGame.ResetText();
        }
        #endregion

        #region Sale Page Methods


        public void GetAllSales()
        {
            List<Sale> allSales = new List<Sale>();
            allSales = saleApi.GetAllSales();
            
            
            foreach (Sale sale in allSales)
            {
                saleBindingSource.Add(sale);
            }
            
        }
        #endregion

        private void advancedDataGridViewSale_SortStringChanged(object sender, EventArgs e)
        {
            saleBindingSource.Sort = advancedDataGridViewSale.SortString;
            advancedDataGridViewSale.Refresh();
        }

        private void advancedDataGridViewSale_FilterStringChanged(object sender, EventArgs e)
        {
            saleBindingSource.Filter = advancedDataGridViewSale.FilterString;
            advancedDataGridViewSale.Refresh();
        }

        private void saleBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            labelSaleTotalRows.Text = string.Format("Total Rows: {0}",saleBindingSource.List.Count);
        }
    }
}
