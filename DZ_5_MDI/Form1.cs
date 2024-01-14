using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using libxl;
using System.Linq;

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
			while (MdiChildren.Count()>0)
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
	}

}
