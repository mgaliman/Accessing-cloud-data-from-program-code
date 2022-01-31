using SQL_Manager.Dal;
using SQL_Manager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SQL_Manager
{
    public partial class QueryForm : Form
    {

        public QueryForm()
        {
            InitializeComponent();
            Init();
        }
        private void Init() => LoadDatabases();

        private void LoadDatabases() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void BtnExecute_Click(object sender, System.EventArgs e)
        {
            TbResults.Controls.Clear();
            string selectedDatabase = $"use {CbDatabases.SelectedItem} ";
            DataGrid dataGrid = new DataGrid();
            try
            {
                string query = selectedDatabase + TbQuery.Text.Trim();
                DataSet dataTable = RepositoryFactory.GetRepository().GetDataSet(query);

                foreach (DataTable data in dataTable.Tables)
                {
                    dataGrid.DataSource = data;
                    dataGrid.Width = TbResults.Width;
                    dataGrid.Height = TbResults.Height;

                    TbResults.Controls.Add(dataGrid);

                    TbMessages.Text = $"({data.Rows.Count}  " + $"rows affected)\n  Completion time: {DateTime.Now}";
                }                
            }
            catch (Exception)
            {
                dataGrid = new DataGrid();
                TbMessages.Text = "No Can DO";
            }
        }
    }
}
