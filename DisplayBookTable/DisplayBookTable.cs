using BookTable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DisplayBookTable
{
    public partial class DisplayBookTable : Form
    {
        public DisplayBookTable()
        {
            InitializeComponent();
        }


        private BookTable.BookEntities dbcontext = new BookTable.BookEntities();
     
        private void DisplayBookTable_Load(object sender, EventArgs e)
        {
            
                var bookAndAuthor = 
                (from Books in dbcontext.Books
                 join Author in dbcontext.Authors
                 on Books.AuthorId equals Author.AuthorId
                 select new {Books.Title,Author.LastName,Author.FirstName}).ToList();


                authorBindingSource.DataSource = bookAndAuthor;
               
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void query1BTN_Click(object sender, EventArgs e)
        {
            var query1 = (from Books in dbcontext.Books
                          join Author in dbcontext.Authors
                          on Books.AuthorId equals Author.AuthorId
                          orderby Books.Title
                          select new {Books.Title,Author.LastName,Author.FirstName}).ToList();
           authorBindingSource.DataSource = query1;   
        }

        private void query2BTN_Click(object sender, EventArgs e)
        {
            var query2 = (from Books in dbcontext.Books
                          join Author in dbcontext.Authors
                          on Books.AuthorId equals Author.AuthorId
                          orderby Books.Title, Author.LastName, Author.FirstName ascending
                          select new { Books.Title, Author.LastName, Author.FirstName }).ToList();
            authorBindingSource.DataSource = query2;
        }

        private void query3BTN_Click(object sender, EventArgs e)
        {

            

             var query3 = (
                          from b in dbcontext.Books
                          from author in b.Authors
                          orderby author.LastName, author.FirstName ascending
                          select new
                          {         
                             Title =  b.Title,
                             LastName = author.LastName,
                             FirstName = author.FirstName,
                             AuthorId = author.AuthorId

                         }).ToList();
            
         authorBindingSource.DataSource = query3;

           
        }//closer this method

       
    }

}
