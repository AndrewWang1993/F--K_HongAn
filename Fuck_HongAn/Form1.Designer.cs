namespace Fuck_HongAn
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("宏安1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("宏安2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("宏安3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("宏安", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.文件内外发管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件批量加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件批量解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外发文档制作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立即更新策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扩展ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.升级程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(91, 96);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "宏安1";
            treeNode2.Name = "节点2";
            treeNode2.Text = "宏安2";
            treeNode3.Name = "节点3";
            treeNode3.Text = "宏安3";
            treeNode4.Name = "节点0";
            treeNode4.Text = "宏安";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "宏安防泄密软件";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件内外发管理ToolStripMenuItem,
            this.toolStripSeparator1,
            this.文件批量加密ToolStripMenuItem,
            this.文件批量解密ToolStripMenuItem,
            this.外发文档制作ToolStripMenuItem,
            this.toolStripSeparator2,
            this.立即更新策略ToolStripMenuItem,
            this.扩展ToolStripMenuItem,
            this.toolStripSeparator3,
            this.升级程序ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 220);
            // 
            // 文件内外发管理ToolStripMenuItem
            // 
            this.文件内外发管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件内外发管理ToolStripMenuItem.Name = "文件内外发管理ToolStripMenuItem";
            this.文件内外发管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.文件内外发管理ToolStripMenuItem.Text = "文件内外发管理";
            // 
            // 文件批量加密ToolStripMenuItem
            // 
            this.文件批量加密ToolStripMenuItem.Name = "文件批量加密ToolStripMenuItem";
            this.文件批量加密ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.文件批量加密ToolStripMenuItem.Text = "文件批量加密";
            // 
            // 文件批量解密ToolStripMenuItem
            // 
            this.文件批量解密ToolStripMenuItem.Name = "文件批量解密ToolStripMenuItem";
            this.文件批量解密ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.文件批量解密ToolStripMenuItem.Text = "文件批量解密";
            // 
            // 外发文档制作ToolStripMenuItem
            // 
            this.外发文档制作ToolStripMenuItem.Name = "外发文档制作ToolStripMenuItem";
            this.外发文档制作ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.外发文档制作ToolStripMenuItem.Text = "外发文档制作";
            // 
            // 立即更新策略ToolStripMenuItem
            // 
            this.立即更新策略ToolStripMenuItem.Name = "立即更新策略ToolStripMenuItem";
            this.立即更新策略ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.立即更新策略ToolStripMenuItem.Text = "立即更新策略";
            // 
            // 扩展ToolStripMenuItem
            // 
            this.扩展ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.扩展ToolStripMenuItem.Name = "扩展ToolStripMenuItem";
            this.扩展ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.扩展ToolStripMenuItem.Text = "扩展";
            // 
            // 升级程序ToolStripMenuItem
            // 
            this.升级程序ToolStripMenuItem.Name = "升级程序ToolStripMenuItem";
            this.升级程序ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.升级程序ToolStripMenuItem.Text = "升级程序";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 303);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件内外发管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 文件批量加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件批量解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外发文档制作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 立即更新策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 扩展ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 升级程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

