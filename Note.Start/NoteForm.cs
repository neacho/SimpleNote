using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Note.Core.Entity;
using Note.Core;
namespace Note.Start
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();

            btn_confirm.Click += confirm;
            txt_title.Validating += valate;
        }

        private void valate(object sender, CancelEventArgs e)
        {
            if (txt_title.Text.Trim() == "")
            {
                e.Cancel = true;
            }
        }

        private void confirm(object sender, EventArgs e)
        {
            Catagory_info info = new Catagory_info();
            info.Catagory_Nama = txt_title.Text;

            NoteDbContext context = new NoteDbContext();
            context.Catagory.Add(info);
            context.SaveChanges();
        }
    }
}
