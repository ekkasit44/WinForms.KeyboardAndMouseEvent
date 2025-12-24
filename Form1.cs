using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WinForms.KeyboardAndMouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int step = 10;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //             lblResult.Text = "คุณกดปุ่ม" + e.KeyCode.ToString();

            //            if (e.KeyCode == Keys.Escape)
            //            {
            //              Application.Exit();


            //             if (e.Control && e.KeyCode == Keys.S)
            //{
            //MessageBox.Show("Save");
            //}
            //else if (e.Control && e.KeyCode == Keys.O)
            //{
            //MessageBox.Show("Open");
            //}
            //else if (e.Control && e.KeyCode == Keys.Q)
            //{
            //    Application.Exit();
            //}

            if (e.KeyCode == Keys.Up)
                lblResult.Top -= step;
            else if (e.KeyCode == Keys.Down)
                lblResult.Top += step;
            else if (e.KeyCode == Keys.Left)
                lblResult.Left -= step;
            else if (e.KeyCode == Keys.Right)
                lblResult.Left += step;
        }

        private void txtinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (txtPress.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
