namespace CH.Calculator.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintNumber(string strNum)
        {
            string num = txtDisplay.Text + strNum;
            txtDisplay.Text = num;
        }

        public void NumberEntered (object sender, EventArgs e) 
        {
            Button? btnNum = sender as Button;
            if (btnNum != null ) 
            {
                string strNum = btnNum.Text;
                PrintNumber(strNum);
                
            }


        } 
    }
}