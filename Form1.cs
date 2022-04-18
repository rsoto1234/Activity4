namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (textBoxSeconds.Text=="")
            {
                MessageBox.Show("Please Enter Value.");
            }
            else 
            {
                int seconds = Convert.ToInt32(textBoxSeconds.Text);
                if (seconds >= 86400)
                {
                    int days = seconds / 86400;
                    textBoxResult.Text = days + "days";
                }
                else if (seconds >= 3600)
                {
                    int hours = seconds / 3600;
                    textBoxResult.Text = hours + "hours";
                }
                else if (seconds >= 60)
                    {
                int minutes = seconds / 60;
                    textBoxResult.Text = minutes + "minutes";
                }
                else 
                {
                    textBoxResult.Text = seconds + "seconds";
                }
            }
        }
    }
}