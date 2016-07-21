﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MelodicBanjoArranger;
using AlphaTab.Importer;
using AlphaTab.Model;

namespace MelodicBanjoArranger
{
    public partial class TabView : Form
    {
        public TabView()
        {
            InitializeComponent();
        }

        private void TabView_Load(object sender, EventArgs e)
        {

        }

        //Alpha TAB Stuff Below
        //=========================
        //TO DO This all needs to be moved to somewhere better than in the main form code

        private Score _score;
        private int _currentTrackIndex;

        #region Score Data

        public Score Score
        {
            get { return _score; }
            set
            {
                _score = value;
                //            showScoreInfo.Enabled = value != null;
                Text = "AlphaTab - " + (value == null ? "No File Opened" : value.Title);
                CurrentTrackIndex = 0;
            }
        }

        public int CurrentTrackIndex
        {
            get { return _currentTrackIndex; }
            set
            {
                _currentTrackIndex = value;

                var track = CurrentTrack;
                if (track != null)
                {
                    alphaTabControl1.Track = track;
                }
            }
        }

        public Track CurrentTrack
        {
            get
            {
                if (Score == null || CurrentTrackIndex < 0 || CurrentTrackIndex >= _score.Tracks.Count) return null;
                return _score.Tracks[_currentTrackIndex];
            }
        }

        #endregion

        #region Score Loading

        public void InternalOpenFile(byte[] data)
        {
            try
            {
                // load the score from the filesystem
                Score = ScoreLoader.LoadScoreFromBytes(data);
            }

            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "An error during opening the file occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        #endregion

        private void cmdClose_Click(object sender, EventArgs e)
        {

            this.alphaTabControl1.SuspendLayout();
            this.alphaTabControl1.Dispose();                
            this.Dispose();
        }
    }
}
