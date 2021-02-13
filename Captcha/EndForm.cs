using System.Drawing;
using System.Windows.Forms;

namespace Captcha
{
    public partial class EndForm : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelColor;
        private Panel panelInfo;
        private Button btnExit;
        private Label labelInfo;
        private Label labelIcon;

        int ComputedWidth(Label label)
        {
            return label.Text.Length * label.Font.Height;
        }

        public EndForm(bool state)
        {
            InitializeComponent();
            this.labelIcon.ForeColor = ColorTranslator.FromHtml("#fafafa");
            if (state == true)
            {
                this.labelIcon.Text = "\uE73E";
                this.panelColor.BackColor = ColorTranslator.FromHtml("#229222");
            }
            else
            {
                this.labelIcon.Text = "\uE783";
                this.panelColor.BackColor = ColorTranslator.FromHtml("#C22222");
            }
            this.labelIcon.Location = new Point((this.panelColor.Width - ComputedWidth(this.labelIcon)) / 2 - 7, (this.panelColor.Height - this.labelIcon.Font.Height) / 2);

            string outputString = "";
            if (state)
                outputString = "All images are correct!";
            else
                outputString = "Some images do not match.\nPlease try again.";
            this.labelInfo.Text = outputString;
            this.labelInfo.Location = new Point(90, 100);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelIcon = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panelColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.labelIcon);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(173, 275);
            this.panelColor.TabIndex = 0;
            // 
            // labelIcon
            // 
            this.labelIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIcon.AutoSize = true;
            this.labelIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIcon.Location = new System.Drawing.Point(60, 99);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(0);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(50, 60);
            this.labelIcon.TabIndex = 1;
            this.labelIcon.Text = "a";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelInfo.Controls.Add(this.btnExit);
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(173, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(406, 275);
            this.panelInfo.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnExit.Location = new System.Drawing.Point(312, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "OK";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelInfo.Location = new System.Drawing.Point(79, 86);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(62, 23);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "label1";
            // 
            // EndForm
            // 
            this.ClientSize = new System.Drawing.Size(579, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}