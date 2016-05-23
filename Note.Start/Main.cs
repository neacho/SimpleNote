using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Utilities;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Note.Core;
using Note.Core.Entity;

namespace Note.Start
{
    public partial class Main : Form
    {
        private NoteDbContext noteContext=null;
        private FileDbContext fileContext=null;
        public Main()
        {
            InitializeComponent();

            noteContext = new NoteDbContext();
            fileContext = new FileDbContext();

            InitNavigate();

            tree_Navi.MouseClick += NoteOPerate;
            Main_Container.Panel2.MouseClick += MouseClick;
            btn_addFile.Click += addFile;
            btn_delFile.Click += delFile;

            btn_newNote.Click += newNote;
            btn_delNote.Click += delNote;
            btnSave.Click += Save;
        }

        private void Save(object sender, EventArgs e)
        {
            file_info info = this.fileinfoBindingSource.DataSource as file_info;
            info.File_Content = txt_content.Text;
            fileContext.Entry<file_info>(info).State = System.Data.Entity.EntityState.Modified;
            fileContext.SaveChanges();
        }

        private new void MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show();
            }
        }

        private void delNote(object sender, EventArgs e)
        {
            TreeNode node = tree_Navi.SelectedNode;
            if (node.Parent!=null)
            {
                MessageBox.Show("操作失败");
                return;
            }

            Catagory_info info = noteContext.Catagory.Find(node.Tag);
            noteContext.Catagory.Remove(info);

            //删除子集程序
            var sub = fileContext.Detail.Where(x => x.Catagory_ID == info.Catagory_ID);
            foreach(Catagory_detail detail in sub)
            {
                file_info file = fileContext.Files.Find(detail.File_ID);
                fileContext.Files.Remove(file);
                fileContext.Detail.Remove(detail);
            }

            tree_Navi.Nodes.Remove(node);
        }

        private void newNote(object sender, EventArgs e)
        {
            NoteForm form = new NoteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitNavigate();
            }
        }

        private void delFile(object sender, EventArgs e)
        {
            TreeNode node = tree_Navi.SelectedNode;
            if (node.Nodes.Count > 0)
            {
                MessageBox.Show("操作失败");
                return;
            }

            file_info info = fileContext.Files.Find(node.Tag);
            fileContext.Files.Remove(info);

            tree_Navi.Nodes.Remove(node);
        }

        private void addFile(object sender, EventArgs e)
        {
            TreeNode node = tree_Navi.SelectedNode;
            if (node.Parent != null)
            {
                MessageBox.Show("操作失败");
                return;
            }

            file_info file = new file_info();
            fileContext.Files.Add(file);
            fileContext.SaveChanges();
            CurrentFile = file;

            Catagory_detail detail = new Catagory_detail();
            detail.Catagory_ID = Convert.ToInt64(node.Tag);
            detail.File_ID = file.File_ID;
            fileContext.Detail.Add(detail);
            fileContext.SaveChanges();
        }

        private file_info CurrentFile = null;
        private void NoteOPerate(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right){
                contextMenuStrip1.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {
                TreeNode node = tree_Navi.GetNodeAt(new Point(e.X, e.Y));
                if (node == null)
                {
                    return;
                }

                if (node.Parent != null)
                {
                    file_info file = fileContext.Files.Find( Convert.ToInt64(node.Tag));
                    CurrentFile = file;
                    txt_title.Text = file.File_Title;
                    txt_content.Text = file.File_Content;
                }
                else
                {
                    this.fileinfoBindingSource.Clear();
                    txt_content.Text = "";
                    txt_title.Text = "";
                }
            }
        }

        //初始化导航栏
        void InitNavigate()
        { 
            var dataSource = noteContext.Catagory.ToList();
            foreach(Catagory_info info in dataSource)
            {
                TreeNode node = new TreeNode(info.Catagory_Nama);
                node.Tag = info.Catagory_ID;
                tree_Navi.Nodes.Add(node);
                var sub = fileContext.Detail.Where(x => x.Catagory_ID == info.Catagory_ID);
                foreach(Catagory_detail detail in sub)
                {
                    file_info file = fileContext.Files.Find(Convert.ToInt64(detail.File_ID));
                    TreeNode subNode = new TreeNode(file.File_Title);
                    subNode.Tag = detail.File_ID;
                    node.Nodes.Add(subNode);
                }

            }
        }
    }
}
