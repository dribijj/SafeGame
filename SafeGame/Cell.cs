using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeGame
{
    public class Cell: Button
    {
        public int CellState { get; set; }
        public void ReverseState()
        {
            if (this.CellState == 1)
            {
                this.CellState = 0;
                this.Text = "|";
            }
            else
            {
                this.CellState = 1;
                this.Text = "—";
            }
        }
    }
}
