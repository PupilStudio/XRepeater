using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace XRepeater
{
    public partial class Form1 : Form
    {
        string path;
        List<double> pts;
        int curseg;
        WindowsMediaPlayerClass wmp1 = new WindowsMediaPlayerClass();
        bool waitForOpen;
        bool playing = false;
        Timer refreshTimer;

        public Form1()
        {
            InitializeComponent();
        }

        string fmtTime(double dt)
        {
            long t = (long)dt;
            return (t / 60).ToString() + ":" + (t % 60).ToString();
        }
        void RefreshUI()
        {
            this.ListPts.Clear();
            pts.Sort();
            foreach (var i in pts)
                ListPts.Items.Add(fmtTime(i));
            this.LabelSeg.Text = "CurSeg: " + curseg.ToString() ;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            wmp1 = new WindowsMediaPlayerClass();
            wmp1.settings.autoStart = false;
            wmp1.URL = TextPath.Text.Trim();
            wmp1.play();
            waitForOpen = true;
            wmp1.OpenStateChange += (state) =>
            {
                if (waitForOpen)
                {
                    waitForOpen = false;
                    pts = new List<double>();
                    pts.Add(0);
                    pts.Add(wmp1.currentMedia.duration);
                    curseg = 1;
                    RefreshUI();
                    //MessageBox.Show(wmp1.currentMedia.durationString);
                    wmp1.stop();
                    refreshTimer = new Timer();
                    refreshTimer.Enabled = true;
                    refreshTimer.Interval = 500;
                    refreshTimer.Tick += (ss, ee) =>
                    {
                        if (wmp1.controls.currentPosition >= pts[curseg])
                        {
                            wmp1.controls.currentPosition = pts[curseg - 1];
                        }
                        LabelCurTime.Text = "CurTime: " + wmp1.currentPositionString;
                        
                    };
                }
            };

        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                // pause
                wmp1.controls.pause();
                ButtonPlay.Text = "Play";
            } else
            {
                // play
                wmp1.controls.play();
                ButtonPlay.Text = "Pause";
            }
            playing = !playing;
        }

        private void ButtonAddPt_Click(object sender, EventArgs e)
        {
            pts.Add(wmp1.currentPosition);
            ++curseg;
            RefreshUI();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            playing = false;
            wmp1.stop();
            curseg = 1;
            ButtonPlay.Text = "Play";
        }

        private void ButtonNextSeg_Click(object sender, EventArgs e)
        {
            ++curseg;
            if (curseg == pts.Count)
                curseg = 1;
            wmp1.currentPosition = pts[curseg - 1];
        }

        private void ButtonJmpPt_Click(object sender, EventArgs e)
        {
            if (ListPts.SelectedItems.Count == 0) return;
            curseg = ListPts.SelectedItems[0].Index + 1;
            if (curseg == pts.Count)
                --curseg;
            wmp1.currentPosition = pts[curseg - 1];
        }


        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (ListPts.SelectedItems.Count == 0) return;
            if (pts.Count == 2) return;
            if (ListPts.SelectedItems[0].Index == 0
                || ListPts.SelectedItems[0].Index == pts.Count - 1) return;

            if (ListPts.SelectedItems[0].Index == curseg)
            {
                // do nothing
            }
            else if (ListPts.SelectedItems[0].Index == curseg - 1)
            {
                --curseg;
            }
            pts.RemoveAt(ListPts.SelectedItems[0].Index);
            RefreshUI();
        }
    }
}
