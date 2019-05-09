using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            initgame();
            InitializeComponent();

        }

        private static readonly Random rand = new Random();
        private Button[,] ArrayButton = null;
        public static int level = 2; 
        public static int right = 0, wrong = 0;// số click đúng và sai
        public static int countdown = 15;// time = 15s

        private void initgame()
        {
            level = 2;
            right = 0;
            wrong = 0;
            countdown = 15;
            createArrayButton();
        }



        private void createArrayButton()
        {


            ArrayButton = new Button[level, level];// khởi tạo mảng 2 chiều
            // chọn vị trí màu sẽ random khác với màu còn lại
            int isI = rand.Next(level);
            int isJ = rand.Next(level);
            //random bảng màu 
            int alpha = rand.Next(255);
            int red = rand.Next(255);
            int green = rand.Next(255);
            int blue = rand.Next(255);

            Color color = Color.FromArgb(alpha, red, green, blue);

            if (alpha > 200)
            {
                alpha -= 30;
            }
            else
            {
                alpha += 30;
            }
            Color otherColor = Color.FromArgb(alpha, red, green, blue);


            for (int i = 0; i < ArrayButton.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayButton.GetLength(1); j++)
                {

                    Button btn = new Button();// khởi tạo btn
                    btn.BackColor = color;//màu nền của btn
                    btn.Width = btn.Height = 250 / level; // tạo button có kích cỡ 120
                    btn.Location = new System.Drawing.Point(i * btn.Width, j * btn.Height);

                    this.Controls.Add(btn); // thêm button ở panel
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.FlatAppearance.BorderColor = Color.WhiteSmoke;
                    ArrayButton[i, j] = btn; //vị trí của button trong mảng

                    btn.Click += new System.EventHandler(this.click_wrong);
                    if (isI == i && isJ == j)
                    {
                        btn.Click -= new System.EventHandler(this.click_wrong);
                    }

                }
            }

            ArrayButton[isI, isJ].Click += Form1_Click;
            ArrayButton[isI, isJ].BackColor = otherColor;

        }

        private void click_wrong(object sender, EventArgs e)
        {

            timer1.Start();
            countdown -= 02;
            if(countdown<=5)
            {
                lb_countdown.ForeColor = Color.Red;
            }
            lb_countdown.Text = countdown.ToString();
            
            wrong++;
            label2.Text = wrong.ToString();
            if(countdown<0)
            {
                countdown = 0;
                lb_countdown.Text = countdown.ToString();
            }


        }
        private void Form1_Click(object sender, EventArgs e)
        {
            
            clearButton();
            timer1.Start();
            lb_countdown.Text = countdown.ToString();
            right++;
            label1.Text = right.ToString();

            level++;
            createArrayButton();
            countdown = 15;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                var timetime = TimeSpan.FromSeconds(countdown);
                if(countdown<=5)
                {
                    lb_countdown.ForeColor = Color.Red;
                }
                lb_countdown.Text = timetime.ToString(@"ss");
            }
            else
            {
               
                
                timer1.Stop();

                string animal = null ;
                if (right >= 0 && right <= 4)
                {
                     animal = "Your semen has nothing to write about it. Bats live in the dark and use other senses, not vision and you will.";
                }
                else if (right >= 5 && right <= 9)
                {
                    animal = "You have a temporary tone. You see the nearest wall but do not go far because you can lose the way.";
                }
                else if(right>=10&&right<=14)
                {
                  animal = "You have a fairly good tone. You see most of the bones that people throw, but sometimes you also left.";
                }
                else if(right>=15&&right<=19)
                {
                    animal= "You have good hues. The mice will have to hide when you move.";
                }
                else if(right>=20&&right<=24)
                {
                    animal = "Your senses are wonderful. You have no trouble surviving in the jungle. You can see when the neighbor tigers go to the bathroom very far away.";

                }
                else if(right>=25&&right<=29)
                {              
                        animal = "Perfect. You have a great color observation.";
                }





                string result = "Your point: " + right.ToString() + "\n" +"You're: " + animal+  "\n" + "Do you want to play again ?";
                var finish = MessageBox.Show(result, "TEST EYES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (finish == DialogResult.Yes)
                {
                    Restartgame();
                }
                else
                {
                    Application.Exit();
                }


            }
        }


      

        public void Restartgame()
        {
            clearButton();
            initgame();
            lb_countdown.Text = countdown.ToString();
            label1.Text = right.ToString();
            label2.Text = wrong.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearButton()//xoá hết button khi qua màn
        {
            lb_countdown.ForeColor = Color.Aqua;
            for (int i = 0; i < ArrayButton.GetLength(0); i++)
                for (int j = 0; j < ArrayButton.GetLength(1); j++)
                {
                    this.Controls.Remove(ArrayButton[i, j]);
                }
        }
       
    }
}
