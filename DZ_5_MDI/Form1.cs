using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

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
						newBus.BusNumber = Convert.ToInt32( sr.ReadLine());
						newBusCard.maskedTextBox_BusName.Text = newBus.BusNumber.ToString();
						newBus.BusType = sr.ReadLine();
						newBusCard.cb_busType.Text = newBus.BusType;
						newBus.Destination = sr.ReadLine();
						newBusCard.tb_Destenation.Text = newBus.Destination;
						newBus.DepartureDate = Convert.ToDateTime( sr.ReadLine());
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
				catch (Exception)
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
			if (buses.Count !=0)
			{
				BinaryFormatter bf = new BinaryFormatter();
				try
				{
					using (var fstr = File.Create("Data.bin"))
					{
						bf.Serialize(fstr, buses);

						MessageBox.Show("Данные сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (Exception)
				{

					MessageBox.Show("Ошибка сериализации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Отсутствуют объекты для сериализации", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				using (var fstr = File.OpenRead("Data.bin"))
				{
					List<Bus> tempList = (List<Bus>)bf.Deserialize(fstr);
					buses = tempList;
					MessageBox.Show("Данные прочитаны", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

}
