using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gfToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void fdfToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void LoadData()
		{
			bancapheEntities db = new bancapheEntities();
			dtgv.DataSource = db.admin1.ToList();
		
		}
		private void button12_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		
		private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
		
	}
}
