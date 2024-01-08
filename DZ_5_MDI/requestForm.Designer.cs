namespace DZ_5_MDI
{
	partial class requestForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dateTimePicker_1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_destenation = new System.Windows.Forms.Label();
			this.textBox_Destination = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridMain = new System.Windows.Forms.DataGridView();
			this.BusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.70118F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.40448F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.00107F));
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lb_destenation, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox_Destination, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_search, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 100);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dateTimePicker_1
			// 
			this.dateTimePicker_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePicker_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker_1.Location = new System.Drawing.Point(374, 60);
			this.dateTimePicker_1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.dateTimePicker_1.Name = "dateTimePicker_1";
			this.dateTimePicker_1.Size = new System.Drawing.Size(306, 29);
			this.dateTimePicker_1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(365, 50);
			this.label2.TabIndex = 2;
			this.label2.Text = "Время прибытия";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_destenation
			// 
			this.lb_destenation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_destenation.AutoSize = true;
			this.lb_destenation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_destenation.Location = new System.Drawing.Point(3, 0);
			this.lb_destenation.Name = "lb_destenation";
			this.lb_destenation.Size = new System.Drawing.Size(365, 50);
			this.lb_destenation.TabIndex = 0;
			this.lb_destenation.Text = "Пункт назначения";
			this.lb_destenation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_Destination
			// 
			this.textBox_Destination.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Destination.Location = new System.Drawing.Point(374, 10);
			this.textBox_Destination.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.textBox_Destination.Name = "textBox_Destination";
			this.textBox_Destination.Size = new System.Drawing.Size(306, 29);
			this.textBox_Destination.TabIndex = 5;
			// 
			// btn_search
			// 
			this.btn_search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_search.Location = new System.Drawing.Point(686, 3);
			this.btn_search.Name = "btn_search";
			this.tableLayoutPanel1.SetRowSpan(this.btn_search, 2);
			this.btn_search.Size = new System.Drawing.Size(248, 94);
			this.btn_search.TabIndex = 6;
			this.btn_search.Text = "Поиск";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridMain);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 103);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(937, 379);
			this.panel1.TabIndex = 1;
			// 
			// dataGridMain
			// 
			this.dataGridMain.AllowUserToAddRows = false;
			this.dataGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BusNumber,
            this.BusType,
            this.Destination,
            this.DepartureDate,
            this.DepartureTime,
            this.ArrivalDate,
            this.ArrivalTime});
			this.dataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridMain.Location = new System.Drawing.Point(0, 0);
			this.dataGridMain.Name = "dataGridMain";
			this.dataGridMain.Size = new System.Drawing.Size(937, 379);
			this.dataGridMain.TabIndex = 0;
			// 
			// BusNumber
			// 
			this.BusNumber.HeaderText = "Номер автобуса";
			this.BusNumber.Name = "BusNumber";
			// 
			// BusType
			// 
			this.BusType.HeaderText = "Тип автобуса";
			this.BusType.Name = "BusType";
			// 
			// Destination
			// 
			this.Destination.HeaderText = "Пункт назначения";
			this.Destination.Name = "Destination";
			// 
			// DepartureDate
			// 
			this.DepartureDate.HeaderText = "Дата отправления";
			this.DepartureDate.Name = "DepartureDate";
			// 
			// DepartureTime
			// 
			this.DepartureTime.HeaderText = "Время отправления";
			this.DepartureTime.Name = "DepartureTime";
			// 
			// ArrivalDate
			// 
			this.ArrivalDate.HeaderText = "Дата прибытия";
			this.ArrivalDate.Name = "ArrivalDate";
			// 
			// ArrivalTime
			// 
			this.ArrivalTime.HeaderText = "Время прибытия";
			this.ArrivalTime.Name = "ArrivalTime";
			// 
			// requestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 482);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "requestForm";
			this.Text = "Поиск автобусов по запросу";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_destenation;
		private System.Windows.Forms.DateTimePicker dateTimePicker_1;
		private System.Windows.Forms.TextBox textBox_Destination;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridMain;
		private System.Windows.Forms.DataGridViewTextBoxColumn BusNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn BusType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
		private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
		private System.Windows.Forms.Button btn_search;
	}
}