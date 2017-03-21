namespace DisplayBookTable
{
    partial class DisplayBookTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.query1BTN = new System.Windows.Forms.Button();
            this.query2BTN = new System.Windows.Forms.Button();
            this.query3BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(644, 203);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
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
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(BookTable.Author);
            // 
            // query1BTN
            // 
            this.query1BTN.Location = new System.Drawing.Point(50, 294);
            this.query1BTN.Name = "query1BTN";
            this.query1BTN.Size = new System.Drawing.Size(75, 23);
            this.query1BTN.TabIndex = 2;
            this.query1BTN.Text = "Query 1";
            this.query1BTN.UseVisualStyleBackColor = true;
            this.query1BTN.Click += new System.EventHandler(this.query1BTN_Click);
            // 
            // query2BTN
            // 
            this.query2BTN.Location = new System.Drawing.Point(273, 294);
            this.query2BTN.Name = "query2BTN";
            this.query2BTN.Size = new System.Drawing.Size(75, 23);
            this.query2BTN.TabIndex = 3;
            this.query2BTN.Text = "Query 2";
            this.query2BTN.UseVisualStyleBackColor = true;
            this.query2BTN.Click += new System.EventHandler(this.query2BTN_Click);
            // 
            // query3BTN
            // 
            this.query3BTN.Location = new System.Drawing.Point(502, 294);
            this.query3BTN.Name = "query3BTN";
            this.query3BTN.Size = new System.Drawing.Size(75, 23);
            this.query3BTN.TabIndex = 4;
            this.query3BTN.Text = "Query 3";
            this.query3BTN.UseVisualStyleBackColor = true;
            this.query3BTN.Click += new System.EventHandler(this.query3BTN_Click);
            // 
            // DisplayBookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 363);
            this.Controls.Add(this.query3BTN);
            this.Controls.Add(this.query2BTN);
            this.Controls.Add(this.query1BTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayBookTable";
            this.Text = "Display Book Table";
            this.Load += new System.EventHandler(this.DisplayBookTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button query1BTN;
        private System.Windows.Forms.Button query2BTN;
        private System.Windows.Forms.Button query3BTN;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}

