
namespace SQL_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSelectView = new System.Windows.Forms.Button();
            this.BtnSelectTable = new System.Windows.Forms.Button();
            this.TbProcedure = new System.Windows.Forms.TextBox();
            this.LbProcedureParameters = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbTableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.BtnXMLTable = new System.Windows.Forms.Button();
            this.BtnXMLView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSelectView
            // 
            this.BtnSelectView.Location = new System.Drawing.Point(889, 295);
            this.BtnSelectView.Name = "BtnSelectView";
            this.BtnSelectView.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectView.TabIndex = 42;
            this.BtnSelectView.Text = "Select";
            this.BtnSelectView.UseVisualStyleBackColor = true;
            this.BtnSelectView.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnSelectTable
            // 
            this.BtnSelectTable.Location = new System.Drawing.Point(311, 295);
            this.BtnSelectTable.Name = "BtnSelectTable";
            this.BtnSelectTable.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectTable.TabIndex = 40;
            this.BtnSelectTable.Text = "Select";
            this.BtnSelectTable.UseVisualStyleBackColor = true;
            this.BtnSelectTable.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TbProcedure
            // 
            this.TbProcedure.Location = new System.Drawing.Point(404, 376);
            this.TbProcedure.Multiline = true;
            this.TbProcedure.Name = "TbProcedure";
            this.TbProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbProcedure.Size = new System.Drawing.Size(479, 241);
            this.TbProcedure.TabIndex = 38;
            // 
            // LbProcedureParameters
            // 
            this.LbProcedureParameters.FormattingEnabled = true;
            this.LbProcedureParameters.Location = new System.Drawing.Point(973, 379);
            this.LbProcedureParameters.Name = "LbProcedureParameters";
            this.LbProcedureParameters.Size = new System.Drawing.Size(184, 238);
            this.LbProcedureParameters.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(893, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Params";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Definition";
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.Location = new System.Drawing.Point(107, 379);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(184, 238);
            this.LbProcedures.TabIndex = 34;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Procedures";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.Location = new System.Drawing.Point(973, 99);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(184, 238);
            this.LbViewColumns.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(893, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Columns";
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.Location = new System.Drawing.Point(699, 99);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(184, 238);
            this.LbViews.TabIndex = 30;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Views";
            // 
            // LbTableColumns
            // 
            this.LbTableColumns.FormattingEnabled = true;
            this.LbTableColumns.Location = new System.Drawing.Point(404, 99);
            this.LbTableColumns.Name = "LbTableColumns";
            this.LbTableColumns.Size = new System.Drawing.Size(184, 238);
            this.LbTableColumns.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Columns";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.Location = new System.Drawing.Point(107, 99);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(184, 238);
            this.LbTables.TabIndex = 26;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tables";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(107, 43);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(184, 21);
            this.CbDatabases.TabIndex = 24;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Databases";
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(311, 41);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnQuery.TabIndex = 43;
            this.BtnQuery.Text = "Query";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // BtnXMLTable
            // 
            this.BtnXMLTable.Location = new System.Drawing.Point(311, 254);
            this.BtnXMLTable.Name = "BtnXMLTable";
            this.BtnXMLTable.Size = new System.Drawing.Size(75, 23);
            this.BtnXMLTable.TabIndex = 44;
            this.BtnXMLTable.Text = "XML";
            this.BtnXMLTable.UseVisualStyleBackColor = true;
            this.BtnXMLTable.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // BtnXMLView
            // 
            this.BtnXMLView.Location = new System.Drawing.Point(889, 254);
            this.BtnXMLView.Name = "BtnXMLView";
            this.BtnXMLView.Size = new System.Drawing.Size(75, 23);
            this.BtnXMLView.TabIndex = 45;
            this.BtnXMLView.Text = "XML";
            this.BtnXMLView.UseVisualStyleBackColor = true;
            this.BtnXMLView.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.BtnXMLView);
            this.Controls.Add(this.BtnXMLTable);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.BtnSelectView);
            this.Controls.Add(this.BtnSelectTable);
            this.Controls.Add(this.TbProcedure);
            this.Controls.Add(this.LbProcedureParameters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTableColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectView;
        private System.Windows.Forms.Button BtnSelectTable;
        private System.Windows.Forms.TextBox TbProcedure;
        private System.Windows.Forms.ListBox LbProcedureParameters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbTableColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Button BtnXMLTable;
        private System.Windows.Forms.Button BtnXMLView;
    }
}

