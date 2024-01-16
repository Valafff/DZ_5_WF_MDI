using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using libxl;
using System.Linq;
using System.Data.OleDb;

namespace DZ_5_MDI
{

	public partial class MainForm : Form
	{
		//public static List<Bus> returnBuses(ref List<Bus> buses)
		//{
		//	return buses;
		//}
		public MainForm()
		{
			InitializeComponent();
			openBusCardDialog.Filter = "txt files (*.txt)|*.txt";
			//!!!!НЕ ДАЕТ СЛИВАТЬСЯ МЕНЮШКАМ ДОЧЕРНЕГО ЭЛЕМЕНТА С РОДИТЕЛЬСКИМ!!!!
			menuStrip1.AllowMerge = false;
		}

		//Для выборки
		public static List<Bus> buses = new List<Bus>();
		//Буфер для копирования данных из формы в форму
		public static Bus bufferBus = new Bus();
		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BusCardForm busCard = new BusCardForm();
			//Указывааем основную форму-контейнер Form1, isMdiContainer = true
			busCard.MdiParent = this;
			busCard.Show();
		}

		private void открытьКарточкуАвтобусаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult res = openBusCardDialog.ShowDialog(this);
			if (res == DialogResult.OK)
			{
				try
				{
					BusCardForm newBusCard = new BusCardForm();
					Bus newBus = new Bus();
					newBusCard.MdiParent = this;
					string path = openBusCardDialog.FileName;
					//List<string> data = new List<string>();
					using (var sr = new StreamReader(path))
					{
						newBusCard.path = path;
						newBus.BusNumber = Convert.ToInt32(sr.ReadLine());
						newBusCard.maskedTextBox_BusName.Text = newBus.BusNumber.ToString();
						newBus.BusType = sr.ReadLine();
						newBusCard.cb_busType.Text = newBus.BusType;
						newBus.Destination = sr.ReadLine();
						newBusCard.tb_Destenation.Text = newBus.Destination;
						newBus.DepartureDate = Convert.ToDateTime(sr.ReadLine());
						newBusCard.dateTimePicker_DepartureDate.Text = newBus.DepartureDate.ToString();
						newBus.TimeDeparture = Convert.ToDateTime(sr.ReadLine());
						newBusCard.dateTimePicker_DepartureTime.Text = newBus.TimeDeparture.ToShortTimeString();
						newBus.ArrivalDate = Convert.ToDateTime(sr.ReadLine());
						newBusCard.dateTimePicker_ArrivalDate.Text = newBus.ArrivalDate.ToString();
						newBus.ArrivalTime = Convert.ToDateTime(sr.ReadLine());
						newBusCard.dateTimePicker_ArrivalTime.Text = newBus.ArrivalTime.ToShortTimeString();
					}
					newBusCard.Text = $"Автобус № {newBusCard.maskedTextBox_BusName.Text}";

					buses.Add(newBus);
					newBusCard.Show();


				}
				catch (System.Exception)
				{
					MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void указатьПунктНазначенияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			requestForm requestForm = new requestForm();
			requestForm.Show();
		}

		private void сохранитьBinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MdiChildren.Count() != 0)
			{
				buses.Clear();
				foreach (var buscard in MdiChildren)
				{
					Bus temp = new Bus();
					temp.BusNumber = Convert.ToInt32(((BusCardForm)buscard).maskedTextBox_BusName.Text);
					temp.BusType = ((BusCardForm)buscard).cb_busType.Text;
					temp.Destination = ((BusCardForm)buscard).tb_Destenation.Text;
					temp.DepartureDate = ((BusCardForm)buscard).dateTimePicker_DepartureDate.Value;
					temp.TimeDeparture = ((BusCardForm)buscard).dateTimePicker_DepartureTime.Value;
					temp.ArrivalDate = ((BusCardForm)buscard).dateTimePicker_ArrivalDate.Value;
					temp.ArrivalTime = ((BusCardForm)buscard).dateTimePicker_ArrivalTime.Value;
					buses.Add(temp);
				}
				BinaryFormatter bf = new BinaryFormatter();
				try
				{
					using (var fstr = File.Create("Data.bin"))
					{
						bf.Serialize(fstr, buses);

						MessageBox.Show("Данные сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (System.Exception)
				{

					MessageBox.Show("Ошибка сериализации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Отсутствуют объекты для сериализации", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			//if (buses.Count != 0)
			//{
			//	BinaryFormatter bf = new BinaryFormatter();
			//	try
			//	{
			//		using (var fstr = File.Create("Data.bin"))
			//		{
			//			bf.Serialize(fstr, buses);

			//			MessageBox.Show("Данные сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//		}
			//	}
			//	catch (System.Exception)
			//	{

			//		MessageBox.Show("Ошибка сериализации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
			//else
			//{
			//	MessageBox.Show("Отсутствуют объекты для сериализации", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Очистка списка автобусов
			buses.Clear();
			//Закрытие всех активных форм в родительской MDI форме 
			while (MdiChildren.Count() > 0)
			{
				MdiChildren[0].Close();
			}

			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				using (var fstr = File.OpenRead("Data.bin"))
				{
					List<Bus> tempList = (List<Bus>)bf.Deserialize(fstr);
					buses = tempList;
					foreach (var bus in tempList)
					{
						BusCardForm bc = new BusCardForm();
						bc.maskedTextBox_BusName.Text = bus.BusNumber.ToString();
						bc.cb_busType.Text = bus.BusType.ToString();
						bc.tb_Destenation.Text = bus.Destination.ToString();
						bc.dateTimePicker_DepartureDate.Value = bus.DepartureDate;
						bc.dateTimePicker_DepartureTime.Value = bus.TimeDeparture;
						bc.dateTimePicker_ArrivalDate.Value = bus.ArrivalDate;
						bc.dateTimePicker_ArrivalTime.Value = bus.ArrivalTime;
						bc.MdiParent = this;
						bc.Show();
					}
					////Вывод форм каскадом
					//LayoutMdi(MdiLayout.Cascade);
					//Вывод форм по вертикали
					LayoutMdi(MdiLayout.TileVertical);
					////Вывод форм по горизонтали
					//LayoutMdi(MdiLayout.TileHorizontal);

					MessageBox.Show("Данные прочитаны", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (System.Exception)
			{
				MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void сохранитьКарточкиВExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Book book = new XmlBook();
			Sheet sheet = book.addSheet("Buses");
			try
			{
				sheet.writeStr(1, 0, "Номер автобуса");
				sheet.writeStr(1, 1, "Тип автобуса");
				sheet.writeStr(1, 2, "Пункт назначения");
				sheet.writeStr(1, 3, "Дата отправления");
				sheet.writeStr(1, 4, "Время отправления");
				sheet.writeStr(1, 5, "Дата прибытия");
				sheet.writeStr(1, 6, "Время прибытия");

				for (int i = 0; i < buses.Count; i++)
				{
					sheet.writeNum(i + 2, 0, buses[i].BusNumber);
					sheet.writeStr(i + 2, 1, buses[i].BusType);
					sheet.writeStr(i + 2, 2, buses[i].Destination);
					sheet.writeStr(i + 2, 3, buses[i].DepartureDate.ToShortDateString());
					sheet.writeStr(i + 2, 4, buses[i].TimeDeparture.ToShortTimeString());
					sheet.writeStr(i + 2, 5, buses[i].ArrivalDate.ToShortDateString());
					sheet.writeStr(i + 2, 6, buses[i].ArrivalTime.ToShortTimeString());

					//sheet.writeStr(i + 2, 3, buses[i].DepartureDate.ToString());
					//sheet.writeStr(i + 2, 4, buses[i].TimeDeparture.ToString());
					//sheet.writeStr(i + 2, 5, buses[i].ArrivalDate.ToString());
					//sheet.writeStr(i + 2, 6, buses[i].ArrivalTime.ToString());
				}
				book.save("Data.xlsx");
				MessageBox.Show("Данные записаны в Excel файл");
			}
			catch (System.Exception)
			{

				MessageBox.Show("Данные не записаны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void прочитатьКарточкиИзExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Очистка списка автобусов
			buses.Clear();
			//Закрытие всех активных форм в родительской MDI форме 
			while (MdiChildren.Count() > 0)
			{
				MdiChildren[0].Close();
			}

			Book book = new XmlBook();

			try
			{
				book.load("Data.xlsx");
				Sheet sheet = book.getSheet(0);
				if (sheet != null)
				{

					for (int row = sheet.firstRow()+2; row < sheet.lastRow(); row++)
					{

						BusCardForm bc = new BusCardForm();
						bc.maskedTextBox_BusName.Text = sheet.readStr(row, 0);					
						bc.cb_busType.Text = sheet.readStr(row, 1);
						bc.tb_Destenation.Text = sheet.readStr(row, 2);
						bc.dateTimePicker_DepartureDate.Text = sheet.readStr(row, 3);
						bc.dateTimePicker_DepartureTime.Text = sheet.readStr(row, 4);
						bc.dateTimePicker_ArrivalDate.Text = sheet.readStr(row, 5);
						bc.dateTimePicker_ArrivalTime.Text = sheet.readStr(row, 6);
						bc.MdiParent = this;
						bc.Show();

						Bus temp = new Bus();
						temp.BusNumber = Convert.ToInt32(bc.maskedTextBox_BusName.Text);
						temp.BusType = bc.cb_busType.Text;
						temp.Destination = bc.tb_Destenation.Text;
						temp.DepartureDate = bc.dateTimePicker_DepartureDate.Value;
						temp.TimeDeparture = bc.dateTimePicker_DepartureTime.Value;
						temp.ArrivalDate = bc.dateTimePicker_ArrivalDate.Value;
						temp.ArrivalTime = bc.dateTimePicker_ArrivalTime.Value;
						buses.Add(temp);
					}
					LayoutMdi(MdiLayout.TileVertical);
				}

			}
			catch (System.Exception)
			{

				MessageBox.Show("Данные не прочитаны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private string pass;
		public void setPass(string p)
		{
			pass = p;
		}

		private void записатьДанныеВDBAccessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//При создании новой формы передаю ссылку через аргумент на форму, которая будет принимать данные
			PassForm passForm = new PassForm(this);
			passForm.ShowDialog();
			DB_Using dB_Using = new DB_Using();
			//MessageBox.Show(pass);
			bool test = dB_Using.Connect(pass);
			if (test) { MessageBox.Show("Пароль принят. Соединение установлено."); }
			else
			{
				MessageBox.Show("Соединение не установлено");
			}
			try
			{
				dB_Using.reWriteDB(buses);
				MessageBox.Show("Данные записаны");
			}
			catch (System.Exception)
			{

				MessageBox.Show("Данные не записаны");
			}
			dB_Using.Disconnect();

	


		}

		private void прочитатьИзDBAccessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PassForm passForm = new PassForm(this);
			passForm.ShowDialog();
			DB_Using dB_Using = new DB_Using();
			bool test = dB_Using.Connect(pass);
			if (test) { MessageBox.Show("Пароль принят. Соединение установлено."); }
			else
			{
				MessageBox.Show("Соединение не установлено");
			}

			try
			{
				buses.Clear();
				buses = dB_Using.readFromDB();
				MessageBox.Show("Данные прочитаны");

				while (MdiChildren.Count() > 0)
				{
					MdiChildren[0].Close();
				}

				foreach (var bus in buses)
				{
					BusCardForm bc = new BusCardForm();
					bc.maskedTextBox_BusName.Text = bus.BusNumber.ToString();
					bc.cb_busType.Text = bus.BusType.ToString();
					bc.tb_Destenation.Text = bus.Destination.ToString();
					bc.dateTimePicker_DepartureDate.Value = bus.DepartureDate;
					bc.dateTimePicker_DepartureTime.Value = bus.TimeDeparture;
					bc.dateTimePicker_ArrivalDate.Value = bus.ArrivalDate;
					bc.dateTimePicker_ArrivalTime.Value = bus.ArrivalTime;
					bc.MdiParent = this;
					bc.Show();
				}
				LayoutMdi(MdiLayout.TileVertical);

			}
			catch (System.Exception)
			{

				MessageBox.Show("Данные не прочитаны");
			}
			dB_Using.Disconnect();

		}
	}

}
