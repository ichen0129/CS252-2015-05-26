using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public class MyWinForm : Form
    {
        private Button openButton;
        private MyButtom myButtom1;
        private Button closeButton;

        public MyWinForm()
            : base()
        {
            InitializeComponent();
            this.BackColor = Color.SkyBlue;
        }

        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.myButtom1 = new Example02.MyButtom();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(168, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(149, 47);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 11);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(145, 48);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // myButtom1
            // 
            this.myButtom1.BackColor = System.Drawing.Color.CadetBlue;
            this.myButtom1.Location = new System.Drawing.Point(12, 103);
            this.myButtom1.Name = "myButtom1";
            this.myButtom1.Size = new System.Drawing.Size(145, 90);
            this.myButtom1.TabIndex = 3;
            this.myButtom1.Text = "myButtom1";
            this.myButtom1.UseVisualStyleBackColor = false;
            // 
            // MyWinForm
            // 
            this.ClientSize = new System.Drawing.Size(349, 223);
            this.Controls.Add(this.myButtom1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.closeButton);
            this.Name = "MyWinForm";
            this.ResumeLayout(false);

        }

        protected virtual void openButton_Click(object sender, EventArgs e)
        {
        }
    }
}