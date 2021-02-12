using System;
using System.Drawing;
using System.Windows.Forms;

namespace Captcha
{
    public class CaptchaImage : PictureBox
    {
        //bool used to keep track if the image was selected
        public bool wasSelected;
        //auto-property to hold a keyword defining the image held by the object
        public string AttachedString { get; }
        public CaptchaImage(string literal, Image visual)
        {
            //store data
            this.AttachedString = literal;
            //why did I not use an auto-property for the image as well?
            this.Image = visual;
            this.wasSelected = false;

            //set some visual properties
            this.Dock = DockStyle.Fill;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            //add functionality
            this.Click += CaptchaImage_Click;
            this.Paint += CaptchaImage_Paint;
        }

        private void CaptchaImage_Paint(object sender, PaintEventArgs e)
        {
            //paint the border of the image
            if (this.Tag == null)
                this.Tag = ColorTranslator.FromHtml("#393e46");
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, (Color)this.Tag, ButtonBorderStyle.Solid);
        }

        private void CaptchaImage_Click(object sender, EventArgs e)
        {
            //change the state and color of the border when clicked
            this.wasSelected = !this.wasSelected;
            if (this.wasSelected)
            {
                this.Tag = ColorTranslator.FromHtml("#ffd369");
            }
            else
                this.Tag = ColorTranslator.FromHtml("#393e46");
            //refresh for the change of colors to take place
            this.Refresh();
        }
    }
}