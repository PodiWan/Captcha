using System.Drawing;
using System.Windows.Forms;

namespace Captcha
{
    public partial class EndForm : Form
    {
        private TableLayoutPanel mainTable;
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelIcon = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.mainTable.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTable.Controls.Add(this.panelColor, 0, 0);
            this.mainTable.Controls.Add(this.panelInfo, 1, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(579, 275);
            this.mainTable.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(281, 217);
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
            this.Controls.Add(this.mainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTable.ResumeLayout(false);
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