using CultureInfoEditor.Interfaces;
using System.Globalization;
using System.Windows.Forms;

namespace CultureInfoEditor
{
    public partial class MainForm : Form
    {
        CultureInfoInterface ci;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            ci = new CultureInfoInterface();
            ci.NumberFormat = new NumberFormatInfoInterface();
            ci.TextInfo = new TextInfoInterface();
            GeneralProperties.SelectedObject = ci;
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CultureAndRegionInfoBuilder cib = new CultureAndRegionInfoBuilder("en-US", CultureAndRegionModifiers.Replacement);
            cib.Save("Culture (en-US).xml");
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
