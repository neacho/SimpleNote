namespace Note.Start
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Main_Container = new System.Windows.Forms.SplitContainer();
            this.tree_Navi = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_newNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_addFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delFile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_content = new System.Windows.Forms.GroupBox();
            this.txt_content = new System.Windows.Forms.RichTextBox();
            this.gbx_title = new System.Windows.Forms.GroupBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.fileinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Container)).BeginInit();
            this.Main_Container.Panel1.SuspendLayout();
            this.Main_Container.Panel2.SuspendLayout();
            this.Main_Container.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.gbx_content.SuspendLayout();
            this.gbx_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Container
            // 
            this.Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Container.Location = new System.Drawing.Point(0, 0);
            this.Main_Container.Name = "Main_Container";
            // 
            // Main_Container.Panel1
            // 
            this.Main_Container.Panel1.Controls.Add(this.tree_Navi);
            // 
            // Main_Container.Panel2
            // 
            this.Main_Container.Panel2.ContextMenuStrip = this.contextMenuStrip2;
            this.Main_Container.Panel2.Controls.Add(this.gbx_content);
            this.Main_Container.Panel2.Controls.Add(this.gbx_title);
            this.Main_Container.Size = new System.Drawing.Size(2374, 1225);
            this.Main_Container.SplitterDistance = 791;
            this.Main_Container.TabIndex = 0;
            // 
            // tree_Navi
            // 
            this.tree_Navi.ContextMenuStrip = this.contextMenuStrip1;
            this.tree_Navi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_Navi.Location = new System.Drawing.Point(0, 0);
            this.tree_Navi.Name = "tree_Navi";
            this.tree_Navi.Size = new System.Drawing.Size(791, 1225);
            this.tree_Navi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newNote,
            this.btn_delNote,
            this.btn_addFile,
            this.btn_delFile});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(282, 188);
            // 
            // btn_newNote
            // 
            this.btn_newNote.Name = "btn_newNote";
            this.btn_newNote.Size = new System.Drawing.Size(281, 46);
            this.btn_newNote.Text = "新增笔记本";
            // 
            // btn_delNote
            // 
            this.btn_delNote.Name = "btn_delNote";
            this.btn_delNote.Size = new System.Drawing.Size(281, 46);
            this.btn_delNote.Text = "删除笔记本";
            // 
            // btn_addFile
            // 
            this.btn_addFile.Name = "btn_addFile";
            this.btn_addFile.Size = new System.Drawing.Size(281, 46);
            this.btn_addFile.Text = "新增笔记";
            // 
            // btn_delFile
            // 
            this.btn_delFile.Name = "btn_delFile";
            this.btn_delFile.Size = new System.Drawing.Size(281, 46);
            this.btn_delFile.Text = "删除笔记";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 50);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 46);
            this.btnSave.Text = "保存";
            // 
            // gbx_content
            // 
            this.gbx_content.Controls.Add(this.txt_content);
            this.gbx_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_content.Location = new System.Drawing.Point(0, 167);
            this.gbx_content.Name = "gbx_content";
            this.gbx_content.Size = new System.Drawing.Size(1579, 1058);
            this.gbx_content.TabIndex = 1;
            this.gbx_content.TabStop = false;
            this.gbx_content.Text = "内容";
            // 
            // txt_content
            // 
            this.txt_content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fileinfoBindingSource, "File_Content", true));
            this.txt_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_content.Location = new System.Drawing.Point(3, 38);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(1573, 1017);
            this.txt_content.TabIndex = 0;
            this.txt_content.Text = "";
            // 
            // gbx_title
            // 
            this.gbx_title.Controls.Add(this.txt_title);
            this.gbx_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbx_title.Location = new System.Drawing.Point(0, 0);
            this.gbx_title.Name = "gbx_title";
            this.gbx_title.Size = new System.Drawing.Size(1579, 167);
            this.gbx_title.TabIndex = 0;
            this.gbx_title.TabStop = false;
            this.gbx_title.Text = "标题";
            // 
            // txt_title
            // 
            this.txt_title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fileinfoBindingSource, "File_Title", true));
            this.txt_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_title.Font = new System.Drawing.Font("宋体", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_title.Location = new System.Drawing.Point(3, 38);
            this.txt_title.MinimumSize = new System.Drawing.Size(4, 110);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(1573, 91);
            this.txt_title.TabIndex = 0;
            // 
            // fileinfoBindingSource
            // 
            this.fileinfoBindingSource.DataSource = typeof(Note.Core.Entity.file_info);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2374, 1225);
            this.Controls.Add(this.Main_Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "简易笔记";
            this.Main_Container.Panel1.ResumeLayout(false);
            this.Main_Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Container)).EndInit();
            this.Main_Container.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.gbx_content.ResumeLayout(false);
            this.gbx_title.ResumeLayout(false);
            this.gbx_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_Container;
        private System.Windows.Forms.TreeView tree_Navi;
        private System.Windows.Forms.GroupBox gbx_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.GroupBox gbx_content;
        private System.Windows.Forms.RichTextBox txt_content;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_newNote;
        private System.Windows.Forms.ToolStripMenuItem btn_delNote;
        private System.Windows.Forms.ToolStripMenuItem btn_addFile;
        private System.Windows.Forms.ToolStripMenuItem btn_delFile;
        private System.Windows.Forms.BindingSource fileinfoBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
    }
}

