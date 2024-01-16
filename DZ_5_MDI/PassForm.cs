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
	public partial class PassForm : Form
	{
		//Объявляем объект главной формы 
		MainForm parrent;
		//Передаю этот объект в качестве параметра в конструктор
		//Через этот объект буду передавать данные в главную форму
		public PassForm(MainForm parrent)
		{

			InitializeComponent();
			this.parrent = parrent;
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			parrent.setPass(PassTextBox.Text);
			Close();
		}

		private void PassTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btn_OK_Click((object)sender, e);
			}
		}
	}
}
