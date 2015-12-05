using System.Globalization;
using System.Windows.Forms;

namespace CultureInfoEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            var obj = new CultureInfo("en-US");
            GeneralProperties.SelectedObject = obj;
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void unregisterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
