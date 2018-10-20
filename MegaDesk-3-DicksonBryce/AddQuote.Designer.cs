namespace MegaDesk_3_DicksonBryce
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxDrawers = new System.Windows.Forms.ComboBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.boxDepth = new System.Windows.Forms.TextBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlRushOrderDays = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioRush7 = new System.Windows.Forms.RadioButton();
            this.radioRush5 = new System.Windows.Forms.RadioButton();
            this.radioRush3 = new System.Windows.Forms.RadioButton();
            this.radioRushNone = new System.Windows.Forms.RadioButton();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblWidthError = new System.Windows.Forms.Label();
            this.lblDepthError = new System.Windows.Forms.Label();
            this.pnlRushOrderDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(713, 415);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxDrawers
            // 
            this.comboBoxDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrawers.FormattingEnabled = true;
            this.comboBoxDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxDrawers.Location = new System.Drawing.Point(114, 211);
            this.comboBoxDrawers.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxDrawers.Name = "comboBoxDrawers";
            this.comboBoxDrawers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDrawers.TabIndex = 6;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(114, 51);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 20);
            this.boxName.TabIndex = 7;
            this.boxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckIfChar);
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(114, 91);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(100, 20);
            this.boxWidth.TabIndex = 8;
            this.boxWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckIfChar);
            // 
            // boxDepth
            // 
            this.boxDepth.Location = new System.Drawing.Point(114, 131);
            this.boxDepth.Name = "boxDepth";
            this.boxDepth.Size = new System.Drawing.Size(100, 20);
            this.boxDepth.TabIndex = 9;
            this.boxDepth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckIfChar);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(114, 246);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "&Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "&Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "&Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "D&rawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "&Material";
            // 
            // pnlRushOrderDays
            // 
            this.pnlRushOrderDays.Controls.Add(this.label6);
            this.pnlRushOrderDays.Controls.Add(this.radioRush7);
            this.pnlRushOrderDays.Controls.Add(this.radioRush5);
            this.pnlRushOrderDays.Controls.Add(this.radioRush3);
            this.pnlRushOrderDays.Controls.Add(this.radioRushNone);
            this.pnlRushOrderDays.Location = new System.Drawing.Point(671, 188);
            this.pnlRushOrderDays.Name = "pnlRushOrderDays";
            this.pnlRushOrderDays.Size = new System.Drawing.Size(130, 140);
            this.pnlRushOrderDays.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rush &Order";
            // 
            // radioRush7
            // 
            this.radioRush7.AutoSize = true;
            this.radioRush7.Location = new System.Drawing.Point(6, 108);
            this.radioRush7.Name = "radioRush7";
            this.radioRush7.Size = new System.Drawing.Size(53, 17);
            this.radioRush7.TabIndex = 24;
            this.radioRush7.Text = "7 Day";
            this.radioRush7.UseVisualStyleBackColor = true;
            // 
            // radioRush5
            // 
            this.radioRush5.AutoSize = true;
            this.radioRush5.Location = new System.Drawing.Point(6, 84);
            this.radioRush5.Name = "radioRush5";
            this.radioRush5.Size = new System.Drawing.Size(53, 17);
            this.radioRush5.TabIndex = 23;
            this.radioRush5.Text = "5 Day";
            this.radioRush5.UseVisualStyleBackColor = true;
            // 
            // radioRush3
            // 
            this.radioRush3.AutoSize = true;
            this.radioRush3.Location = new System.Drawing.Point(6, 60);
            this.radioRush3.Name = "radioRush3";
            this.radioRush3.Size = new System.Drawing.Size(53, 17);
            this.radioRush3.TabIndex = 22;
            this.radioRush3.Text = "3 Day";
            this.radioRush3.UseVisualStyleBackColor = true;
            // 
            // radioRushNone
            // 
            this.radioRushNone.AutoSize = true;
            this.radioRushNone.Location = new System.Drawing.Point(6, 37);
            this.radioRushNone.Name = "radioRushNone";
            this.radioRushNone.Size = new System.Drawing.Size(45, 17);
            this.radioRushNone.TabIndex = 21;
            this.radioRushNone.Text = "N/A";
            this.radioRushNone.UseVisualStyleBackColor = true;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(220, 55);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(67, 13);
            this.lblNameError.TabIndex = 22;
            this.lblNameError.Text = "lblNameError";
            // 
            // lblWidthError
            // 
            this.lblWidthError.AutoSize = true;
            this.lblWidthError.BackColor = System.Drawing.SystemColors.Control;
            this.lblWidthError.ForeColor = System.Drawing.Color.Red;
            this.lblWidthError.Location = new System.Drawing.Point(221, 94);
            this.lblWidthError.Name = "lblWidthError";
            this.lblWidthError.Size = new System.Drawing.Size(67, 13);
            this.lblWidthError.TabIndex = 23;
            this.lblWidthError.Text = "lblWidthError";
            // 
            // lblDepthError
            // 
            this.lblDepthError.AutoSize = true;
            this.lblDepthError.ForeColor = System.Drawing.Color.Red;
            this.lblDepthError.Location = new System.Drawing.Point(221, 134);
            this.lblDepthError.Name = "lblDepthError";
            this.lblDepthError.Size = new System.Drawing.Size(68, 13);
            this.lblDepthError.TabIndex = 24;
            this.lblDepthError.Text = "lblDepthError";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDepthError);
            this.Controls.Add(this.lblWidthError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.boxDepth);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.comboBoxDrawers);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pnlRushOrderDays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.pnlRushOrderDays.ResumeLayout(false);
            this.pnlRushOrderDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxDrawers;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.TextBox boxDepth;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlRushOrderDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioRush7;
        private System.Windows.Forms.RadioButton radioRush5;
        private System.Windows.Forms.RadioButton radioRush3;
        private System.Windows.Forms.RadioButton radioRushNone;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblWidthError;
        private System.Windows.Forms.Label lblDepthError;
    }
}