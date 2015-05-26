using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Light : MyWinForm
    {
        protected override void openButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Chocolate;
        }
    }
}