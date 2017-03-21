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

namespace DisplayPlayer
{
    public partial class DisplayPlayerTable : Form
    {
        public DisplayPlayerTable()
        {
            InitializeComponent();
        }

        private _300821245_kawakami__ASS3.PlayerEntities dbcontext
            = new _300821245_kawakami__ASS3.PlayerEntities();

       private void DisplayPlayer_Load(object sender, EventArgs e)
        {
                 dbcontext.Players
                .OrderBy(player => player.PlayerId).Load();

                 var displayQuery = from player in dbcontext.Players
                                    select player;
                 playerBindingSource.DataSource = dbcontext.Players.Local;
                 playerBindingSource.DataSource = displayQuery;           
        }
        

        

        private void searchBTN_Click(object sender, EventArgs e)
        {
            var resultQuery = from player in dbcontext.Players
                         where player.LastName.Equals(lastNameTxtBox.Text)
                         select player;

            playerBindingSource.DataSource = resultQuery.ToList();
          
                         
        }

        private void viewBTN_Click(object sender, EventArgs e)
        {
         
            var viewQuery = from player in dbcontext.Players
                               select player;
            playerBindingSource.DataSource = viewQuery.ToList();
            

        }



    }
}
