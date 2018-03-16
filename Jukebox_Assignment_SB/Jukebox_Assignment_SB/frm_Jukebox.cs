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

        //initialise listbox array globally
        ListBox[] Genre_List;

        //empty string container
        String next_line = "";

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

            //capture first line of data from the config file
            next_line = myInputStream.ReadLine();

            String num_track = "";

            //create a new instance of listbox
            //array index value is converted string from config file.
            Genre_List = new ListBox[Convert.ToInt16(next_line)];

            //loop to define genre - (3 genres as default) 
            for (int gen = 0; gen < Convert.ToInt16(next_line); gen++)
            {
                //create new instance of Genre_List for each gen increment
                Genre_List[Convert.ToInt16(gen)] = new ListBox();
                num_track = myInputStream.ReadLine();//number of tracks in config
                Genre_List[Convert.ToInt16(gen)].Items.Add(myInputStream.ReadLine());//store title in array
                //txt_Genre_Title.Text = Genre_List[gen].Text.ToString();
                
                for (int track = 0; track < Convert.ToInt32(num_track); track++)
                { //loop to define tracks
                    Genre_List[Convert.ToInt16(gen)].Items.Add(myInputStream.ReadLine());//store tracks in array
                    //lst_Genre_List.Items[Convert.ToInt32(next_line)].Equals(Genre_List[track].Text.ToString());
                }
            }

            //gotcha
            //txt_Genre_Title.Text = Genre_List[0].Items[1].ToString();

            //after populating the arrays - display on form

            //lst_Genre_List
            //txt_Genre_Title.Text

            myInputStream.Close();
        }


        private void hscr_Selector_Scroll(object sender, ScrollEventArgs e)
        {
            string configPath = Directory.GetCurrentDirectory() + "\\";

            StreamReader myInputStream = File.OpenText(configPath + "Config.txt");

            

            //txt_Genre_Title.Text = Genre_List[hscr_Selector.Value].Text.ToString();

            //potentially search document here
            //for (int i = 0; i < Convert.ToInt16(Genre_List[0]); i++)
            //{
            //hscr_Selector.Value += i;
            //txt_Genre_Title.Text = Genre_List[hscr_Selector.Value].Text.ToString();
            //txt_Genre_Title.Text = hscr_Selector.Value.ToString();
            //}
            myInputStream.Close();
        }

        private void lst_Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Genre_Title_TextChanged(object sender, EventArgs e)
        {
            
            
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
