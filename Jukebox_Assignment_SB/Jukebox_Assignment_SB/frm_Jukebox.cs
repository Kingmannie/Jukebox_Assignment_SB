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
        string configPath = Directory.GetCurrentDirectory();

        //tells us if the jukebox is playing or not
        bool isPlaying = false;

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
            txt_Genre_Title.Text = Genre_List[0].Items[0].ToString();
            lst_Genre_List.Items.Add(Genre_List[0].Items[1].ToString());

            //set min-max values of scroll bar
            //[taking array index value into consideration, num_genres - 1]
            hscr_Selector.Maximum = num_genres - 1;
            hscr_Selector.Minimum = 0;

            myInputStream.Close();
        }

        private void hscr_Selector_ValueChanged(object sender, EventArgs e)
        {
            lst_Genre_List.Items.Clear();
            //properties small change and large change are both 1 - to stop it from over shooting the array index
            int track_index;
            
            //switch the relevant array value to show the Genre Title
            txt_Genre_Title.Text = Genre_List[hscr_Selector.Value].Items[0].ToString();

            //(# of items in each genre - 1) = # of tracks 
            track_index = Genre_List[hscr_Selector.Value].Items.Count - 1;

            for (int tracks = 0; tracks < track_index; tracks++)
            {
                //(scroll value = genre selector) and (tracks + 1 indicate item index to add)
                lst_Genre_List.Items.Add(Genre_List[hscr_Selector.Value].Items[tracks + 1].ToString());
            }
        }

        private void lst_Genre_List_DoubleClick(object sender, EventArgs e)
        {
            //add selected genre item to playlist
            lst_Playlist.Items.Add(lst_Genre_List.SelectedItem);
            //initiate the track playing method
            track_playing();
        }

        public void track_playing()
        {
            //when no song is playing & playlist is populated.. proceed
            if ((isPlaying == false) && (lst_Playlist.Items.Count > 0)) 
            {

                //textual output will always be first item in playlist
                txt_Presently_Playing.Text = lst_Playlist.Items[0].ToString();
                //remove top item when finished with it
                lst_Playlist.Items.Remove(lst_Playlist.Items[0]);
                //path to track
                media_player.URL = Directory.GetCurrentDirectory() + "\\Tracks\\" + txt_Presently_Playing.Text;
                //play the track
                media_player.Ctlcontrols.play();
                //media_player.Ctlcontrols.next();

                //isPlaying = true;

                //track_timer.Start();
                //track_timer.Interval = 5;
                //track_timer.Stop();

                //tmr.Tick += new EventHandler(tmr_Tick);
                //wplayer = new WMPLib.WindowsMediaPlayer();
                //wplayer.URL = "c:/Standup.mp3";
                //wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
                //wplayer.controls.play();

                //HERE - NEED TO CREATE INTERVAL THAT LASTS AS LONG AS THE TRACK
                //start the timer - to last for the length of the song
                //track_timer.Start();
                //String track_duration = media_player.currentMedia.durationString;
                //media_player.currentMedia.duration;
                //track_timer.Interval = Convert.ToInt32(media_player.currentMedia.duration);
                //track_timer.Stop();

                //if (track_timer.Interval.ToString() == media_player.currentMedia.durationString)
                //{

                //}
            }
        }
        
        private void media_player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) 
        {
            //media_player.settings.setMode("loop", true);
            //media player can pause - timer involved
            if (media_player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                //track is armed
                isPlaying = true;
                track_timer.Enabled = false;
            }
            if (media_player.playState == WMPLib.WMPPlayState.wmppsStopped) //while or else if? - do while?
            {
                isPlaying = false;
                track_timer.Enabled = true;
                
            }

            //lst_Playlist.Items.Count > 0;
            //media_player.currentMedia.durationString;
            //after starting timer, delete the top playlist item
            //lst_Playlist.Items.Remove(lst_Playlist.Items[0]);
            //txt_Presently_Playing.Text = lst_Playlist.Items[0].ToString();

            //wmppsUndefined
            //Windows Media Player is in an undefined state.

            //wmppsStopped
            //Playback is stopped.

            //wmppsPaused
            //Playback is paused.

            //wmppsPlaying
            //Stream is playing.

            //wmppsScanForward
            //Stream is scanning forward.

            //wmppsScanReverse
            //Stream is scanning backward.

            //wmppsBuffering
            //Stream is being buffered.

            //wmppsWaiting
            //Waiting for streaming data.

            //wmppsMediaEnded
            //The end of the media item has been reached.

            //wmppsTransitioning
            //Preparing new media item.

            //wmppsReady
            //Ready to begin playing.

            //wmppsReconnecting
            //Trying to reconnect for streaming data.

            //wmppsLast
            //Last enumerated value.Not a valid state.

        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {
            var frm_Setup_Window = new frm_Setup_Window();
            frm_Setup_Window.Show();

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            var frm_About = new frm_About();
            frm_About.Show();
        }

        private void track_timer_Tick(object sender, EventArgs e)
        {
            //track_timer.Enabled = true;
            track_timer.Start();
            track_timer.Stop();
            track_playing();
        }
    }
}
