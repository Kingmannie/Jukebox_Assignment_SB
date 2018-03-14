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

            //empty string container
            String num_gen = "";
            String num_track = "";

            //capture first line of data from the config file
            num_gen = myInputStream.ReadLine();

            //create a new instance of listbox
            String[] Genre_List = new String[Convert.ToInt16(num_gen)];
            Genre_List[0] = "1";
            Genre_List[1] = "2";
            Genre_List[2] = "3";


            //List<string> Genre_List[Convert.ToInt16(num_gen)] = new List<string>();
            //ListBox Genre_List[new int Convert.ToInt16(num_gen)] = new ListBox();
            //add the number from the config to it
            //Genre_List.Items.Add(num_gen);

            //loop to define genre - 3 genres
            for (int gen = 0; gen < Convert.ToInt16(num_gen); gen++) 
            {
                //create new instance of Genre_List for each gen increment
                //Genre_List.Items[gen] = new ListBox();
                num_track = myInputStream.ReadLine();//number of tracks in config
                //Genre_List.Items[gen] =  myInputStream.ReadLine();//store title in array
                //listBox1.Items.Add(MyList.ElementAt(i));

                //for (int track = 0; track < Convert.ToInt16(num_track); track++)
                //{ //loop to define tracks
                    //Genre_List.Items[track] = myInputStream.ReadLine();//store tracks in array
                //}
            }

            //after populating the arrays - display on form
            //txt_Genre_Title.Text = Genre_List.Items[0].ToString();
            //txt_Genre_Title
            //lst_Genre_List
        }

        public void hscr_Selector_Scroll(object sender, ScrollEventArgs e)
        {



            txt_Genre_Title.Text = hscr_Selector.Value.ToString();
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
