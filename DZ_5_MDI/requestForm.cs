using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_5_MDI
{
	public partial class requestForm : Form
	{
		public requestForm()
		{
			InitializeComponent();
		}
		void addToGrid(ref List<Bus> arg_Buses)
		{
			//Добавляю элементы в таблицу
			foreach (var item in arg_Buses)
			{
				dataGridMain.Rows.Add(item.BusNumber, item.BusType, item.Destination, item.DepartureDate.ToString(), item.TimeDeparture.ToShortTimeString(), item.ArrivalDate.ToString(), item.ArrivalTime.ToShortTimeString());
			}
		}
		private void btn_search_Click(object sender, EventArgs e)
		{
			dataGridMain.Rows.Clear();
			if (textBox_Destination.Text == "")
			{
				addToGrid(ref MainForm.buses);
			}
			else
			{
				List<Bus> tempList = new List<Bus>();
				foreach (var item in MainForm.buses)
				{
					if (item.Destination == textBox_Destination.Text)
					{
						tempList.Add(item);
					}
				}
				if (tempList.Count == 0)
				{
					MessageBox.Show("Совпадений по пути следования не найдено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					tempList.Sort();
					addToGrid(ref tempList);
				}
			}




		}
	}
}
