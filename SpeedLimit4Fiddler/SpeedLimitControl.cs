using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Fiddler;

namespace SuperProxy.SpeedLimt4Fiddler
{
    
    public partial class SpeedLimitControl : UserControl
    {
       private  Model model =new Model();
       public SpeedLimitControl()
       {
           InitializeComponent();
           this.tabPage.Controls.Add(this.checkBox1);
           this.tabPage.Controls.Add(this.button1);
           this.tabPage.Controls.Add(this.button2);
           this.tabPage.Controls.Add(this.button3);
           this.tabPage.Controls.Add(this.button4);
           this.tabPage.Controls.Add(this.label1);
           this.tabPage.Controls.Add(this.label2);
           this.tabPage.Controls.Add(trackBar1);
           this.tabPage.Controls.Add(trackBar2);
           this.tabPage.Controls.Add(textBox1);
           this.tabPage.Controls.Add(textBox2);
           this.tabPage.Controls.Add(this.label3);
           this.tabPage.Controls.Add(this.label4);
           this.tabPage.Controls.Add(this.label5);

           label5.Text = "";
           trackBar1.Minimum = 1;
           trackBar1.Maximum = 1000*10;
           trackBar1.Value = 5;
           trackBar2.Minimum = 1;
           trackBar2.Value = 5;
           trackBar2.Maximum = 1000*10;


       }

        public  Model Model {
            get { return model; }
            set { model = value; }
    }
        public SpeedLimitControl(Model model):this()
        {   
            this.model = model;
            FiddlerApplication.UI.tabsViews.TabPages.Add(this.tabPage); 
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.model.Enabled =   checkBox1.Checked;
            updateUI(this.model);
          //  MessageBox.Show("sjd" + checkBox1.Checked);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            model.RequestDelaySpeed =Convert.ToInt32(textBox1.Text);
            updateUI(model);  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            model.ReponseDelaySpeed = Convert.ToInt32(textBox2.Text);
            updateUI(model);  
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            model.RequestDelaySpeed = trackBar1.Value; 
            updateUI(model);  
            Console.WriteLine("hello");
        }

        private void updateUI(SuperProxy.SpeedLimt4Fiddler.Model model)
        {

            this.textBox1.Text = Convert.ToString(model.RequestDelaySpeed);
            this.textBox2.Text = Convert.ToString(model.ReponseDelaySpeed);

            trackBar1.Value =Convert.ToInt32(model.RequestDelaySpeed);
            trackBar2.Value = Convert.ToInt32(model.ReponseDelaySpeed);

            int requestDelay = SpeedConvert.covert(model.RequestDelaySpeed);
            int reponseDelay = SpeedConvert.covert(model.ReponseDelaySpeed);
            this.label5.Text = "Current Speed:"+"request-" + this.textBox1.Text+"kbps "
              + "requestDelay - " + requestDelay + "ms "
              + "response - " + this.textBox2.Text + "kbps "
              + "responseDelay - " + reponseDelay + "ms ";
             



            button1.Enabled = model.Enabled;
            button2.Enabled = model.Enabled;
            button3.Enabled = model.Enabled;
            button4.Enabled = model.Enabled;
            trackBar2.Enabled = model.Enabled;

             trackBar1.Enabled = model.Enabled;
              trackBar2.Enabled = model.Enabled;
                
             textBox1.Enabled = model.Enabled;
             textBox2.Enabled = model.Enabled;

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            model.ReponseDelaySpeed = trackBar2.Value;
            updateUI(model); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.RequestDelaySpeed = 10;
            model.ReponseDelaySpeed = 20;
            updateUI(model); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.RequestDelaySpeed = 100;
            model.ReponseDelaySpeed = 200;
            updateUI(model); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.RequestDelaySpeed = 480;
            model.ReponseDelaySpeed = 900;
            updateUI(model); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            model.RequestDelaySpeed = 5000;
            model.ReponseDelaySpeed = 10000;
            updateUI(model);
        }
    }
}
