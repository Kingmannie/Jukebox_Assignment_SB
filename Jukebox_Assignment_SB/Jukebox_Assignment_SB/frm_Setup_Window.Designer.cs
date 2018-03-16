namespace jukebox_assignment_SB
{
    partial class frm_Setup_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Setup_Window));
            this.btn_Setup_OK = new System.Windows.Forms.Button();
            this.btn_Setup_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete_Genre_Track = new System.Windows.Forms.Button();
            this.btn_Move_Track = new System.Windows.Forms.Button();
            this.btn_Copy_Track = new System.Windows.Forms.Button();
            this.grpbx_Present_Genre_Track_List = new System.Windows.Forms.GroupBox();
            this.btn_Genre_Next = new System.Windows.Forms.Button();
            this.btn_Genre_Delete = new System.Windows.Forms.Button();
            this.btn_Genre_Add = new System.Windows.Forms.Button();
            this.btn_Genre_Previous = new System.Windows.Forms.Button();
            this.txt_Genre_Title = new System.Windows.Forms.TextBox();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lst_Playlist = new System.Windows.Forms.ListBox();
            this.grpbx_Imported_Tracks = new System.Windows.Forms.GroupBox();
            this.btn_Clear_Imported_Tracks = new System.Windows.Forms.Button();
            this.btn_Import_Tracks = new System.Windows.Forms.Button();
            this.lst_Imported_Tracks = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.grpbx_Present_Genre_Track_List.SuspendLayout();
            this.grpbx_Imported_Tracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Setup_OK
            // 
            this.btn_Setup_OK.Location = new System.Drawing.Point(581, 472);
            this.btn_Setup_OK.Name = "btn_Setup_OK";
            this.btn_Setup_OK.Size = new System.Drawing.Size(82, 39);
            this.btn_Setup_OK.TabIndex = 1;
            this.btn_Setup_OK.Text = "OK";
            this.btn_Setup_OK.UseVisualStyleBackColor = true;
            this.btn_Setup_OK.Click += new System.EventHandler(this.btn_Setup_OK_Click);
            // 
            // btn_Setup_Cancel
            // 
            this.btn_Setup_Cancel.Location = new System.Drawing.Point(669, 472);
            this.btn_Setup_Cancel.Name = "btn_Setup_Cancel";
            this.btn_Setup_Cancel.Size = new System.Drawing.Size(82, 39);
            this.btn_Setup_Cancel.TabIndex = 2;
            this.btn_Setup_Cancel.Text = "Cancel";
            this.btn_Setup_Cancel.UseVisualStyleBackColor = true;
            this.btn_Setup_Cancel.Click += new System.EventHandler(this.btn_Setup_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Delete_Genre_Track);
            this.panel1.Controls.Add(this.btn_Move_Track);
            this.panel1.Controls.Add(this.btn_Copy_Track);
            this.panel1.Controls.Add(this.grpbx_Present_Genre_Track_List);
            this.panel1.Controls.Add(this.grpbx_Imported_Tracks);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 443);
            this.panel1.TabIndex = 3;
            // 
            // btn_Delete_Genre_Track
            // 
            this.btn_Delete_Genre_Track.Location = new System.Drawing.Point(331, 278);
            this.btn_Delete_Genre_Track.Name = "btn_Delete_Genre_Track";
            this.btn_Delete_Genre_Track.Size = new System.Drawing.Size(117, 43);
            this.btn_Delete_Genre_Track.TabIndex = 4;
            this.btn_Delete_Genre_Track.Text = "Delete Track From Genre";
            this.btn_Delete_Genre_Track.UseVisualStyleBackColor = true;
            this.btn_Delete_Genre_Track.Click += new System.EventHandler(this.btn_Delete_Genre_Track_Click);
            // 
            // btn_Move_Track
            // 
            this.btn_Move_Track.Location = new System.Drawing.Point(331, 128);
            this.btn_Move_Track.Name = "btn_Move_Track";
            this.btn_Move_Track.Size = new System.Drawing.Size(117, 23);
            this.btn_Move_Track.TabIndex = 3;
            this.btn_Move_Track.Text = "Move Track >>";
            this.btn_Move_Track.UseVisualStyleBackColor = true;
            this.btn_Move_Track.Click += new System.EventHandler(this.btn_Move_Track_Click);
            // 
            // btn_Copy_Track
            // 
            this.btn_Copy_Track.Location = new System.Drawing.Point(331, 100);
            this.btn_Copy_Track.Name = "btn_Copy_Track";
            this.btn_Copy_Track.Size = new System.Drawing.Size(117, 22);
            this.btn_Copy_Track.TabIndex = 2;
            this.btn_Copy_Track.Text = "Copy Track >>";
            this.btn_Copy_Track.UseVisualStyleBackColor = true;
            this.btn_Copy_Track.Click += new System.EventHandler(this.btn_Copy_Track_Click);
            // 
            // grpbx_Present_Genre_Track_List
            // 
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.btn_Genre_Next);
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.btn_Genre_Delete);
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.btn_Genre_Add);
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.btn_Genre_Previous);
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.txt_Genre_Title);
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.lbl_Genre);
            this.grpbx_Present_Genre_Track_List.Controls.Add(this.lst_Playlist);
            this.grpbx_Present_Genre_Track_List.Location = new System.Drawing.Point(478, 10);
            this.grpbx_Present_Genre_Track_List.Margin = new System.Windows.Forms.Padding(10);
            this.grpbx_Present_Genre_Track_List.Name = "grpbx_Present_Genre_Track_List";
            this.grpbx_Present_Genre_Track_List.Size = new System.Drawing.Size(278, 421);
            this.grpbx_Present_Genre_Track_List.TabIndex = 1;
            this.grpbx_Present_Genre_Track_List.TabStop = false;
            this.grpbx_Present_Genre_Track_List.Text = "Present Genre Track List";
            // 
            // btn_Genre_Next
            // 
            this.btn_Genre_Next.Location = new System.Drawing.Point(177, 354);
            this.btn_Genre_Next.Name = "btn_Genre_Next";
            this.btn_Genre_Next.Size = new System.Drawing.Size(93, 61);
            this.btn_Genre_Next.TabIndex = 6;
            this.btn_Genre_Next.Text = "Next >>";
            this.btn_Genre_Next.UseVisualStyleBackColor = true;
            this.btn_Genre_Next.Click += new System.EventHandler(this.btn_Genre_Next_Click);
            // 
            // btn_Genre_Delete
            // 
            this.btn_Genre_Delete.Location = new System.Drawing.Point(105, 392);
            this.btn_Genre_Delete.Name = "btn_Genre_Delete";
            this.btn_Genre_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_Genre_Delete.TabIndex = 5;
            this.btn_Genre_Delete.Text = "Delete";
            this.btn_Genre_Delete.UseVisualStyleBackColor = true;
            this.btn_Genre_Delete.Click += new System.EventHandler(this.btn_Genre_Delete_Click);
            // 
            // btn_Genre_Add
            // 
            this.btn_Genre_Add.Location = new System.Drawing.Point(105, 353);
            this.btn_Genre_Add.Name = "btn_Genre_Add";
            this.btn_Genre_Add.Size = new System.Drawing.Size(66, 23);
            this.btn_Genre_Add.TabIndex = 4;
            this.btn_Genre_Add.Text = "Add";
            this.btn_Genre_Add.UseVisualStyleBackColor = true;
            this.btn_Genre_Add.Click += new System.EventHandler(this.btn_Genre_Add_Click);
            // 
            // btn_Genre_Previous
            // 
            this.btn_Genre_Previous.Location = new System.Drawing.Point(6, 354);
            this.btn_Genre_Previous.Name = "btn_Genre_Previous";
            this.btn_Genre_Previous.Size = new System.Drawing.Size(93, 61);
            this.btn_Genre_Previous.TabIndex = 3;
            this.btn_Genre_Previous.Text = "<< Previous";
            this.btn_Genre_Previous.UseVisualStyleBackColor = true;
            this.btn_Genre_Previous.Click += new System.EventHandler(this.btn_Genre_Previous_Click);
            // 
            // txt_Genre_Title
            // 
            this.txt_Genre_Title.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Genre_Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Genre_Title.Location = new System.Drawing.Point(6, 48);
            this.txt_Genre_Title.Name = "txt_Genre_Title";
            this.txt_Genre_Title.Size = new System.Drawing.Size(264, 27);
            this.txt_Genre_Title.TabIndex = 2;
            this.txt_Genre_Title.Text = "Playlist 1";
            this.txt_Genre_Title.TextChanged += new System.EventHandler(this.txt_Genre_Title_TextChanged);
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genre.Location = new System.Drawing.Point(6, 32);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(70, 13);
            this.lbl_Genre.TabIndex = 1;
            this.lbl_Genre.Text = "Genre Title";
            // 
            // lst_Playlist
            // 
            this.lst_Playlist.FormattingEnabled = true;
            this.lst_Playlist.Location = new System.Drawing.Point(6, 84);
            this.lst_Playlist.Name = "lst_Playlist";
            this.lst_Playlist.Size = new System.Drawing.Size(264, 264);
            this.lst_Playlist.TabIndex = 0;
            this.lst_Playlist.SelectedIndexChanged += new System.EventHandler(this.lst_Playlist_SelectedIndexChanged);
            // 
            // grpbx_Imported_Tracks
            // 
            this.grpbx_Imported_Tracks.Controls.Add(this.btn_Clear_Imported_Tracks);
            this.grpbx_Imported_Tracks.Controls.Add(this.btn_Import_Tracks);
            this.grpbx_Imported_Tracks.Controls.Add(this.lst_Imported_Tracks);
            this.grpbx_Imported_Tracks.Location = new System.Drawing.Point(10, 10);
            this.grpbx_Imported_Tracks.Margin = new System.Windows.Forms.Padding(10);
            this.grpbx_Imported_Tracks.Name = "grpbx_Imported_Tracks";
            this.grpbx_Imported_Tracks.Size = new System.Drawing.Size(289, 421);
            this.grpbx_Imported_Tracks.TabIndex = 0;
            this.grpbx_Imported_Tracks.TabStop = false;
            this.grpbx_Imported_Tracks.Text = "Imported Tracks";
            // 
            // btn_Clear_Imported_Tracks
            // 
            this.btn_Clear_Imported_Tracks.Location = new System.Drawing.Point(6, 382);
            this.btn_Clear_Imported_Tracks.Name = "btn_Clear_Imported_Tracks";
            this.btn_Clear_Imported_Tracks.Size = new System.Drawing.Size(277, 23);
            this.btn_Clear_Imported_Tracks.TabIndex = 2;
            this.btn_Clear_Imported_Tracks.Text = "Clear Imported Tracks";
            this.btn_Clear_Imported_Tracks.UseVisualStyleBackColor = true;
            this.btn_Clear_Imported_Tracks.Click += new System.EventHandler(this.btn_Clear_Imported_Tracks_Click);
            // 
            // btn_Import_Tracks
            // 
            this.btn_Import_Tracks.Location = new System.Drawing.Point(6, 354);
            this.btn_Import_Tracks.Name = "btn_Import_Tracks";
            this.btn_Import_Tracks.Size = new System.Drawing.Size(277, 22);
            this.btn_Import_Tracks.TabIndex = 1;
            this.btn_Import_Tracks.Text = "Import Tracks From Directory";
            this.btn_Import_Tracks.UseVisualStyleBackColor = true;
            this.btn_Import_Tracks.Click += new System.EventHandler(this.btn_Import_Tracks_Click);
            // 
            // lst_Imported_Tracks
            // 
            this.lst_Imported_Tracks.FormattingEnabled = true;
            this.lst_Imported_Tracks.Location = new System.Drawing.Point(6, 19);
            this.lst_Imported_Tracks.Name = "lst_Imported_Tracks";
            this.lst_Imported_Tracks.Size = new System.Drawing.Size(277, 329);
            this.lst_Imported_Tracks.TabIndex = 0;
            this.lst_Imported_Tracks.SelectedIndexChanged += new System.EventHandler(this.lst_Imported_Tracks_SelectedIndexChanged);
            // 
            // frm_Setup_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Setup_Cancel);
            this.Controls.Add(this.btn_Setup_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Setup_Window";
            this.Text = "Setup";
            this.panel1.ResumeLayout(false);
            this.grpbx_Present_Genre_Track_List.ResumeLayout(false);
            this.grpbx_Present_Genre_Track_List.PerformLayout();
            this.grpbx_Imported_Tracks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Setup_OK;
        private System.Windows.Forms.Button btn_Setup_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Delete_Genre_Track;
        private System.Windows.Forms.Button btn_Move_Track;
        private System.Windows.Forms.Button btn_Copy_Track;
        private System.Windows.Forms.GroupBox grpbx_Present_Genre_Track_List;
        private System.Windows.Forms.ListBox lst_Playlist;
        private System.Windows.Forms.GroupBox grpbx_Imported_Tracks;
        private System.Windows.Forms.ListBox lst_Imported_Tracks;
        private System.Windows.Forms.Button btn_Clear_Imported_Tracks;
        private System.Windows.Forms.Button btn_Import_Tracks;
        private System.Windows.Forms.TextBox txt_Genre_Title;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Button btn_Genre_Next;
        private System.Windows.Forms.Button btn_Genre_Delete;
        private System.Windows.Forms.Button btn_Genre_Add;
        private System.Windows.Forms.Button btn_Genre_Previous;
    }
}