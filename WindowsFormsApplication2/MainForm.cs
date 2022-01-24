using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;

namespace WindowsFormsApplication2
    
{
    public partial class Formu : Form
    {
        
        public int r = 0;
        public int jh=0;
        public string loc;
        Random rand = new Random();
        public Formu()
        {
            InitializeComponent();
            File.Checked = true;
            
        }

     
     
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            axWindowsMediaPlayer1.settings.mute = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            axWindowsMediaPlayer1.settings.mute = false;
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
         
           
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox5.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.playCount = 100;
            
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.playCount = 1;
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.next();
          
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }
        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            if(Folder.Checked==true)
          {
              DialogResult R = folderBrowserDialog1.ShowDialog();
              if (R == DialogResult.Cancel)
              {
               //   MessageBox.Show("you don not choose any folder");
              }
              if (R == DialogResult.OK)
              {
                  string[] p = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                  foreach (string filename in p)
                  {

                      axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(filename));


                  }

                  axWindowsMediaPlayer1.Ctlcontrols.play();
                  pictureBox6.Visible = false;
                  pictureBox5.Visible = true;

                  foreach (string filename in p)
                  {

                      textBox1.AppendText(filename);
                      textBox1.AppendText("\n");

                  }

                  pic0.Visible = false;

              }
          }
          else
          {
              
              openFileDialog1.Title = "select music";
              openFileDialog1.Multiselect = true;
              openFileDialog1.Filter = "music | *.mp3" + "*.*";
              DialogResult R = openFileDialog1.ShowDialog();

              if (R == DialogResult.Cancel)
              {
                  pic0.Visible = true;
                 // MessageBox.Show("you do not choose any file (.mp3)");
              }
              else
              {
                  
                  foreach (string filename in openFileDialog1.FileNames)
                  {

                      axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(filename));


                  }

                  axWindowsMediaPlayer1.Ctlcontrols.play();
                  pictureBox6.Visible = false;
                  pictureBox5.Visible = true;





                  foreach (string filename in openFileDialog1.SafeFileNames)
                  {

                      textBox1.AppendText(filename);
                      textBox1.AppendText("\n");

                  }

                  pic0.Visible = false;

              }

              }

        }
       
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.currentPlaylist.clear();
            textBox1.Text = " ";
            pic0.Visible = true;
        }
        private void pictureBox8_Click_2(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = r = r + 1;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if(r<=0)
            {
                r = 1;
            }
            if(r>0)
            axWindowsMediaPlayer1.settings.rate = r = r - 1;
            
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

       
        private void pic_Click(object sender, EventArgs e)
        {
             if(Folder.Checked==true)
          {
              DialogResult R = folderBrowserDialog1.ShowDialog();
              if (R == DialogResult.Cancel)
              {
               //   MessageBox.Show("you don not choose any folder");
              }
              if (R == DialogResult.OK)
              {
                  string[] p = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                  foreach (string filename in p)
                  {

                      axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(filename));


                  }

                  axWindowsMediaPlayer1.Ctlcontrols.play();
                  pictureBox6.Visible = false;
                  pictureBox5.Visible = true;

                  foreach (string filename in p)
                  {

                      textBox1.AppendText(filename);
                      textBox1.AppendText("\n");

                  }

                  pic0.Visible = false;

              }
          }
          else
          {
              
              openFileDialog1.Title = "select music";
              openFileDialog1.Multiselect = true;
              openFileDialog1.Filter = "music | *.mp3" + "*.*";
              DialogResult R = openFileDialog1.ShowDialog();

              if (R == DialogResult.Cancel)
              {
                  pic0.Visible = true;
                 // MessageBox.Show("you do not choose any file (.mp3)");
              }
              else
              {
                  
                  foreach (string filename in openFileDialog1.FileNames)
                  {

                      axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(filename));


                  }

                  axWindowsMediaPlayer1.Ctlcontrols.play();
                  pictureBox6.Visible = false;
                  pictureBox5.Visible = true;





                  foreach (string filename in openFileDialog1.SafeFileNames)
                  {

                      textBox1.AppendText(filename);
                      textBox1.AppendText("\n");

                  }

                  pic0.Visible = false;

              }

              }

        }
        }}

       

        

       

        

       


        


   

      



        
      

       
           
            
            
            
           
           
        

       

        
