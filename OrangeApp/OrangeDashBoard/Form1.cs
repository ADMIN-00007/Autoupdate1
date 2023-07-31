using System.Diagnostics;

namespace OrangeDashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://forms.office.com/Pages/ResponsePage.aspx?id=Uxo8h1TYokeM71lH3Fj_sdQBH5zizjBImbSQ_pb3sepURExWQkY2VzlVTlhWNFZERUxQVzZGMTA0RS4u", UseShellExecute = true });
        }
    }
}