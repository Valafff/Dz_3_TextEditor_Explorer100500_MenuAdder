namespace Dz_3_MenuTextAdd
{
	partial class Form_MenuTest
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
			this.btn_AddSubItem = new System.Windows.Forms.Button();
			this.tb_SubItem = new System.Windows.Forms.TextBox();
			this.lb_SubItem = new System.Windows.Forms.Label();
			this.lb_TopLevelMenu = new System.Windows.Forms.Label();
			this.tb_TopLevel_menu = new System.Windows.Forms.TextBox();
			this.btn_AddTopLevelMenu = new System.Windows.Forms.Button();
			this.menuStrip_test = new System.Windows.Forms.MenuStrip();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.btn_AddSubItem, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.tb_SubItem, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lb_SubItem, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lb_TopLevelMenu, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tb_TopLevel_menu, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_AddTopLevelMenu, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 34);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 100);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btn_AddSubItem
			// 
			this.btn_AddSubItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_AddSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_AddSubItem.Location = new System.Drawing.Point(650, 53);
			this.btn_AddSubItem.Name = "btn_AddSubItem";
			this.btn_AddSubItem.Size = new System.Drawing.Size(318, 43);
			this.btn_AddSubItem.TabIndex = 8;
			this.btn_AddSubItem.Text = "Добавить подменю";
			this.btn_AddSubItem.UseVisualStyleBackColor = true;
			this.btn_AddSubItem.Click += new System.EventHandler(this.btn_AddSubItem_Click);
			// 
			// tb_SubItem
			// 
			this.tb_SubItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_SubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_SubItem.Location = new System.Drawing.Point(327, 53);
			this.tb_SubItem.Name = "tb_SubItem";
			this.tb_SubItem.Size = new System.Drawing.Size(316, 44);
			this.tb_SubItem.TabIndex = 6;
			// 
			// lb_SubItem
			// 
			this.lb_SubItem.AutoSize = true;
			this.lb_SubItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_SubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_SubItem.Location = new System.Drawing.Point(4, 50);
			this.lb_SubItem.Name = "lb_SubItem";
			this.lb_SubItem.Size = new System.Drawing.Size(316, 49);
			this.lb_SubItem.TabIndex = 3;
			this.lb_SubItem.Text = "SubItem";
			// 
			// lb_TopLevelMenu
			// 
			this.lb_TopLevelMenu.AutoSize = true;
			this.lb_TopLevelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_TopLevelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_TopLevelMenu.Location = new System.Drawing.Point(4, 1);
			this.lb_TopLevelMenu.Name = "lb_TopLevelMenu";
			this.lb_TopLevelMenu.Size = new System.Drawing.Size(316, 48);
			this.lb_TopLevelMenu.TabIndex = 0;
			this.lb_TopLevelMenu.Text = "TopLevelMenu";
			// 
			// tb_TopLevel_menu
			// 
			this.tb_TopLevel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_TopLevel_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_TopLevel_menu.Location = new System.Drawing.Point(327, 4);
			this.tb_TopLevel_menu.Name = "tb_TopLevel_menu";
			this.tb_TopLevel_menu.Size = new System.Drawing.Size(316, 44);
			this.tb_TopLevel_menu.TabIndex = 4;
			// 
			// btn_AddTopLevelMenu
			// 
			this.btn_AddTopLevelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_AddTopLevelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_AddTopLevelMenu.Location = new System.Drawing.Point(650, 4);
			this.btn_AddTopLevelMenu.Name = "btn_AddTopLevelMenu";
			this.btn_AddTopLevelMenu.Size = new System.Drawing.Size(318, 42);
			this.btn_AddTopLevelMenu.TabIndex = 7;
			this.btn_AddTopLevelMenu.Text = "Добавить меню";
			this.btn_AddTopLevelMenu.UseVisualStyleBackColor = true;
			this.btn_AddTopLevelMenu.Click += new System.EventHandler(this.btn_AddTopLevelMenu_Click);
			// 
			// menuStrip_test
			// 
			this.menuStrip_test.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_test.Name = "menuStrip_test";
			this.menuStrip_test.Size = new System.Drawing.Size(972, 24);
			this.menuStrip_test.TabIndex = 2;
			this.menuStrip_test.Text = "menuStrip1";
			// 
			// Form_MenuTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 134);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip_test);
			this.MainMenuStrip = this.menuStrip_test;
			this.Name = "Form_MenuTest";
			this.Text = "MenuAdder";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lb_TopLevelMenu;
		private System.Windows.Forms.TextBox tb_SubItem;
		private System.Windows.Forms.Label lb_SubItem;
		private System.Windows.Forms.TextBox tb_TopLevel_menu;
		private System.Windows.Forms.Button btn_AddSubItem;
		private System.Windows.Forms.Button btn_AddTopLevelMenu;
		private System.Windows.Forms.MenuStrip menuStrip_test;
	}
}

