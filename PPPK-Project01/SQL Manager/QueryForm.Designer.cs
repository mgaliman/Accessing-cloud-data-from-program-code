
namespace SQL_Manager
{
    partial class QueryForm
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
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.TcResultsMessages = new System.Windows.Forms.TabControl();
            this.Results = new System.Windows.Forms.TabPage();
            this.Messages = new System.Windows.Forms.TabPage();
            this.TbMessages = new System.Windows.Forms.TextBox();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.TcResultsMessages.SuspendLayout();
            this.Results.SuspendLayout();
            this.Messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbQuery
            // 
            this.TbQuery.Location = new System.Drawing.Point(12, 41);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.Size = new System.Drawing.Size(684, 480);
            this.TbQuery.TabIndex = 0;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(626, 451);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(70, 70);
            this.BtnExecute.TabIndex = 1;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // TbResults
            // 
            this.TbResults.Location = new System.Drawing.Point(-3, -22);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.Size = new System.Drawing.Size(682, 345);
            this.TbResults.TabIndex = 2;
            // 
            // TcResultsMessages
            // 
            this.TcResultsMessages.Controls.Add(this.Results);
            this.TcResultsMessages.Controls.Add(this.Messages);
            this.TcResultsMessages.Location = new System.Drawing.Point(12, 527);
            this.TcResultsMessages.Name = "TcResultsMessages";
            this.TcResultsMessages.SelectedIndex = 0;
            this.TcResultsMessages.Size = new System.Drawing.Size(684, 349);
            this.TcResultsMessages.TabIndex = 5;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.TbResults);
            this.Results.Location = new System.Drawing.Point(4, 22);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(3);
            this.Results.Size = new System.Drawing.Size(676, 323);
            this.Results.TabIndex = 1;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.TbMessages);
            this.Messages.Location = new System.Drawing.Point(4, 22);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(676, 323);
            this.Messages.TabIndex = 2;
            this.Messages.Text = "Messages";
            this.Messages.UseVisualStyleBackColor = true;
            // 
            // TbMessages
            // 
            this.TbMessages.Location = new System.Drawing.Point(0, 0);
            this.TbMessages.Multiline = true;
            this.TbMessages.Name = "TbMessages";
            this.TbMessages.Size = new System.Drawing.Size(676, 327);
            this.TbMessages.TabIndex = 0;
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(12, 12);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(228, 21);
            this.CbDatabases.TabIndex = 6;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 884);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.TcResultsMessages);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TbQuery);
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryForm";
            this.TcResultsMessages.ResumeLayout(false);
            this.Results.ResumeLayout(false);
            this.Results.PerformLayout();
            this.Messages.ResumeLayout(false);
            this.Messages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TextBox TbResults;
        private System.Windows.Forms.TabControl TcResultsMessages;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TextBox TbMessages;
        private System.Windows.Forms.ComboBox CbDatabases;
    }
}