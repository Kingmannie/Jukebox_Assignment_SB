using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //include system.io classes for reading + writing input/output

namespace jukebox_assignment_SB
{
    public partial class frm_Jukebox : Form
    {
        public frm_Jukebox()
        {
            InitializeComponent();
        }

        public void frm_Jukebox_Load(object sender, EventArgs e)
        {
            //on form load, need to create the config file.
            //First, find and store the directory of the config folder
            string configPath = Directory.GetCurrentDirectory() + "\\";

            StreamWriter myOutputStream = File.CreateText(configPath + "Config.txt");

            //write the config file to build the initial structure for our config file.
            myOutputStream.WriteLine("3"); //(number of genres)
            myOutputStream.WriteLine("1"); //(number of tracks in genre)
            myOutputStream.WriteLine("Short Electronic"); //(Genre name)
            myOutputStream.WriteLine("New Life.mp3"); //(track name)
            myOutputStream.WriteLine("1");
            myOutputStream.WriteLine("Classical");
            myOutputStream.WriteLine("Swan Lake.mp3");
            myOutputStream.WriteLine("3");
            myOutputStream.WriteLine("Misc Tracks");
            myOutputStream.WriteLine("Simon Browne - Amusements.mp3");
            myOutputStream.WriteLine("Batchlor Cat.mp3");
            myOutputStream.WriteLine("Bird In Your Mind - Simon Browne.mp3");
            
            myOutputStream.Close(); //close StreamWriter stream before using StreamReader
            
            StreamReader myInputStream = File.OpenText(configPath + "Config.txt");

            //initiate empty arrays, ready to receive information
            
            string[] Tracks_Array = new string[0];

            //int num_gen = myInputStream.ReadLine();

            string[] Genre_Array = new string[0];

            for (int genre = 0; genre < 3; genre++) //loop to define genre - 3 genres
            {
                //Create string[] Tracks_Array = new string[0];
                for (int track = 0; track < 3; track++)
                { //loop to define tracks

                }
            }

            //while (line != null)
            //{

            //fill array
            //line = config_Input_Reader.ReadLine();
            //}
        }

        private void hscr_Selector_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void lst_Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Genre_Title_TextChanged(object sender, EventArgs e)
        {
            //txt_Genre_Title = Genre_Array[0];
        }

        private void txt_Presently_Playing_TextChanged(object sender, EventArgs e)
        {
            //txt_Presently_Playing =;
        }

        private void lst_Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }


    }
}
