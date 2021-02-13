namespace Captcha
{
    partial class Form1
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
            this.flowPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.labelSelection = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.formTable = new System.Windows.Forms.TableLayoutPanel();
            this.panelKeywordDisplay = new System.Windows.Forms.Panel();
            this.flowPanelBottom.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.formTable.SuspendLayout();
            this.panelKeywordDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelBottom
            // 
            this.flowPanelBottom.Controls.Add(this.btnConfirm);
            this.flowPanelBottom.Controls.Add(this.panelKeywordDisplay);
            this.flowPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowPanelBottom.Location = new System.Drawing.Point(3, 631);
            this.flowPanelBottom.Name = "flowPanelBottom";
            this.flowPanelBottom.Size = new System.Drawing.Size(1316, 65);
            this.flowPanelBottom.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15F);
            this.btnConfirm.Location = new System.Drawing.Point(1174, 0);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(142, 65);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // labelSelection
            // 
            this.labelSelection.AutoSize = true;
            this.labelSelection.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelection.Location = new System.Drawing.Point(3, 16);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(62, 23);
            this.labelSelection.TabIndex = 2;
            this.labelSelection.Text = "label1";
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(3, 37);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.Size = new System.Drawing.Size(1316, 588);
            this.mainTable.TabIndex = 4;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1316, 28);
            this.headerPanel.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1286, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formTable
            // 
            this.formTable.ColumnCount = 1;
            this.formTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formTable.Controls.Add(this.mainTable, 0, 1);
            this.formTable.Controls.Add(this.flowPanelBottom, 0, 2);
            this.formTable.Controls.Add(this.headerPanel, 0, 0);
            this.formTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTable.Location = new System.Drawing.Point(0, 0);
            this.formTable.Margin = new System.Windows.Forms.Padding(0);
            this.formTable.Name = "formTable";
            this.formTable.RowCount = 3;
            this.formTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.formTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.formTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.formTable.Size = new System.Drawing.Size(1322, 699);
            this.formTable.TabIndex = 6;
            // 
            // panelKeywordDisplay
            // 
            this.panelKeywordDisplay.BackColor = System.Drawing.Color.Red;
            this.panelKeywordDisplay.Controls.Add(this.labelSelection);
            this.panelKeywordDisplay.Location = new System.Drawing.Point(563, 3);
            this.panelKeywordDisplay.Name = "panelKeywordDisplay";
            this.panelKeywordDisplay.Size = new System.Drawing.Size(608, 62);
            this.panelKeywordDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 699);
            this.Controls.Add(this.formTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowPanelBottom.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.formTable.ResumeLayout(false);
            this.panelKeywordDisplay.ResumeLayout(false);
            this.panelKeywordDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelBottom;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel formTable;
        private System.Windows.Forms.Label labelSelection;
        private System.Windows.Forms.Panel panelKeywordDisplay;
    }
}

