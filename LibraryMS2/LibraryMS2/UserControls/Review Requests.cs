using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LibraryMS2.UserControls
{
    public partial class Review_Requests : UserControl
    {
        public Review_Requests()
        {
            InitializeComponent();
        }
        private List<Image> images = new List<Image>();
        private int currentIndex = 0;

        public void SetImage(Image img)
        {
            if (img == null) return;

            images.Add(img); // add to list so we can browse later
            currentIndex = images.Count - 1; // jump to the newly added image

            pbReviewReq.Image = img;
            pbReviewReq.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void LoadSavedImages()
        {
            string uploadFolder = Path.Combine(Application.StartupPath, "Uploads");
            images.Clear();
            currentIndex = 0;

            if (Directory.Exists(uploadFolder))
            {
                foreach (string file in Directory.GetFiles(uploadFolder))
                {
                    try
                    {
                        images.Add(Image.FromFile(file));
                    }
                    catch { /* ignore bad files */ }
                }

                if (images.Count > 0)
                {
                    pbReviewReq.Image = images[currentIndex];
                    pbReviewReq.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbReviewReq.Image = null;
                }
            }
        }


        private void Review_Requests_Load(object sender, EventArgs e)
        {
            LoadSavedImages();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) return;
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            pbReviewReq.Image = images[currentIndex];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) return;
            currentIndex = (currentIndex + 1) % images.Count;
            pbReviewReq.Image = images[currentIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new event.");
            // Get the Dashboard form
            Dashboard dash = (Dashboard)this.FindForm();

            dash.addUserControl(new LibraryMS2.UserControls.Event());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) return;

            // Remove the current image from the list
            images.RemoveAt(currentIndex);

            // Optionally delete the file from disk
            string uploadFolder = Path.Combine(Application.StartupPath, "Uploads");
            try
            {
                string fileToDelete = Directory.GetFiles(uploadFolder)[currentIndex];
                File.Delete(fileToDelete);
            }
            catch { /* ignore errors */ }

            // Adjust currentIndex
            if (currentIndex >= images.Count)
                currentIndex = images.Count - 1;

            // Show next image or clear PictureBox
            if (images.Count > 0)
            {
                pbReviewReq.Image = images[currentIndex];
            }
            else
            {
                pbReviewReq.Image = null;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
