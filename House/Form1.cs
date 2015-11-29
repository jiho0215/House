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
        public int numOfCom = 1;
        Dictionary<string, Computer> coms = new Dictionary<string, Computer>();

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


            int i = 5;
            for (int z = 0; z <= 5; z++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl"+z;
                lbl.Size = new Size(100, 30);
                lbl.Location = new Point(10, 10 + 33*z);
                lbl.Text = "Label"+z;
                lbl.Parent = this;
            }

            MessageBox.Show("Controls[\"lbl2\"].Text"+ " is "+Controls["lbl2"].Text);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button Clicked");
            //Computer com = new Computer();
            //com.Name = "Com" + numOfCom;

            coms.Add("Com" + numOfCom, new Computer());
            MessageBox.Show(numOfCom + "  " + coms["Com1"].Type);
            numOfCom++;
            
        }
    }
    class Computer
    {
        private string type = "pc";
        public string Type
        {
            get { return type; }
            set { type = value; }
            //}
            //Label lbl = new Label();
            //lbl.Size = new Size(50, 30);
            //lbl.backColor = Color.Blue;
            //lbl.Location = new Point(30 + 60 * ( numOfCom / 4 ), 30 + 40 * ( numOfCom % 5 ) );
            //lbl.Parent = Form1;
        }
    }
}
