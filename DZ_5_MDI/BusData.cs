using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_5_MDI
{
	public partial class BusCardForm : Form
	{
		public BusCardForm()
		{
			InitializeComponent();
			saveBusCardDialog.Filter = "txt files (*.txt)|*.txt";
		}
		public string path = null;
		//Если имя отсутствует, форма имеет общее название
		private void maskedTextBox_BusName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			Text = $"Автобус № {maskedTextBox_BusName.Text}";
			if (maskedTextBox_BusName.Text == "")
			{
				Text = "Карточка автобуса";
			}
		}
		void save(string arg_path)
		{
			Bus someBus = new Bus
			{
				BusNumber = Convert.ToInt32(maskedTextBox_BusName.Text),
				BusType = cb_busType.Text,
				Destination = tb_Destenation.Text,
				DepartureDate = Convert.ToDateTime(dateTimePicker_DepartureDate.Text),
				TimeDeparture = Convert.ToDateTime(dateTimePicker_DepartureTime.Text),
				ArrivalDate = Convert.ToDateTime(dateTimePicker_ArrivalDate.Text),
				ArrivalTime = Convert.ToDateTime(dateTimePicker_ArrivalTime.Text)
			};
			//string path = saveBusCardDialog.FileName;
			using (var sw = new StreamWriter(arg_path))
			{
				this.path = arg_path;
				sw.WriteLine(someBus.BusNumber);
				sw.WriteLine(someBus.BusType);
				sw.WriteLine(someBus.Destination);
				sw.WriteLine(someBus.DepartureDate.ToString());
				sw.WriteLine(someBus.TimeDeparture.ToString());
				sw.WriteLine(someBus.ArrivalDate.ToString());
				sw.WriteLine(someBus.ArrivalTime.ToString());
				MainForm.buses.Add(someBus);

				MessageBox.Show("Файл сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
		}
		void saveAs()
		{
			try
			{
				DialogResult res = saveBusCardDialog.ShowDialog(this);
				if (res == DialogResult.OK)
				{
					save(saveBusCardDialog.FileName);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Сохранение не произведено. Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (path == null)
			{
				saveAs();
			}
			else
			{
				try
				{
					save(path);
				}
				catch (Exception)
				{
					MessageBox.Show("Сохранение не произведено. Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveAs();
		}

		private void копироватьВБуфферToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MainForm.bufferBus.BusNumber = Convert.ToInt32(maskedTextBox_BusName.Text);
				MainForm.bufferBus.BusType = cb_busType.Text;
				MainForm.bufferBus.Destination = tb_Destenation.Text;
				MainForm.bufferBus.DepartureDate = Convert.ToDateTime(dateTimePicker_DepartureDate.Text);
				MainForm.bufferBus.TimeDeparture = Convert.ToDateTime(dateTimePicker_DepartureTime.Text);
				MainForm.bufferBus.ArrivalDate = Convert.ToDateTime(dateTimePicker_ArrivalDate.Text);
				MainForm.bufferBus.ArrivalTime = Convert.ToDateTime(dateTimePicker_ArrivalTime.Text);
				MessageBox.Show("Данные скопированы", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show("Данные не скопированы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void вставитьИзБуффераToolStripMenuItem_Click(object sender, EventArgs e)
		{
			maskedTextBox_BusName.Text = MainForm.bufferBus.BusNumber.ToString();
			cb_busType.Text = MainForm.bufferBus.BusType.ToString();
			tb_Destenation.Text = MainForm.bufferBus.Destination;
			dateTimePicker_DepartureDate.Text = MainForm.bufferBus.DepartureDate.ToString();
			dateTimePicker_DepartureTime.Text = MainForm.bufferBus.TimeDeparture.ToString();
			dateTimePicker_ArrivalDate.Text = MainForm.bufferBus.ArrivalDate.ToString();
			dateTimePicker_ArrivalTime.Text = MainForm.bufferBus.ArrivalTime.ToString();
		}

		//private void maskedTextBox_DepartureTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		//{
		//	maskedTextBox_DepartureTime.Text = "23:59";
		//}

		//private void maskedTextBox_ArrivalTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		//{
		//	maskedTextBox_ArrivalTime.Text = "23:59";
		//}

	}
}
