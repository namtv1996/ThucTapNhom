namespace QuanLyNhanSu
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thêm");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sửa");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Xóa");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hướng dẫn");
            this.tre = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tre
            // 
            this.tre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tre.Dock = System.Windows.Forms.DockStyle.Left;
            this.tre.Location = new System.Drawing.Point(0, 0);
            this.tre.Name = "tre";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode1.Name = "Them";
            treeNode1.Text = "Thêm";
            treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode2.Name = "sua";
            treeNode2.Text = "Sửa";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode3.Name = "xoa";
            treeNode3.Text = "Xóa";
            treeNode4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode4.Name = "huongdan";
            treeNode4.Text = "Hướng dẫn";
            this.tre.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.tre.Size = new System.Drawing.Size(121, 497);
            this.tre.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(121, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(615, 497);
            this.pnlMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 497);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tre);
            this.Name = "Form1";
            this.Text = "Quản Lý Nhân Sự";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tre;
        private System.Windows.Forms.Panel pnlMain;
    }
}

