﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        //keep all images that can be displayed
        private List<CaptchaImage> images = new List<CaptchaImage>();

        //auto-property used to identify which images should be selected
        public string CaptchaKey { get; }

        //generate a CaptchaKey based on the available keys in the list of images
        private string GetRandomKey()
        {
            Random rand = new Random();
            return this.images[rand.Next(this.images.Count - 1)].AttachedString;
        }

        public void ShuffleList()
        {
            Random rand = new Random();
            int nrOfShuffles = rand.Next(this.images.Count / 2, 2 * this.images.Count);
            for (int i = 0; i < nrOfShuffles; ++i)
            {
                int randomPosition1 = rand.Next(0, this.images.Count - 1);
                int randomPosition2 = rand.Next(0, this.images.Count - 1);
                CaptchaImage t = this.images[randomPosition1];
                this.images[randomPosition1] = this.images[randomPosition2];
                this.images[randomPosition2] = t;
            }
        }

        public Form1()
        {
            InitializeComponent();

            //add images in the list - can be automated
            this.images.Add(new CaptchaImage("Guitar", Properties.Resources._12_accords_debutants_01));
            this.images.Add(new CaptchaImage("BCD logo", Properties.Resources.bcd_icon));
            this.images.Add(new CaptchaImage("Asus", Properties.Resources.desktop));
            this.images.Add(new CaptchaImage("Asus", Properties.Resources.G14_wallpaper_3840x2160));
            this.images.Add(new CaptchaImage("Formula 1", Properties.Resources.entry));
            this.images.Add(new CaptchaImage("University", Properties.Resources.Screenshot_1));
            this.images.Add(new CaptchaImage("University", Properties.Resources.Screenshot_2));
            this.images.Add(new CaptchaImage("University", Properties.Resources.Screenshot_3));
            this.images.Add(new CaptchaImage("University", Properties.Resources.Untitled));

            //generate the key
            this.CaptchaKey = GetRandomKey();

            //set form properties
            this.Width = 1000;
            this.Height = 750;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#222831");

            //set close button properties
            this.btnClose.ForeColor = ColorTranslator.FromHtml("#393e46");
            this.btnClose.BackColor = Color.Red;
            this.btnClose.Font = new Font("Segoe MDL2 Assets", 10);
            this.btnClose.Text = "\uE8BB";

            ShuffleList();

            //add the images to the form
            foreach (CaptchaImage captchaImage in this.images)
                this.mainTable.Controls.Add(captchaImage);

            //adjust the height of the confirm button
            this.btnConfirm.Height = this.flowPanelBottom.Height;
            this.btnConfirm.ForeColor = ColorTranslator.FromHtml("#fafafa");

            //display the key
            labelSelection.Text = String.Concat("Select all the images containing: ", this.CaptchaKey);
            labelSelection.ForeColor = ColorTranslator.FromHtml("#fafafa");

            //key display is in a panel, it is styled here
            this.panelKeywordDisplay.BackColor = ColorTranslator.FromHtml("#222831");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private bool CheckCaptcha()
        {
            //homework: figure out what my genius came up with
            foreach (CaptchaImage ci in this.images)
                if ((ci.AttachedString == this.CaptchaKey) != (ci.wasSelected == true))
                    return false;
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //show the corresponding message
            EndForm endForm = new EndForm(CheckCaptcha());
            endForm.ShowDialog();
        }
    }
}