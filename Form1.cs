using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_07_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.Items[0].ImageIndex = 2;

            ToolStripMenuItem view = new ToolStripMenuItem("Вид");

            ToolStripMenuItem table = new ToolStripMenuItem("Таблица");
            table.Click += Table_Click;

            ToolStripMenuItem big_icons = new ToolStripMenuItem("Большие значки");
            big_icons.Click += Big_icons_Click;

            ToolStripMenuItem small_icons = new ToolStripMenuItem("Мелкие значки");
            small_icons.Click += Small_icons_Click; 

            ToolStripMenuItem tile = new ToolStripMenuItem("Плитка");
            tile.Click += Tile_Click;

            ToolStripMenuItem list = new ToolStripMenuItem("Список");
            list.Click += List_Click;

            view.DropDownItems.Add(big_icons);
            view.DropDownItems.Add(small_icons);
            view.DropDownItems.Add(table);
            view.DropDownItems.Add(tile);
            view.DropDownItems.Add(list);

            menuStrip1.Items.Add(view);

        }

        private void Table_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Items[0].ImageIndex = 2;
        }

        private void List_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
            listView1.Items[0].ImageIndex = 0;
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
            listView1.Items[0].ImageIndex = 0;
        }

        private void Small_icons_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.Items[0].ImageIndex = 0;
        }

        private void Big_icons_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            listView1.Items[0].ImageIndex = 0;
        }

    }
}
