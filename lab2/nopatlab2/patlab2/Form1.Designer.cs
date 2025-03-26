namespace patlab2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.edPath = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.labelError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edFileName = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь:";
            // 
            // edPath
            // 
            this.edPath.Location = new System.Drawing.Point(66, 24);
            this.edPath.Name = "edPath";
            this.edPath.Size = new System.Drawing.Size(458, 26);
            this.edPath.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(569, 21);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(88, 33);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Анализ";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(522, 24);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(28, 26);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "▼";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToAddRows = false;
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.AllowUserToResizeColumns = false;
            this.gridResult.AllowUserToResizeRows = false;
            this.gridResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.size,
            this.comp});
            this.gridResult.Location = new System.Drawing.Point(12, 116);
            this.gridResult.Name = "gridResult";
            this.gridResult.RowHeadersVisible = false;
            this.gridResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResult.Size = new System.Drawing.Size(1000, 554);
            this.gridResult.TabIndex = 4;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelError.Location = new System.Drawing.Point(682, 30);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(196, 20);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Ошибка: Путь не найден";
            this.labelError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Файл:";
            // 
            // edFileName
            // 
            this.edFileName.Location = new System.Drawing.Point(66, 68);
            this.edFileName.Name = "edFileName";
            this.edFileName.Size = new System.Drawing.Size(484, 26);
            this.edFileName.TabIndex = 7;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(569, 65);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(88, 33);
            this.btnCreateFile.TabIndex = 8;
            this.btnCreateFile.Text = "Создать";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFile.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelFile.Location = new System.Drawing.Point(682, 71);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(200, 20);
            this.labelFile.TabIndex = 9;
            this.labelFile.Text = "Ошибка: Файл не создан";
            this.labelFile.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 825;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.size.DefaultCellStyle = dataGridViewCellStyle1;
            this.size.HeaderText = "Размер";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.size.Width = 155;
            // 
            // comp
            // 
            this.comp.HeaderText = "Объект";
            this.comp.Name = "comp";
            this.comp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 681);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.edFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.edPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edPath;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edFileName;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp;
    }
}

