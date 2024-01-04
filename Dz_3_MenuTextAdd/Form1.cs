using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_3_MenuTextAdd
{
	public partial class Form_MenuTest : Form
	{
		ToolStripMenuItem fileItem;
		public Form_MenuTest()
		{
			InitializeComponent();
			fileItem = new ToolStripMenuItem("");
		}
		private void btn_AddTopLevelMenu_Click(object sender, EventArgs e)
		{
			if (tb_TopLevel_menu.Text != "")
			{
				fileItem.Text = tb_TopLevel_menu.Text;
				menuStrip_test.Items.Add($"{fileItem.Text}");
			}
			else
			{
				MessageBox.Show("Текстовое меню пустое!", "Сообщение",  MessageBoxButtons.OK,  MessageBoxIcon.Information);
			}
		}

		private void btn_AddSubItem_Click(object sender, EventArgs e)
		{
			if (tb_SubItem.Text != "" && tb_TopLevel_menu.Text != "")
			{
				foreach (ToolStripMenuItem item in menuStrip_test.Items)
				{
					Console.WriteLine(item);
					if (item.Text == tb_TopLevel_menu.Text)
					{
						item.DropDownItems.Add(tb_SubItem.Text);
					}
				}
			}
			else
			{
				MessageBox.Show("Текстовое меню пустое!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}