using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using PlateSerials.Dtos;
using PlateSerials.Helpers;
using PlateSerials.Services;

namespace PlateSerials
{
    public partial class PlateSerialForm : Form
    {
        public string Token { get; set; }
        private VideoCapture _capture;
        private Mat _frame;
        private static int _lastPlateId;
        private System.Windows.Forms.Timer timer;
        public PlateSerialForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;// Set the interval in milliseconds (0.5 seconds)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            var lastPlate = await GetLastPlate(Token);
            //var lastPlate = await GetLastPlate("eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJtb2hhbW1hZGFzaGVyaSIsImlhdCI6MTcwNTQ3ODY5MywiZXhwIjoxNzA1NTM4NjkzfQ.piVBcJR072rTg5qrbyWARIxIjzjus_prKkDeLHUzqKk");

            if (lastPlate != null && lastPlate.DetectionId != _lastPlateId && !string.IsNullOrEmpty(lastPlate.Result.FirstOrDefault().Output.Text))
            {
                var lastPlateSerial = lastPlate.Result.FirstOrDefault().Output.Text.ToArray();
                var dateTime = DateTime.Now;
                _lastPlateId = lastPlate.DetectionId;

                insertDateTimeLabel.Text = dateTime.ToShamsi();
                insertTimeLabel.Text = dateTime.ToString("HH:mm:ss");

                if (lastPlate.Result.FirstOrDefault().Output.Text.Length == 8)
                {
                    serialFirst2Digit.Text = lastPlateSerial[0].ToString() + lastPlateSerial[1].ToString();
                    serialLetter.Text = lastPlateSerial[2].ToString();
                    serialSecond3Digit.Text = lastPlateSerial[3].ToString() + lastPlateSerial[4].ToString() + lastPlateSerial[5].ToString();
                    serialLast2Digit.Text = lastPlateSerial[6].ToString() + lastPlateSerial[7].ToString();
                }
                else
                {
                    serialFirst2Digit.Text = lastPlate.Result.FirstOrDefault().Output.Text;
                }


                LoadImageFromBase64(lastPlate.Result.FirstOrDefault().MetaData, lastPlatePictureBox);

                plateSerialsListBox.Items.Insert(0, lastPlate.Result.FirstOrDefault().Output.Text + $" ({dateTime.ToShamsiWithTime()})");
            }
        }

        private void LoadImageFromBase64(string base64String, PictureBox pictureBox)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox.Image = image;
                    ms.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<PlateDetectionResponseDto> GetLastPlate(string token)
        {
            var plateDetector = new PlateDetectorService();
            var lastPlate = await plateDetector.LastPlateSerial(token);
            return lastPlate;
        }


        private void PlateSerialForm_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    var cameraUrl = File.ReadAllText("CameraUrl.txt");
                    _capture = new VideoCapture($"rtsp://admin:8B06C27PAG67865@{cameraUrl}/cam/realmonitor?channel=1&subtype=0");
                    _capture.ImageGrabbed += ProcessFrame;
                    _capture.Set(Emgu.CV.CvEnum.CapProp.Fps,1);
                    _capture.Start();

                  //  Application.Idle += ProcessFrame;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing camera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = _capture.QueryFrame();
            if (frame is null)
                return;

            cameraPictureBox.Image = frame.ToImage<Bgr, byte>().Resize(955, 490, Inter.Cubic).ToBitmap();//.Resize(320, 200, Inter.Cubic);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
