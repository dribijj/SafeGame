using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SafeGame
{
    public partial class Game : Form
    {
        public static int SafeSize { get; set; }
        Random rnd = new Random();
        List<List<Cell>> cells = new List<List<Cell>>();
        public Game()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            InitializeCells();
        }
        public void InitializeCells()
        {
            for (int i = 0; i < SafeSize; i++)
            {
                cells.Add(new List<Cell>());
                for (int j = 0; j < SafeSize; j++)
                {
                    cells[i].Add(new Cell());
                    cells[i][j].Location = new Point(i * 40, j * 40);
                    cells[i][j].Size = new Size(40, 40);
                    cells[i][j].Name = $"cell{i}{j}";
                    cells[i][j].CellState = rnd.Next()%2;
                    if (cells[i][j].CellState == 0)
                    { cells[i][j].Text = "|"; }
                    else
                    { cells[i][j].Text = "—"; }
                    cells[i][j].MouseClick += new MouseEventHandler(CellClick);
                    this.Controls.Add(cells[i][j]);
                }
            }
        }
        public void CellClick(object sender, MouseEventArgs e)
        {
            int iBase = Int32.Parse((sender as Cell).Name[4].ToString());
            int jBase = Int32.Parse((sender as Cell).Name[5].ToString());
            for (int i = 0; i < SafeSize; i++)
            {
                if (i != iBase)
                {
                    cells[i][jBase].ReverseState();
                }
                cells[iBase][i].ReverseState();

            }
            this.CheckWin();
        }
        public void CheckWin()
        {
            bool notWin = false;
            int firstItem = cells[0][0].CellState;
            for (int i = 0; (i < SafeSize) && (notWin == false); i++)
            {
                for (int j = 0; (j < SafeSize) && (notWin == false); j++)
                {
                    if (cells[i][j].CellState != firstItem)
                        notWin = true;
                }
            }
            if (notWin == false)
            {
                EndPage endPage = new EndPage();
                endPage.ShowDialog();
                Close();
            }
        }

    }
}
