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

        //exclusive genre value
        Int16 num_genres;

        //First, find and store the directory of the config folder
        string configPath = Directory.GetCurrentDirectory() + "\\";

        //tells us if the jukebox is playing or not
        //bool isPlaying = false;

        public void frm_Jukebox_Load(object sender, EventArgs e)
        {
            //on form load, need to create the config file.
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
            num_genres = Convert.ToInt16(myInputStream.ReadLine());

            //small int to store number of tracks
            Int16 num_track;

            //create a new instance of listbox
            //array index value is converted string from config file.
            Genre_List = new ListBox[num_genres];

            //loop to define genre - (3 genres as default) 
            for (int gen = 0; gen < num_genres; gen++)
            {
                Genre_List[gen] = new ListBox();//create new instance of Genre_List for each gen increment
                num_track = Convert.ToInt16(myInputStream.ReadLine());//number of tracks in config
                Genre_List[gen].Items.Add(myInputStream.ReadLine());//store title in array
                
                for (int track = 0; track < num_track; track++)//loop to cycle through tracks
                { 
                    Genre_List[gen].Items.Add(myInputStream.ReadLine());//store tracks in array
                }
            }

            //default title - first genre
            txt_Genre_Title.Text = Genre_List[0].Items[0].ToString();

            //lst_Genre_List
            //txt_Genre_Title.Text

            myInputStream.Close();

        }


        

        public void hscr_Selector_Scroll(object sender, ScrollEventArgs e)
        {
            //make scroll bar maximum size of number of genres
            hscr_Selector.Maximum = num_genres;
            //minimum is 0
            hscr_Selector.Minimum = 0;
            hscr_Selector.Value = 0;

            //properties small change and large change are both 1 - to stop it from over shooting the array index
            if ((hscr_Selector.Value >= 0) && (hscr_Selector.Value <= num_genres))
            {
                txt_Genre_Title.Text = Genre_List[hscr_Selector.Value += 1].Items[0].ToString();

            }
            

            //while ((hscr_Selector.Value > 0) && (hscr_Selector.Value < Convert.ToInt16(num_genres)))
            //{
            //    if (hscr_Selector. == true)
            //    {

                //    }
                //}
                //the value is stored in the array correctly - just need to show

                //if (hscr_Selector.Value


                //hscr_Selector.Value = Convert.ToInt16(num_genres);

                //Genre_List[2].Items[0].ToString()

                //cycle titles in textbox


                //txt_Genre_Title.Text = Genre_List[hscr_Selector.Value].Text.ToString();

                //potentially search document here
                //for (int i = 0; i < Convert.ToInt16(Genre_List[0]); i++)
                //{
                //hscr_Selector.Value += i;
                //txt_Genre_Title.Text = Genre_List[hscr_Selector.Value].Text.ToString();
                //txt_Genre_Title.Text = hscr_Selector.Value.ToString();
                //}

        }

        private void lst_Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void txt_Genre_Title_TextChanged(object sender, EventArgs e)
        {
            //txt_Genre_Title.Text = Genre_List[0].Items[0].ToString();

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
            //txt_Genre_Title.Text = Genre_List[0].Items[0].ToString();
            var frm_Setup_Window = new frm_Setup_Window();
            frm_Setup_Window.Show();

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            var frm_About = new frm_About();
            frm_About.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }


    }
}
