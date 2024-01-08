namespace DZ_5_MDI
{
	partial class BusCardForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьВБуфферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вставитьИзБуффераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maskedTextBox_BusName = new System.Windows.Forms.MaskedTextBox();
			this.dateTimePicker_DepartureDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_Destenation = new System.Windows.Forms.TextBox();
			this.dateTimePicker_ArrivalDate = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cb_busType = new System.Windows.Forms.ComboBox();
			this.saveBusCardDialog = new System.Windows.Forms.SaveFileDialog();
			this.dateTimePicker_DepartureTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_ArrivalTime = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AllowItemReorder = true;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(384, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.закрытьToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
			this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
			// 
			// закрытьToolStripMenuItem
			// 
			this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
			this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.закрытьToolStripMenuItem.Text = "Закрыть";
			// 
			// редактированиеToolStripMenuItem
			// 
			this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьВБуфферToolStripMenuItem,
            this.вставитьИзБуффераToolStripMenuItem});
			this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
			this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
			this.редактированиеToolStripMenuItem.Text = "Редактирование";
			// 
			// копироватьВБуфферToolStripMenuItem
			// 
			this.копироватьВБуфферToolStripMenuItem.Name = "копироватьВБуфферToolStripMenuItem";
			this.копироватьВБуфферToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.копироватьВБуфферToolStripMenuItem.Text = "Копировать в буфер";
			this.копироватьВБуфферToolStripMenuItem.Click += new System.EventHandler(this.копироватьВБуфферToolStripMenuItem_Click);
			// 
			// вставитьИзБуффераToolStripMenuItem
			// 
			this.вставитьИзБуффераToolStripMenuItem.Name = "вставитьИзБуффераToolStripMenuItem";
			this.вставитьИзБуффераToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.вставитьИзБуффераToolStripMenuItem.Text = "Вставить из буфера";
			this.вставитьИзБуффераToolStripMenuItem.Click += new System.EventHandler(this.вставитьИзБуффераToolStripMenuItem_Click);
			// 
			// maskedTextBox_BusName
			// 
			this.maskedTextBox_BusName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maskedTextBox_BusName.Location = new System.Drawing.Point(198, 1);
			this.maskedTextBox_BusName.Margin = new System.Windows.Forms.Padding(0);
			this.maskedTextBox_BusName.Mask = "00000";
			this.maskedTextBox_BusName.Name = "maskedTextBox_BusName";
			this.maskedTextBox_BusName.Size = new System.Drawing.Size(185, 20);
			this.maskedTextBox_BusName.TabIndex = 7;
			this.maskedTextBox_BusName.ValidatingType = typeof(int);
			this.maskedTextBox_BusName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_BusName_MaskInputRejected);
			// 
			// dateTimePicker_DepartureDate
			// 
			this.dateTimePicker_DepartureDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_DepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_DepartureDate.Location = new System.Drawing.Point(198, 67);
			this.dateTimePicker_DepartureDate.Margin = new System.Windows.Forms.Padding(0);
			this.dateTimePicker_DepartureDate.Name = "dateTimePicker_DepartureDate";
			this.dateTimePicker_DepartureDate.Size = new System.Drawing.Size(185, 22);
			this.dateTimePicker_DepartureDate.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Номер автобуса";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(4, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Тип автобуса";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(4, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Пункт назначения";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(4, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Дата отправления";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(4, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Время отправления";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(4, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(190, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "Дата прибытия";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(4, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(190, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Время прибытия";
			// 
			// tb_Destenation
			// 
			this.tb_Destenation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Destenation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_Destenation.Location = new System.Drawing.Point(198, 45);
			this.tb_Destenation.Margin = new System.Windows.Forms.Padding(0);
			this.tb_Destenation.Name = "tb_Destenation";
			this.tb_Destenation.Size = new System.Drawing.Size(185, 22);
			this.tb_Destenation.TabIndex = 9;
			// 
			// dateTimePicker_ArrivalDate
			// 
			this.dateTimePicker_ArrivalDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_ArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_ArrivalDate.Location = new System.Drawing.Point(198, 111);
			this.dateTimePicker_ArrivalDate.Margin = new System.Windows.Forms.Padding(0);
			this.dateTimePicker_ArrivalDate.Name = "dateTimePicker_ArrivalDate";
			this.dateTimePicker_ArrivalDate.Size = new System.Drawing.Size(185, 22);
			this.dateTimePicker_ArrivalDate.TabIndex = 12;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49701F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50299F));
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_ArrivalTime, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_DepartureTime, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_ArrivalDate, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.tb_Destenation, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_DepartureDate, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBox_BusName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.cb_busType, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 157);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// cb_busType
			// 
			this.cb_busType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cb_busType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_busType.FormattingEnabled = true;
			this.cb_busType.Items.AddRange(new object[] {
            "Городской",
            "Пригородный",
            "Междугородный",
            "Туристический"});
			this.cb_busType.Location = new System.Drawing.Point(198, 23);
			this.cb_busType.Margin = new System.Windows.Forms.Padding(0);
			this.cb_busType.Name = "cb_busType";
			this.cb_busType.Size = new System.Drawing.Size(185, 23);
			this.cb_busType.TabIndex = 15;
			// 
			// dateTimePicker_DepartureTime
			// 
			this.dateTimePicker_DepartureTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_DepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_DepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker_DepartureTime.Location = new System.Drawing.Point(198, 89);
			this.dateTimePicker_DepartureTime.Margin = new System.Windows.Forms.Padding(0);
			this.dateTimePicker_DepartureTime.Name = "dateTimePicker_DepartureTime";
			this.dateTimePicker_DepartureTime.Size = new System.Drawing.Size(185, 22);
			this.dateTimePicker_DepartureTime.TabIndex = 16;
			// 
			// dateTimePicker_ArrivalTime
			// 
			this.dateTimePicker_ArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_ArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_ArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker_ArrivalTime.Location = new System.Drawing.Point(198, 133);
			this.dateTimePicker_ArrivalTime.Margin = new System.Windows.Forms.Padding(0);
			this.dateTimePicker_ArrivalTime.Name = "dateTimePicker_ArrivalTime";
			this.dateTimePicker_ArrivalTime.Size = new System.Drawing.Size(185, 22);
			this.dateTimePicker_ArrivalTime.TabIndex = 17;
			// 
			// BusCardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 181);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "BusCardForm";
			this.Text = "Карточка автобуса";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem копироватьВБуфферToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вставитьИзБуффераToolStripMenuItem;
		public System.Windows.Forms.MaskedTextBox maskedTextBox_BusName;
		public System.Windows.Forms.DateTimePicker dateTimePicker_DepartureDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox tb_Destenation;
		public System.Windows.Forms.DateTimePicker dateTimePicker_ArrivalDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.ComboBox cb_busType;
		private System.Windows.Forms.SaveFileDialog saveBusCardDialog;
		public System.Windows.Forms.DateTimePicker dateTimePicker_ArrivalTime;
		public System.Windows.Forms.DateTimePicker dateTimePicker_DepartureTime;
	}
}