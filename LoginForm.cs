using System.ComponentModel;

namespace Dekat_Kafe_New
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
