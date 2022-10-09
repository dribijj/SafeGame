namespace SafeGame
{
    public partial class StartPage : Form
    {
        public int N;
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numericValue))
            {
                N = Int32.Parse(textBox1.Text);
                if (N < 1)
                    MessageBox.Show("¬ведите размер сейфа больше 0");
                else
                {
                    Hide();
                    Game game = new Game();
                    Game.SafeSize = N;
                    game.ShowDialog();
                    Close();
                }
            }
            else MessageBox.Show("¬ведите целое число");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}