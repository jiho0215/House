using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        public int numOfCom = 0;

        public Form1()
        {
            InitializeComponent();
            InitialDisplay();
        }
        private void InitialDisplay()
        {
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            Button btn1 = new Button();
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 30);
            btn1.Location = new Point(10, 10);
            btn1.Text = "Add a computer";
            btn1.Click += Btn1_Click;
            btn1.Parent = this;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
            Computer com = new Computer();
            com.Name = "Com" + numOfCom;
        }
    }
    class Computer
    {
        string type = "pc";
        Label lbl = new Label();
        lbl.Size = new Size(50, 30);
        lbl.backColor = Color.Blue;
        lbl.Location = new Point(30 + 60 * ( numOfCom / 4 ), 30 + 40 * ( numOfCom % 5 ) );
        lbl.Parent = Form1;
    }
}
