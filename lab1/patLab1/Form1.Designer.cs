namespace patLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listNotes = new System.Windows.Forms.ListBox();
            this.edTitle = new System.Windows.Forms.TextBox();
            this.edContent = new System.Windows.Forms.RichTextBox();
            this.btnNewText = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnNewCheck = new System.Windows.Forms.Button();
            this.listDone = new System.Windows.Forms.CheckedListBox();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.edTaskName = new System.Windows.Forms.TextBox();
            this.panelCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNotes
            // 
            this.listNotes.FormattingEnabled = true;
            this.listNotes.ItemHeight = 20;
            this.listNotes.Location = new System.Drawing.Point(12, 20);
            this.listNotes.Name = "listNotes";
            this.listNotes.Size = new System.Drawing.Size(161, 444);
            this.listNotes.TabIndex = 0;
            this.listNotes.SelectedIndexChanged += new System.EventHandler(this.listNotes_SelectedIndexChanged);
            // 
            // edTitle
            // 
            this.edTitle.Location = new System.Drawing.Point(226, 20);
            this.edTitle.Name = "edTitle";
            this.edTitle.Size = new System.Drawing.Size(689, 26);
            this.edTitle.TabIndex = 1;
            this.edTitle.Leave += new System.EventHandler(this.edTitle_Leave);
            // 
            // edContent
            // 
            this.edContent.Location = new System.Drawing.Point(223, 62);
            this.edContent.Name = "edContent";
            this.edContent.Size = new System.Drawing.Size(692, 507);
            this.edContent.TabIndex = 2;
            this.edContent.Text = "";
            this.edContent.Leave += new System.EventHandler(this.edContent_Leave);
            // 
            // btnNewText
            // 
            this.btnNewText.Location = new System.Drawing.Point(12, 472);
            this.btnNewText.Name = "btnNewText";
            this.btnNewText.Size = new System.Drawing.Size(161, 33);
            this.btnNewText.TabIndex = 3;
            this.btnNewText.Text = "New text";
            this.btnNewText.UseVisualStyleBackColor = true;
            this.btnNewText.Click += new System.EventHandler(this.btnNewText_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(91, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 550);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(73, 33);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Clone";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnNewCheck
            // 
            this.btnNewCheck.Location = new System.Drawing.Point(12, 511);
            this.btnNewCheck.Name = "btnNewCheck";
            this.btnNewCheck.Size = new System.Drawing.Size(161, 33);
            this.btnNewCheck.TabIndex = 7;
            this.btnNewCheck.Text = "New check";
            this.btnNewCheck.UseVisualStyleBackColor = true;
            this.btnNewCheck.Click += new System.EventHandler(this.btnNewCheck_Click);
            // 
            // listDone
            // 
            this.listDone.FormattingEnabled = true;
            this.listDone.Location = new System.Drawing.Point(3, 80);
            this.listDone.Name = "listDone";
            this.listDone.Size = new System.Drawing.Size(686, 424);
            this.listDone.TabIndex = 8;
            this.listDone.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listDone_ItemCheck);
            // 
            // panelCheck
            // 
            this.panelCheck.Controls.Add(this.btnDeleteTask);
            this.panelCheck.Controls.Add(this.btnAddTask);
            this.panelCheck.Controls.Add(this.edTaskName);
            this.panelCheck.Controls.Add(this.listDone);
            this.panelCheck.Location = new System.Drawing.Point(223, 62);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(692, 507);
            this.panelCheck.TabIndex = 9;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(604, 42);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(85, 33);
            this.btnDeleteTask.TabIndex = 11;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(604, 3);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(85, 33);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // edTaskName
            // 
            this.edTaskName.Location = new System.Drawing.Point(3, 6);
            this.edTaskName.Name = "edTaskName";
            this.edTaskName.Size = new System.Drawing.Size(590, 26);
            this.edTaskName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.btnNewCheck);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewText);
            this.Controls.Add(this.edContent);
            this.Controls.Add(this.edTitle);
            this.Controls.Add(this.listNotes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNotes;
        private System.Windows.Forms.TextBox edTitle;
        private System.Windows.Forms.RichTextBox edContent;
        private System.Windows.Forms.Button btnNewText;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnNewCheck;
        private System.Windows.Forms.CheckedListBox listDone;
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox edTaskName;
    }
}

