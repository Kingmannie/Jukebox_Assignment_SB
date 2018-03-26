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
using MyDialogs; //for the input box

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

        //save bool
        bool bool_Requires_Saving = false;

        //int selector - to carry the index values 
        Int16 prev_next = 0;

        public frm_Setup_Window()
        {
            InitializeComponent();
        }
        private void frm_Setup_Window_Load(object sender, EventArgs e)
        {

            StreamReader myInputStream = File.OpenText(configPath + "\\Config\\Config.txt");

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

            //starting with first array - disable ability to go backwards
            btn_Genre_Previous.Enabled = false;
            
            myInputStream.Close();

        }

        private void btn_Genre_Previous_Click(object sender, EventArgs e)
        {
            lst_Playlist.Items.Clear();

            if (prev_next >= 0)
            {
                //decrement carrier - for the index
                prev_next--;
                //enable the next button as the prev button decrements.
                btn_Genre_Next.Enabled = true;
            }
            if (prev_next == 0)
            {
                btn_Genre_Previous.Enabled = false;
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

        }

        private void btn_Genre_Next_Click(object sender, EventArgs e)
        {
            lst_Playlist.Items.Clear();

            if (prev_next < num_genres - 1)
            {
                //increment carrier - for the index
                prev_next++;
                //enable the prev button as the next button increments.
                btn_Genre_Previous.Enabled = true;
            }
            if (prev_next == num_genres - 1)
            {
                btn_Genre_Next.Enabled = false;
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
            }
        }
        
        private void btn_Clear_Imported_Tracks_Click(object sender, EventArgs e)
        {
            //clear the import tracks list
            lst_Imported_Tracks.Items.Clear();
            //a way to re-enable import track functionality
            btn_Import_Tracks.Enabled = true;
        }

        private void btn_Copy_Track_Click(object sender, EventArgs e)
        {
            if (lst_Imported_Tracks.SelectedItems.Count >= 1)
            {
                lst_Playlist.Items.Add(lst_Imported_Tracks.SelectedItem);
                //switch on the neccessity to save
                bool_Requires_Saving = true;
            }
            else
            {
                MessageBox.Show("You must Select an item to Copy.");
            }
            
        }

        private void btn_Move_Track_Click(object sender, EventArgs e)
        {

            if (lst_Imported_Tracks.SelectedItems.Count >= 1)
            {
                lst_Playlist.Items.Add(lst_Imported_Tracks.SelectedItem);
                //deleting the selected item at the top - seems like your moving not copying.
                lst_Imported_Tracks.Items.Remove(lst_Imported_Tracks.SelectedItem);
                //switch on the neccessity to save
                bool_Requires_Saving = true;
            }
            else
            {
                MessageBox.Show("You must Select an item to Move.");
            }

        }

        private void btn_Delete_Genre_Track_Click(object sender, EventArgs e)
        {
            //demonstrates deletion of any playlist item.
            if (lst_Playlist.SelectedItems.Count > 0)
            {
                lst_Playlist.Items.Remove(lst_Playlist.SelectedItem);
                //switch on the neccessity to save
                bool_Requires_Saving = true;
            }
            else
            {
                MessageBox.Show("You must Select an item to Delete.");
            }
            
        }

        private void btn_Genre_Add_Click(object sender, EventArgs e)
        {
            string new_genre_name;
            new_genre_name = My_Dialogs.InputBox("Please enter the new 'Genre Title'.");

            //trap user in endless onslaught of data input, until they give up and enter text
            while ((btn_Genre_Add.DialogResult == DialogResult.Cancel) || (new_genre_name == ""))
            {
                MessageBox.Show("You must give the Genre a title!");
                new_genre_name = My_Dialogs.InputBox("Please enter the new 'Genre Title'.");
            }
            //if string isnt empty and the ok is pressed add new genre
            if ((new_genre_name.Length > 0) && (btn_Genre_Add.DialogResult == DialogResult.OK))
            {
                MessageBox.Show("You must give the Genre a title!");
            }

            //add a genre
            num_genres++;
            //clear playlist
            lst_Playlist.Items.Clear();
            //enter new title
            txt_Genre_Title2.Text = new_genre_name;


        }

        private void btn_Genre_Delete_Click(object sender, EventArgs e)
        {
            //DialogResult - msdn.microsoft.com/en-us/library/system.windows.forms.form.dialogresult(v=vs.110).aspx
            DialogResult dialogResult = MessageBox.Show("Deleting the Genre will remove ALL of its tracks from your computer." +
                    "                                    Do you wish to continue??", // some formatting
                                                        "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //delete genre, perhaps use search
            }
            else if (dialogResult == DialogResult.No)
            {
                //returns to setup window
            }
        }

        private void btn_Setup_OK_Click(object sender, EventArgs e)
        {
            //upon selecting the ok button - save new configuration file
            if (bool_Requires_Saving == true)
            {

                //DialogResult - msdn.microsoft.com/en-us/library/system.windows.forms.form.dialogresult(v=vs.110).aspx
                DialogResult dialogResult = MessageBox.Show("You have made changes to the configuration, do you wish to save them?",
                                                            "Warning.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //writeline in a new section to the config.txt
                    //definitely a save feature here that write lines into the right place

                    //saves changes, returns user back to jukebox. this.Close();
                    //on form load, need to create the config file.
                    StreamWriter myOutputStream = File.CreateText(configPath + "\\Config\\Config.txt");

                    for (int i = 0; i <= 10; i++)
                    {
                        myOutputStream.WriteLine(i.ToString());
                    }

                    myOutputStream.Close(); //close StreamWriter stream before using StreamReader

                }
                else if (dialogResult == DialogResult.No)
                {
                    //if user wants to cancel and return to media player, close without saving
                    this.Close();
                }
            }
            else if (bool_Requires_Saving == false)
            {
                this.Close();
            }
        }

        private void btn_Setup_Cancel_Click(object sender, EventArgs e)
        {
            if (bool_Requires_Saving == true)
            {
                //DialogResult - msdn.microsoft.com/en-us/library/system.windows.forms.form.dialogresult(v=vs.110).aspx
                DialogResult dialogResult = MessageBox.Show("You have made changes to the configuration, do you wish to save them?", 
                                                            "Warning.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //saves changes, returns user back to jukebox. this.Close();
                    //on form load, need to create the config file.
                    StreamWriter myOutputStream = File.CreateText(configPath + "\\Config\\Config.txt");

                    //write the config file to build the initial structure for our config file.
                    myOutputStream.WriteLine("3"); //(number of genres)

                    myOutputStream.Close(); //close StreamWriter stream before using StreamReader

                }
                else if (dialogResult == DialogResult.No)
                {
                    //if user wants to cancel and return to media player, close without saving
                    this.Close();
                }
            }
            else if (bool_Requires_Saving == false)
            {
                this.Close();
            }
        }


    }
}
