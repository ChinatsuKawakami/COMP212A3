namespace DisplayPlayer
{
    partial class DisplayPlayerTable
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
            this.components = new System.ComponentModel.Container();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            this.viewBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(134, 250);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(100, 19);
            this.lastNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "LastName : ";
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(260, 246);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(99, 23);
            this.searchBTN.TabIndex = 3;
            this.searchBTN.Text = "Let\'s Search!!";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // viewBTN
            // 
            this.viewBTN.Location = new System.Drawing.Point(260, 275);
            this.viewBTN.Name = "viewBTN";
            this.viewBTN.Size = new System.Drawing.Size(99, 23);
            this.viewBTN.TabIndex = 4;
            this.viewBTN.Text = "View All Data";
            this.viewBTN.UseVisualStyleBackColor = true;
            this.viewBTN.Click += new System.EventHandler(this.viewBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(348, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(_300821245_kawakami__ASS3.Player);
            // 
            // DisplayPlayerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 310);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTxtBox);
            this.Name = "DisplayPlayerTable";
            this.Text = "Player Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button viewBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
    }
}

