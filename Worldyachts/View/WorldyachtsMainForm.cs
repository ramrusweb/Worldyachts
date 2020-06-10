using System;
using System.Windows.Forms;

namespace Worldyachts.View
{
    public partial class WorldyachtsMainForm : Form
    {
        public WorldyachtsMainForm()
        {
            InitializeComponent();
            DateTimeNow();
        }

        // Дата и время.
        void DateTimeNow()
        {
            dateTimeLabel.Text = DateTime.Today.ToString();
        }

        // Выход из программы.
        void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }
    }
}
