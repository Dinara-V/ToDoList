namespace ToDoList
{
    partial class ToDoL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTaskBTN = new System.Windows.Forms.Button();
            this.MyTasksDG = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteRT = new System.Windows.Forms.RichTextBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            // 
            // NewTaskBTN
            // 
            this.NewTaskBTN.Location = new System.Drawing.Point(13, 13);
            this.NewTaskBTN.Name = "NewTaskBTN";
            this.NewTaskBTN.Size = new System.Drawing.Size(75, 23);
            this.NewTaskBTN.TabIndex = 0;
            this.NewTaskBTN.Text = "button1";
            this.NewTaskBTN.UseVisualStyleBackColor = true;
            this.NewTaskBTN.Click += new System.EventHandler(this.NewTaskBTN_Click);
            // 
            // MyTasksDG
            // 
            this.MyTasksDG.AllowUserToAddRows = false;
            this.MyTasksDG.AllowUserToDeleteRows = false;
            this.MyTasksDG.AllowUserToResizeRows = false;
            this.MyTasksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTasksDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.MyTasksDG.Location = new System.Drawing.Point(0, 50);
            this.MyTasksDG.MultiSelect = false;
            this.MyTasksDG.Name = "MyTasksDG";
            this.MyTasksDG.ReadOnly = true;
            this.MyTasksDG.RowHeadersVisible = false;
            this.MyTasksDG.Size = new System.Drawing.Size(669, 400);
            this.MyTasksDG.TabIndex = 1;
            this.MyTasksDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyTasksDG_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveBTN);
            this.panel2.Controls.Add(this.DownloadBTN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.statusCB);
            this.panel2.Controls.Add(this.noteRT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(669, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(131, 400);
            this.panel2.TabIndex = 2;
            // 
            // noteRT
            // 
            this.noteRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.noteRT.Location = new System.Drawing.Point(5, 5);
            this.noteRT.Name = "noteRT";
            this.noteRT.Size = new System.Drawing.Size(121, 119);
            this.noteRT.TabIndex = 0;
            this.noteRT.Text = "";
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "в разработке",
            "завершено",
            "не начато",
            "отложено"});
            this.statusCB.Location = new System.Drawing.Point(8, 140);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(112, 21);
            this.statusCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус";
            // 
            // DownloadBTN
            // 
            this.DownloadBTN.Location = new System.Drawing.Point(8, 192);
            this.DownloadBTN.Name = "DownloadBTN";
            this.DownloadBTN.Size = new System.Drawing.Size(112, 23);
            this.DownloadBTN.TabIndex = 3;
            this.DownloadBTN.Text = "Дополнительно";
            this.DownloadBTN.UseVisualStyleBackColor = true;
            this.DownloadBTN.Click += new System.EventHandler(this.DownloadBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(8, 222);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(112, 23);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // ToDoL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MyTasksDG);
            this.Controls.Add(this.panel1);
            this.Name = "ToDoL";
            this.Text = "Список задач";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDoL_FormClosed);
            this.Load += new System.EventHandler(this.ToDoL_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewTaskBTN;
        private System.Windows.Forms.DataGridView MyTasksDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button DownloadBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.RichTextBox noteRT;
    }
}