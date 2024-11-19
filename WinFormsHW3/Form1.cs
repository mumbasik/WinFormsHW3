namespace WinFormsHW3
{
    public partial class Form1 : Form
    {
        decimal summ = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculate";
            this.Size = new Size(400, 300);
            numericSumma.Maximum = 10000;
            numericSumma.Minimum = 0;
            
            timer1.Tick += (sender, e) => //Creating label for current data time
            {
                TimerLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {


            if (numericSumma.Value == 0 || string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(categoriesCombo.Text)) //examination if all lines are entered
            {
                MessageBox.Show("Please enter all lines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                MessageBox.Show($"Name of the product: {nameBox.Text}\n Summa of the product: {numericSumma.Value} \n Categoria: {categoriesCombo.Text}"); //Show order
                
                summ += numericSumma.Value;
                overallSumLabel.Text = $"Overall Summa: {summ}"; //Show overall summ
               



            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }
    }
}
