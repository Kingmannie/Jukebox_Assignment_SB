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
        public frm_Setup_Window()
        {
            InitializeComponent();
        }

        private void lst_Imported_Tracks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string configPath = Directory.GetCurrentDirectory();
        bool bool_Requires_Saving;
        private void btn_Import_Tracks_Click(object sender, EventArgs e)
        {
            String folderName = Directory.GetCurrentDirectory();
            OpenFileDialog dlg2 = new OpenFileDialog();
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

        private void btn_Genre_Previous_Click(object sender, EventArgs e)
        {

        }

        private void btn_Genre_Next_Click(object sender, EventArgs e)
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

        private void frm_Setup_Window_Load(object sender, EventArgs e)
        {

        }
    }
}
