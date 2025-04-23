namespace patlab3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Panel panel7;
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnElev2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnElev3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUnload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCurWeight = new System.Windows.Forms.Label();
            this.txtMaxWeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timerRestock = new System.Windows.Forms.Timer(this.components);
            this.numUnload = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gridFloors = new System.Windows.Forms.DataGridView();
            this.elev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOutage = new System.Windows.Forms.Label();
            this.figFloor = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtLoadFloor = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFloorSign = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFloors)).BeginInit();
            this.figFloor.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFloor
            // 
            this.btnFloor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFloor.Location = new System.Drawing.Point(26, 162);
            this.btnFloor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(50, 50);
            this.btnFloor.TabIndex = 0;
            this.btnFloor.Text = "1";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // btnElev2
            // 
            this.btnElev2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnElev2.Location = new System.Drawing.Point(96, 162);
            this.btnElev2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElev2.Name = "btnElev2";
            this.btnElev2.Size = new System.Drawing.Size(50, 50);
            this.btnElev2.TabIndex = 1;
            this.btnElev2.Text = "2";
            this.btnElev2.UseVisualStyleBackColor = true;
            this.btnElev2.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(96, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // btnElev3
            // 
            this.btnElev3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElev3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnElev3.Location = new System.Drawing.Point(26, 91);
            this.btnElev3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElev3.Name = "btnElev3";
            this.btnElev3.Size = new System.Drawing.Size(50, 50);
            this.btnElev3.TabIndex = 2;
            this.btnElev3.Text = "3";
            this.btnElev3.UseVisualStyleBackColor = true;
            this.btnElev3.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(96, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(26, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnFloor);
            this.panel1.Controls.Add(this.btnElev2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnElev3);
            this.panel1.Location = new System.Drawing.Point(63, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 236);
            this.panel1.TabIndex = 6;
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.Gold;
            this.btnPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPower.Location = new System.Drawing.Point(73, 556);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(148, 82);
            this.btnPower.TabIndex = 7;
            this.btnPower.Text = "ПИТАНИЕ";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numUnload);
            this.panel3.Controls.Add(this.btnUnload);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtFloor);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnPower);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(751, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 692);
            this.panel3.TabIndex = 9;
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(63, 227);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(98, 45);
            this.btnUnload.TabIndex = 13;
            this.btnUnload.Text = "Выгрузить";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(116, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вес";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.txtCurWeight);
            this.panel4.Controls.Add(this.txtMaxWeight);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(63, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 40);
            this.panel4.TabIndex = 9;
            // 
            // txtCurWeight
            // 
            this.txtCurWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCurWeight.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtCurWeight.Location = new System.Drawing.Point(3, 4);
            this.txtCurWeight.Name = "txtCurWeight";
            this.txtCurWeight.Size = new System.Drawing.Size(72, 33);
            this.txtCurWeight.TabIndex = 2;
            this.txtCurWeight.Text = "0";
            this.txtCurWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaxWeight
            // 
            this.txtMaxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMaxWeight.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtMaxWeight.Location = new System.Drawing.Point(95, 4);
            this.txtMaxWeight.Name = "txtMaxWeight";
            this.txtMaxWeight.Size = new System.Drawing.Size(71, 33);
            this.txtMaxWeight.TabIndex = 1;
            this.txtMaxWeight.Text = "0";
            this.txtMaxWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(74, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "/";
            // 
            // txtFloor
            // 
            this.txtFloor.AutoSize = true;
            this.txtFloor.BackColor = System.Drawing.Color.Black;
            this.txtFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFloor.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtFloor.Location = new System.Drawing.Point(114, 35);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(69, 73);
            this.txtFloor.TabIndex = 8;
            this.txtFloor.Text = "1";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(517, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(12, 874);
            this.panel8.TabIndex = 12;
            // 
            // timerRestock
            // 
            this.timerRestock.Enabled = true;
            this.timerRestock.Interval = 3000;
            this.timerRestock.Tick += new System.EventHandler(this.timerRestock_Tick);
            // 
            // numUnload
            // 
            this.numUnload.BackColor = System.Drawing.Color.Black;
            this.numUnload.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUnload.ForeColor = System.Drawing.Color.LimeGreen;
            this.numUnload.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUnload.Location = new System.Drawing.Point(167, 233);
            this.numUnload.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUnload.Name = "numUnload";
            this.numUnload.Size = new System.Drawing.Size(66, 34);
            this.numUnload.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtOutage);
            this.panel2.Controls.Add(this.gridFloors);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 692);
            this.panel2.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.Location = new System.Drawing.Point(280, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(471, 458);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Этажи";
            // 
            // gridFloors
            // 
            this.gridFloors.AllowUserToAddRows = false;
            this.gridFloors.AllowUserToDeleteRows = false;
            this.gridFloors.AllowUserToResizeColumns = false;
            this.gridFloors.AllowUserToResizeRows = false;
            this.gridFloors.BackgroundColor = System.Drawing.Color.Black;
            this.gridFloors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFloors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFloors.ColumnHeadersVisible = false;
            this.gridFloors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.load,
            this.elev});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFloors.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridFloors.GridColor = System.Drawing.Color.Black;
            this.gridFloors.Location = new System.Drawing.Point(17, 70);
            this.gridFloors.Name = "gridFloors";
            this.gridFloors.ReadOnly = true;
            this.gridFloors.RowHeadersVisible = false;
            this.gridFloors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFloors.RowTemplate.Height = 40;
            this.gridFloors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridFloors.Size = new System.Drawing.Size(240, 246);
            this.gridFloors.TabIndex = 2;
            // 
            // elev
            // 
            this.elev.HeaderText = "elev";
            this.elev.Name = "elev";
            this.elev.ReadOnly = true;
            this.elev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.elev.Width = 60;
            // 
            // load
            // 
            this.load.HeaderText = "load";
            this.load.Name = "load";
            this.load.ReadOnly = true;
            this.load.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.load.Width = 140;
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.num.Width = 40;
            // 
            // txtOutage
            // 
            this.txtOutage.BackColor = System.Drawing.Color.Black;
            this.txtOutage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutage.ForeColor = System.Drawing.Color.Red;
            this.txtOutage.Location = new System.Drawing.Point(18, 71);
            this.txtOutage.Name = "txtOutage";
            this.txtOutage.Size = new System.Drawing.Size(238, 245);
            this.txtOutage.TabIndex = 3;
            this.txtOutage.Text = "ПОЛОМКА";
            this.txtOutage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOutage.Visible = false;
            // 
            // figFloor
            // 
            this.figFloor.BackColor = System.Drawing.Color.DarkKhaki;
            this.figFloor.Controls.Add(this.txtFloorSign);
            this.figFloor.Controls.Add(this.panel5);
            this.figFloor.Controls.Add(panel7);
            this.figFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figFloor.Location = new System.Drawing.Point(278, 0);
            this.figFloor.Name = "figFloor";
            this.figFloor.Size = new System.Drawing.Size(473, 692);
            this.figFloor.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.Color.Khaki;
            panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel7.Location = new System.Drawing.Point(0, 393);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(473, 299);
            panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnLoad);
            this.panel5.Controls.Add(this.txtLoadFloor);
            this.panel5.Location = new System.Drawing.Point(58, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 255);
            this.panel5.TabIndex = 11;
            // 
            // txtLoadFloor
            // 
            this.txtLoadFloor.BackColor = System.Drawing.Color.Peru;
            this.txtLoadFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLoadFloor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtLoadFloor.Location = new System.Drawing.Point(22, 19);
            this.txtLoadFloor.Name = "txtLoadFloor";
            this.txtLoadFloor.Size = new System.Drawing.Size(239, 218);
            this.txtLoadFloor.TabIndex = 0;
            this.txtLoadFloor.Text = "0";
            this.txtLoadFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(167, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 45);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFloorSign
            // 
            this.txtFloorSign.AutoSize = true;
            this.txtFloorSign.Font = new System.Drawing.Font("Franklin Gothic Medium", 128.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFloorSign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFloorSign.Location = new System.Drawing.Point(283, -68);
            this.txtFloorSign.Name = "txtFloorSign";
            this.txtFloorSign.Size = new System.Drawing.Size(191, 215);
            this.txtFloorSign.TabIndex = 1;
            this.txtFloorSign.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1043, 692);
            this.Controls.Add(this.figFloor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFloors)).EndInit();
            this.figFloor.ResumeLayout(false);
            this.figFloor.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnElev2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnElev3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtCurWeight;
        private System.Windows.Forms.Label txtMaxWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timerRestock;
        private System.Windows.Forms.NumericUpDown numUnload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtOutage;
        private System.Windows.Forms.DataGridView gridFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn load;
        private System.Windows.Forms.DataGridViewTextBoxColumn elev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel figFloor;
        private System.Windows.Forms.Label txtFloorSign;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label txtLoadFloor;
    }
}

