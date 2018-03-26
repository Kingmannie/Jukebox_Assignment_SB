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
    public partial class frm_Setup_Window : Form
    {
        //NOTE - declaring similar globals to original form

        //initialise listbox array globally
        ListBox[] Genre_List;

        //exclusive genre value
        Int16 num_genres;

        //First, find and store the directory of the config folder
        string configPath = Directory.GetCurrentDirectory();

        //save switch
        bool bool_Requires_Saving;

        //int selector - to carry the index values 
        Int16 prev_next = 0;

        public frm_Setup_Window()
        {
            InitializeComponent();
        }
        private void frm_Setup_Window_Load(object sender, EventArgs e)
        {

            StreamReader myInputStream = File.OpenText(configPath + "Config.txt");

            //capture first line of data from the config file
            num_genres = Convert.ToInt16(myInputStream.ReadLine());

            //create a new instance of listbox
            Genre_List = new ListBox[num_genres];

            //small int to store number of tracks
            Int16 num_track;

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

            //manual setup = default title & track - first genre & track
            txt_Genre_Title2.Text = Genre_List[0].Items[0].ToString();

            lst_Playlist.Items.Add(Genre_List[0].Items[1].ToString());

            myInputStream.Close();

        }

        private void btn_Genre_Previous_Click(object sender, EventArgs e)
        {
            lst_Playlist.Items.Clear();
            //set the range of decrement
            if ((prev_next < num_genres) && (prev_next > 0))
            {
                //decrement carrier - for the index
                prev_next--;
            }
            //properties small change and large change are both 1 - to stop it from over shooting the array index
            int track_index;

            //switch the relevant array value to show the Genre Title
            txt_Genre_Title2.Text = Genre_List[prev_next].Items[0].ToString();

            //(# of items in each genre - 1) = # of tracks 
            track_index = Genre_List[prev_next].Items.Count - 1;

            for (int tracks = 0; tracks < track_index; tracks++)
            {
                //cycle items and add to playlist
                lst_Playlist.Items.Add(Genre_List[prev_next].Items[tracks + 1].ToString());
            }
            //simple switch carrying back the arrays
            
        }

        private void btn_Genre_Next_Click(object sender, EventArgs e)
        {
            lst_Playlist.Items.Clear();
            //limit to between 0 and -1 of number of genres
            //last increment will lock - and avoid crashing because of array overflow.
            if (prev_next < num_genres - 1)
            {
                //increment carrier - for the index
                prev_next++;
            }
            //properties small change and large change are both 1 - to stop it from over shooting the array index
            int track_index;

            //switch the relevant array value to show the Genre Title
            txt_Genre_Title2.Text = Genre_List[prev_next].Items[0].ToString();

            //(# of items in each genre - 1) = # of tracks 
            track_index = Genre_List[prev_next].Items.Count - 1;

            for (int tracks = 0; tracks < track_index; tracks++)
            {
                //cycle items and add to playlist
                lst_Playlist.Items.Add(Genre_List[prev_next].Items[tracks + 1].ToString());
            }
            //simple switch carrying forward the arrays
            
        }

        private void btn_Import_Tracks_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg2 = new FolderBrowserDialog();
            // Tells the application that something has changed 
            bool_Requires_Saving = true;
            // Let the user select the directory the music is coming from 
            if (dlg2.ShowDialog() == DialogResult.OK)
            { // Populates the list array with all the files with the stated extension 
                    foreach (string file in  
                    Directory.EnumerateFiles(dlg2.SelectedPath, "*.*", 
                    SearchOption.AllDirectories).Where(s => s.EndsWith(".mp3") || 
                    s.EndsWith(".wma") || s.EndsWith(".wav") || s.EndsWith(".MP3") || 
                    s.EndsWith(".WMA") || s.EndsWith(".WAV"))) 
                {
                    lst_Imported_Tracks.Items.Add(file);
                }

                if (lst_Imported_Tracks.Items.Count > -1)
                {
                    btn_Import_Tracks.Enabled = false;
                }
                else
                {
                    btn_Import_Tracks.Enabled = true;
                }
            }
        }

        
        private void btn_Clear_Imported_Tracks_Click(object sender, EventArgs e)
        {

        }

        private void btn_Copy_Track_Click(object sender, EventArgs e)
        {
            lst_Playlist.Items.Add(lst_Imported_Tracks.SelectedItem);
        }

        private void btn_Move_Track_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Genre_Track_Click(object sender, EventArgs e)
        {

        }

        private void txt_Genre_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btn_Genre_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Genre_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Setup_OK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Setup_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
