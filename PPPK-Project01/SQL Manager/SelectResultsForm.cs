using System.Data;
using System.Windows.Forms;

namespace SQL_Manager
{
    public partial class SelectResultsForm : Form
    {
        public SelectResultsForm(DataTable dataTable)
        {
            InitializeComponent();
            Init(dataTable);
        }

        private void Init(DataTable dataTable)
        {
            Text = dataTable.TableName;
            DgResults.DataSource = dataTable;
        }
    }
}
