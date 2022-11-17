using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private IApiDeveloperDataAccess apiDeveloperDataAccess;

        public Form1()
        {
            InitializeComponent();
            apiDeveloperDataAccess = new ApiDeveloperDataAccess("https://localhost:7023/api/v1/developer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Functionality
        private void LoadData()
        { 
            
            try
            {
                listBox1.Items.Clear();
                var result = apiDeveloperDataAccess.GetAllDevelopers();
                foreach (Developer developer in result)
                {
                    listBox1.Items.Add(developer.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data from the server. Error is: '{ex.Message}'", "Communication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void listBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}