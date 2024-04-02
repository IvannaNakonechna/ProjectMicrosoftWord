using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ProjectMicrosoftWord
{
    public partial class MicrosoftWord : Form
    {
        Graphics graphicsmicrosoftword;
        public MicrosoftWord()
        {
            InitializeComponent();
            WriteTxtB.Text = new Bitmap(WriteTxtB.Width, WriteTxtB.Height);
            graphicsmicrosoftword = Graphics.FromImage(WriteTxtB.Image);
        }


        private void SaveBttn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Image Files|*.jpg;*.jpeg;*.png|Allfiles(*.*.)|*.*";
            SaveFile.FilterIndex = 1;
            SaveFile.RestoreDirectory = true;
            SaveFile.InitialDirectory = "D:\\";
            SaveFile.Title = "Zapisz BitMap?";

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                int Width = Convert.ToInt32(WriteTxtB.Width);
                int Height = Convert.ToInt32(WriteTxtB.Height);

                using (Bitmap INBitmap = new Bitmap(Width, Height))
                {
                    WriteTxtB.DrawToBitmap(INBitmap, new Rectangle(0, 0, Width, Height));
                    INBitmap.Save(SaveFile.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void RestartBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MicrosoftWord Form1 = new MicrosoftWord();
            Form1.Show();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Image Files|*.jpg;*.jpeg;*.png|Allfiles(*.*.)|*.*";
            SaveFile.FilterIndex = 1;
            SaveFile.RestoreDirectory = true;
            SaveFile.InitialDirectory = "D:\\";
            SaveFile.Title = "Zapisz BitMap?";

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                int Width = Convert.ToInt32(WriteTxtB.Width);
                int Height = Convert.ToInt32(WriteTxtB.Height);

                using (Bitmap INBitmap = new Bitmap(Width, Height))
                {
                    WriteTxtB.DrawToBitmap(INBitmap, new Rectangle(0, 0, Width, Height));
                    INBitmap.Save(SaveFile.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            this.openFileDialog1.Filter =
            "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
            "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Photos";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {

                        Image.GetThumbnailImageAbort myCallback =
                                new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        Bitmap myBitmap = new Bitmap(file);
                        Image myThumbnail = myBitmap.GetThumbnailImage(WriteTxtB.Width, WriteTxtB.Height,
                            myCallback, IntPtr.Zero);
                        WriteTxtB.Image = myThumbnail;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        private void restartProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MicrosoftWord Form1 = new MicrosoftWord();
            Form1.Show();
        }
    }
}