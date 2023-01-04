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
           
        }
        #endregion

        private void listBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}