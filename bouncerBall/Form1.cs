namespace bouncerBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       System.Windows.Forms.Timer timer1;

        int l = 2;
        int h = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            //dimensiuni si pozitie
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = 0;
            this.Top = 0;

            //text
            this.Text = "ball bouncer";
            timer1 = new System.Windows.Forms.Timer();
            timer1.Start();
            timer1.Interval = 1;
            timer1.Tick += Timer1_Tick;

        }
        public void runanimation()
        {
            if (this.label1.Left >= 200) { l = -1 * l; }
            if (this.label1.Left <= 2) { l = -1 * l; }
            if (this.label1.Top >= 300) { h = -1 * h; }
            if (this.label1.Top <= 2) { h = -1 * h; }

            this.label1.Left += l * 2;
                this.label1.Top += h * 2;
           


            
        }
        private void Timer1_Tick(object? sender, EventArgs e)
        {
            runanimation();
        }
    }
}