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
			this.сохранитьBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.работаСАвтобусамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.указатьПунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBusCardDialog = new System.Windows.Forms.OpenFileDialog();
			this.сохранитьКарточкиВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.прочитатьКарточкиИзExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.сохранитьBinToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьКарточкиВExcelToolStripMenuItem,
            this.прочитатьКарточкиИзExcelToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(359, 22);
			this.создатьToolStripMenuItem.Text = "Создать карточку автобуса";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
			// 
			// открытьКарточкуАвтобусаToolStripMenuItem
			// 
			this.открытьКарточкуАвтобусаToolStripMenuItem.Name = "открытьКарточкуАвтобусаToolStripMenuItem";
			this.открытьКарточкуАвтобусаToolStripMenuItem.Size = new System.Drawing.Size(359, 22);
			this.открытьКарточкуАвтобусаToolStripMenuItem.Text = "Открыть карточку автобуса";
			this.открытьКарточкуАвтобусаToolStripMenuItem.Click += new System.EventHandler(this.открытьКарточкуАвтобусаToolStripMenuItem_Click);
			// 
			// сохранитьBinToolStripMenuItem
			// 
			this.сохранитьBinToolStripMenuItem.Name = "сохранитьBinToolStripMenuItem";
			this.сохранитьBinToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.сохранитьBinToolStripMenuItem.Text = "Сохранить карточки автобусов в bin";
			this.сохранитьBinToolStripMenuItem.Click += new System.EventHandler(this.сохранитьBinToolStripMenuItem_Click);
			// 
			// загрузитьToolStripMenuItem
			// 
			this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
			this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(359, 22);
			this.загрузитьToolStripMenuItem.Text = "Прочитать из файла bin";
			this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(359, 22);
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
			// сохранитьКарточкиВExcelToolStripMenuItem
			// 
			this.сохранитьКарточкиВExcelToolStripMenuItem.Name = "сохранитьКарточкиВExcelToolStripMenuItem";
			this.сохранитьКарточкиВExcelToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.сохранитьКарточкиВExcelToolStripMenuItem.Text = "Сохранить карточки в Excel";
			// 
			// прочитатьКарточкиИзExcelToolStripMenuItem
			// 
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Name = "прочитатьКарточкиИзExcelToolStripMenuItem";
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.прочитатьКарточкиИзExcelToolStripMenuItem.Text = "Прочитать карточки из Excel";
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
	}
}

