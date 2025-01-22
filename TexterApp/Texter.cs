using TexterLib.Input;
using TexterLib.InputImplementation;
using TexterLib.Output;
using TexterLib.OutputImplementation;
using TexterLib.Renderer;
using TexterLib.RendererImplementation;
using TexterLib.Parser;
using TexterLib.ContentFactory;

namespace TexterApp
{
    public partial class Texter : Form
    {
        public Texter()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            fileName.Text = filename;
        }

        private void browseDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string dir = folderBrowserDialog1.SelectedPath;
            directoryName.Text = dir;
        }

        private void Render_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                return;
            if (string.IsNullOrEmpty(openFileDialog1.FileName))
                return;
            if (string.IsNullOrEmpty(shortName.Text)) 
                return;

            done.Visible = false;

            IInput input = new FileInput(openFileDialog1.FileName);
            IOutput output = new FileOutput(folderBrowserDialog1.SelectedPath + "/" + shortName.Text);
            Parser parser = new Parser(new ContentFactory(), new RendererToOutput(output));
            input.Open();
            output.Open();
            string s = null;
            while ((s = input.ReadLine()) != null)
                parser.Parse(s);
            input.Close();
            output.Close();

            done.Visible = true;
        }
    }
}
