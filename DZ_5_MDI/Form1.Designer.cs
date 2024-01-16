namespace DZ_5_MDI
{
	partial class MainForm
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
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьКарточкуАвтобусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьКарточкиВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.прочитатьКарточкиИзExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.записатьДанныеВDBAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.прочитатьИзDBAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.работаСАвтобусамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.указатьПунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBusCardDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.работаСАвтобусамиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1317, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьКарточкуАвтобусаToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьBinToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.сохранитьКарточкиВExcelToolStripMenuItem,
            this.прочитатьКарточкиИзExcelToolStripMenuItem,
            this.toolStripSeparator3,
            this.записатьДанныеВDBAccessToolStripMenuItem,
            this.прочитатьИзDBAccessToolStripMenuItem,
            this.toolStripSeparator4,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.создатьToolStripMenuItem.Text = "Создать карточку автобуса";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
			// 
			// открытьКарточкуАвтобусаToolStripMenuItem
			// 
			this.открытьКарточкуАвтобусаToolStripMenuItem.Name = "открытьКарточкуАвтобусаToolStripMenuItem";
			this.открытьКарточкуАвтобусаToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.открытьКарточкуАвтобусаToolStripMenuItem.Text = "Открыть карточку автобуса";
			this.открытьКарточкуАвтобусаToolStripMenuItem.Click += new System.EventHandler(this.открытьКарточкуАвтобусаToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(300, 6);
			// 
			// сохранитьBinToolStripMenuItem
			// 
			this.сохранитьBinToolStripMenuItem.Name = "сохранитьBinToolStripMenuItem";
			this.сохранитьBinToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.сохранитьBinToolStripMenuItem.Text = "Сохранить карточки автобусов в bin";
			this.сохранитьBinToolStripMenuItem.Click += new System.EventHandler(this.сохранитьBinToolStripMenuItem_Click);
			// 
			// загрузитьToolStripMenuItem
			// 
			this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
			this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.загрузитьToolStripMenuItem.Text = "Прочитать из файла bin";
			this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(300, 6);
			// 
			// сохранитьКарточкиВExcelToolStripMenuItem
			// 
			this.сохранитьКарточкиВExcelToolStripMenuItem.Name = "сохранитьКарточкиВExcelToolStripMenuItem";
			this.сохранитьКарточкиВExcelToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.сохранитьКарточкиВExcelToolStripMenuItem.Text = "Сохранить карточки в Excel";
			this.сохранитьКарточкиВExcelToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКарточкиВExcelToolStripMenuItem_Click);
			// 
			// прочитатьКарточкиИзExcelToolStripMenuItem
			// 
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Name = "прочитатьКарточкиИзExcelToolStripMenuItem";
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Text = "Прочитать карточки из Excel";
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Click += new System.EventHandler(this.прочитатьКарточкиИзExcelToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(300, 6);
			// 
			// записатьДанныеВDBAccessToolStripMenuItem
			// 
			this.записатьДанныеВDBAccessToolStripMenuItem.Name = "записатьДанныеВDBAccessToolStripMenuItem";
			this.записатьДанныеВDBAccessToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.записатьДанныеВDBAccessToolStripMenuItem.Text = "Записать данные в DB Access(пароль 123)";
			this.записатьДанныеВDBAccessToolStripMenuItem.Click += new System.EventHandler(this.записатьДанныеВDBAccessToolStripMenuItem_Click);
			// 
			// прочитатьИзDBAccessToolStripMenuItem
			// 
			this.прочитатьИзDBAccessToolStripMenuItem.Name = "прочитатьИзDBAccessToolStripMenuItem";
			this.прочитатьИзDBAccessToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
			this.прочитатьИзDBAccessToolStripMenuItem.Text = "Прочитать данные из DB Access(пароль 123)";
			this.прочитатьИзDBAccessToolStripMenuItem.Click += new System.EventHandler(this.прочитатьИзDBAccessToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(300, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// работаСАвтобусамиToolStripMenuItem
			// 
			this.работаСАвтобусамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.указатьПунктНазначенияToolStripMenuItem});
			this.работаСАвтобусамиToolStripMenuItem.Name = "работаСАвтобусамиToolStripMenuItem";
			this.работаСАвтобусамиToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
			this.работаСАвтобусамиToolStripMenuItem.Text = "Работа с автобусами";
			// 
			// указатьПунктНазначенияToolStripMenuItem
			// 
			this.указатьПунктНазначенияToolStripMenuItem.Name = "указатьПунктНазначенияToolStripMenuItem";
			this.указатьПунктНазначенияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.указатьПунктНазначенияToolStripMenuItem.Text = "Запрос данных о рейсах";
			this.указатьПунктНазначенияToolStripMenuItem.Click += new System.EventHandler(this.указатьПунктНазначенияToolStripMenuItem_Click);
			// 
			// openBusCardDialog
			// 
			this.openBusCardDialog.FileName = "openBusCardDialog";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1317, 729);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "My_MDI";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьBinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem работаСАвтобусамиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem указатьПунктНазначенияToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openBusCardDialog;
		private System.Windows.Forms.ToolStripMenuItem открытьКарточкуАвтобусаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКарточкиВExcelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem прочитатьКарточкиИзExcelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem прочитатьИзDBAccessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem записатьДанныеВDBAccessToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}

