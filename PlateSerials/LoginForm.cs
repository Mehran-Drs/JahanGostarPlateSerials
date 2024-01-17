using PlateSerials.Dtos;
using PlateSerials.Services;

namespace PlateSerials
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTxtBox.Text) || string.IsNullOrEmpty(passwordTxtBox.Text))
            {
                MessageBox.Show("لطفا نام کاربری و رمز عبور را به صورت کامل وارد نمایید");
            }
            else
            {
                var loginRequest = new LoginRequestDto()
                {
                    Username = userNameTxtBox.Text,
                    Password = passwordTxtBox.Text,
                };
                var plateService = new PlateDetectorService();
                var loginResponse = await plateService.LoginAysnc(loginRequest);

                if (loginResponse != null && !string.IsNullOrEmpty(loginResponse?.Token))
                {

                    PlateSerialForm mainForm = new PlateSerialForm();
                    this.Hide();
                    mainForm.Token = loginResponse.Token;
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("مشکلی در عملیات ورود پیش آمده است لطفا مجددا تلاش فرمایید");

                }

            }



            //var loginResponse = await plateDetector.LoginAysnc(loginRequest);

            //if (loginResponse != null)
            //{
            //    MessageBox.Show(loginResponse.Token);
            //}
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
