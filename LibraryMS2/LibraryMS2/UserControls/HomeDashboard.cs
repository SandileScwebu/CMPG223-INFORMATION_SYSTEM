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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace LibraryMS2.UserControls
{
    public partial class HomeDashboard : UserControl
    {

        

        public HomeDashboard()
        {
            InitializeComponent();
            LoadUploadedImages();

            pbRequestEvent.Visible = false;



            lblRER.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm");
            lblT2E.Text = DateTime.Now.ToString("dd MMM yyyy ");

            // Set up the chart
            SetupChart();

            // Load top 2 events and display in the chart
            LoadTop2Events();

            // Load images
            images.Add(Image.FromFile(@"C:\Users\31765432\Desktop\LibraryMS2\library1.jpg"));
            images.Add(Image.FromFile(@"C:\Users\31765432\Desktop\LibraryMS2\library2.jpg"));
            images.Add(Image.FromFile(@"C:\Users\31765432\Desktop\LibraryMS2\library3.jpg"));


            // Setup PictureBox (already in the panel from Designer)
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Show first image
            pictureBox1.Image = images[currentIndex];

            // Button events
            btnPrev.Click += btnPrev_Click_Click;
            btnNext.Click += btnNext_Click_Click;


            // Load images (use your own file paths)


            // Setup PictureBox inside the panel
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;



            // Setup Timer
            slideTimer.Interval = 3000; // 3 seconds per slide
            slideTimer.Tick += SlideTimer_Tick;
            slideTimer.Start();

            // Show first image
            pictureBox1.Image = images[currentIndex];


            //method
            RefreshLatestEvent();

            int latestEventId = LoadLatestEvent(); // gets the latest event ID
            if (latestEventId != -1)
            {
                RefreshRatings(latestEventId); // refresh ratings for the latest event
                
            }

        }

        public void RefreshRatingsForSelectedEvent(int eventId)
        {
            RefreshRatings(eventId);
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Count)
                currentIndex = 0;

            pictureBox1.Image = images[currentIndex];
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31765432\Desktop\LibraryMS2\LibraryMS2\LibraryMS_Database.mdf;Integrated Security=True;Connect Timeout=30";
        private List<Image> images = new List<Image>();
        private int currentIndex = 0;
        private Timer slideTimer = new Timer();

        private List<Image> slideshowImages = new List<Image>();
        private List<Image> uploadedImages = new List<Image>();





        private void RefreshRatings(int eventId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Top3Ratings", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@EventID", eventId);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read() && index < 3)
                        {
                            string readerName = reader["Reader_Name"].ToString();
                            string eventTitle = reader["Event Title"].ToString();
                            string rating = reader["Rating"].ToString();

                            if (index == 0)
                            {
                                lblRN1.Text = readerName;
                                lblEN1.Text = eventTitle;
                                lblR1.Text = rating;
                            }
                            else if (index == 1)
                            {
                                lblRN2.Text = readerName;
                                lblEN2.Text = eventTitle;
                                lblR2.Text = rating;
                            }
                            else if (index == 2)
                            {
                                lblRN3.Text = readerName;
                                lblEN3.Text = eventTitle;
                                lblR3.Text = rating;
                            }

                            index++;
                        }
                    }
                }
            }
        }

        private int LoadLatestEvent()
        {
            int latestEventId = -1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LATESTEVENTNOIDS", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            latestEventId = Convert.ToInt32(reader["Event_ID"]);

                            lblEventTitle.Text = reader["Event Title"].ToString();
                            lblEventDate.Text = Convert
                                .ToDateTime(reader["Event Date"])
                                .ToString("dd MMM yyyy");


                            lblDetails.Text = reader["Event Details"].ToString();
                            // lblAvailableSeats.Text = reader["Available Seats"].ToString();
                            // lblBookTitle.Text = reader["Book Title"].ToString();
                        }
                    }
                }
            }

            return latestEventId; //
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {

            int latestEventId = LoadLatestEvent();

            if (latestEventId != -1)
            {
                RefreshRatings(latestEventId);
            }
        }

        private void LoadTop2Events()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TOP2EVENTS", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Clear existing data
                        chart2.Series["Series1"].Points.Clear();

                        while (reader.Read())
                        {
                            string eventTitle = reader["Event Title"].ToString();
                            int attendees = Convert.ToInt32(reader["Attendees"]);

                            // Add data to chart (horizontal bars)
                            chart2.Series["Series1"].Points.AddXY(eventTitle, attendees);
                        }
                    }
                }
            }
        }

        private void SetupChart()
        {
            // Set chart type to bar (horizontal)
            chart2.Series["Series1"].ChartType = SeriesChartType.Bar;

            // Enable 3D chart if you want
            chart2.ChartAreas[0].Area3DStyle.Enable3D = false;

            // Set axes labels
            chart2.ChartAreas[0].AxisX.Title = "Event Title";
            chart2.ChartAreas[0].AxisY.Title = "Attendees";

            // Set axis labels rotation for clarity
            chart2.ChartAreas[0].AxisY.LabelStyle.Angle = -45;

            // Set legend title
            chart2.Legends[0].Title = "Legend";

            // Set series legend text
            chart2.Series["Series1"].LegendText = "Event";
        }

        private void btnPrev_Click_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = images.Count - 1;
            pictureBox1.Image = images[currentIndex];
        }

        private void btnNext_Click_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Count) currentIndex = 0;
            pictureBox1.Image = images[currentIndex];
        }

        private void btnDownloadEvent_Click(object sender, EventArgs e)
        {
            // Assuming the image is in a PictureBox named pictureBox1
            if (pbRequestEvent.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Save Image As";
                    saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveFileDialog.FileName = "LibraryMS_Document";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get selected file path
                        string path = saveFileDialog.FileName;

                        // Save the image in the chosen format
                        var ext = System.IO.Path.GetExtension(path).ToLower();
                        switch (ext)
                        {
                            case ".jpg":
                                pbRequestEvent.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case ".bmp":
                                pbRequestEvent.Image.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            default:
                                pbRequestEvent.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                        }

                        MessageBox.Show("Image saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadUploadedImages()
        {
            string uploadFolder = Path.Combine(Application.StartupPath, "Uploads");

            if (Directory.Exists(uploadFolder))
            {
                foreach (string filePath in Directory.GetFiles(uploadFolder))
                {
                    try
                    {
                        uploadedImages.Add(Image.FromFile(filePath)); // only store in uploadedImages
                    }
                    catch { }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select Images";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string uploadFolder = Path.Combine(Application.StartupPath, "Uploads");
                    Directory.CreateDirectory(uploadFolder);

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        try
                        {
                            string fileName = Path.GetFileName(filePath);
                            string savePath = Path.Combine(uploadFolder, fileName);

                            // Avoid overwriting
                            if (!File.Exists(savePath))
                                File.Copy(filePath, savePath);
                            else
                                File.Copy(filePath, Path.Combine(uploadFolder, $"{Path.GetFileNameWithoutExtension(fileName)}_{Guid.NewGuid()}{Path.GetExtension(fileName)}"));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving image {filePath}: {ex.Message}");
                        }
                    }

                    MessageBox.Show("Images uploaded successfully!");
                }
            }
        }

        public void RefreshLatestEvent()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LATESTEVENTNOIDS", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblEventTitle.Text = reader["Event Title"].ToString();
                            lblEventDate.Text = Convert.ToDateTime(reader["Event Date"]).ToString("dd MMM yyyy");
                            lblDetails.Text = reader["Event Details"].ToString();
                        }
                    }
                }
            }
        }

        public void UpdateRatingsFromRateEvent(int eventId)
        {
            RefreshRatings(eventId);
        }

        

        private void pbRequestEvent_Click(object sender, EventArgs e)
        {

        }

        private void lblEventTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblEventDate_Click(object sender, EventArgs e)
        {

        }

        private void lblDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblRN1_Click(object sender, EventArgs e)
        {

        }

        private void lblEN1_Click(object sender, EventArgs e)
        {

        }

        private void lblRN2_Click(object sender, EventArgs e)
        {

        }

        private void lblEN2_Click(object sender, EventArgs e)
        {

        }

        private void lblRN3_Click(object sender, EventArgs e)
        {

        }

        private void lblEN3_Click(object sender, EventArgs e)
        {

        }

        private void lblR1_Click(object sender, EventArgs e)
        {

        }

        private void lblR2_Click(object sender, EventArgs e)
        {

        }

        private void lblR3_Click(object sender, EventArgs e)
        {

        }
    }
}
