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
            this.buttonExitAdd = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.comboBoxDrawers = new System.Windows.Forms.ComboBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.boxDepth = new System.Windows.Forms.TextBox();
            this.radioRushNone = new System.Windows.Forms.RadioButton();
            this.radioRush3 = new System.Windows.Forms.RadioButton();
            this.radioRush5 = new System.Windows.Forms.RadioButton();
            this.radioRush7 = new System.Windows.Forms.RadioButton();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmQuotePanel = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.rushLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            //this.rushPriceTest = new System.Windows.Forms.Button();
            this.confirmQuotePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExitAdd
            // 
            this.buttonExitAdd.Location = new System.Drawing.Point(12, 415);
            this.buttonExitAdd.Name = "buttonExitAdd";
            this.buttonExitAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonExitAdd.TabIndex = 0;
            this.buttonExitAdd.Text = "Back";
            this.buttonExitAdd.UseVisualStyleBackColor = true;
            this.buttonExitAdd.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(697, 415);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(91, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Confirm Quote";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
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
            this.boxName.Validating += new System.ComponentModel.CancelEventHandler(this.boxName_Validating);
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(114, 91);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(100, 20);
            this.boxWidth.TabIndex = 8;
            this.boxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.boxWidth_Validating);
            this.boxWidth.Validated += new System.EventHandler(this.boxWidth_Validated);
            // 
            // boxDepth
            // 
            this.boxDepth.Location = new System.Drawing.Point(114, 131);
            this.boxDepth.Name = "boxDepth";
            this.boxDepth.Size = new System.Drawing.Size(100, 20);
            this.boxDepth.TabIndex = 9;
            this.boxDepth.Validating += new System.ComponentModel.CancelEventHandler(this.boxDepth_Validating);
            this.boxDepth.Validated += new System.EventHandler(this.boxDepth_Validated);
            // 
            // radioRushNone
            // 
            this.radioRushNone.AutoSize = true;
            this.radioRushNone.Location = new System.Drawing.Point(680, 224);
            this.radioRushNone.Name = "radioRushNone";
            this.radioRushNone.Size = new System.Drawing.Size(45, 17);
            this.radioRushNone.TabIndex = 10;
            this.radioRushNone.Text = "N/A";
            this.radioRushNone.UseVisualStyleBackColor = true;
            // 
            // radioRush3
            // 
            this.radioRush3.AutoSize = true;
            this.radioRush3.Location = new System.Drawing.Point(680, 247);
            this.radioRush3.Name = "radioRush3";
            this.radioRush3.Size = new System.Drawing.Size(53, 17);
            this.radioRush3.TabIndex = 11;
            this.radioRush3.Text = "3 Day";
            this.radioRush3.UseVisualStyleBackColor = true;
            // 
            // radioRush5
            // 
            this.radioRush5.AutoSize = true;
            this.radioRush5.Location = new System.Drawing.Point(680, 271);
            this.radioRush5.Name = "radioRush5";
            this.radioRush5.Size = new System.Drawing.Size(53, 17);
            this.radioRush5.TabIndex = 12;
            this.radioRush5.Text = "5 Day";
            this.radioRush5.UseVisualStyleBackColor = true;
            // 
            // radioRush7
            // 
            this.radioRush7.AutoSize = true;
            this.radioRush7.Location = new System.Drawing.Point(680, 295);
            this.radioRush7.Name = "radioRush7";
            this.radioRush7.Size = new System.Drawing.Size(53, 17);
            this.radioRush7.TabIndex = 13;
            this.radioRush7.Text = "7 Day";
            this.radioRush7.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rush &Order";
            // 
            // confirmQuotePanel
            // 
            this.confirmQuotePanel.Controls.Add(this.buttonSubmit);
            this.confirmQuotePanel.Controls.Add(this.buttonCancel);
            this.confirmQuotePanel.Controls.Add(this.rushLabel);
            this.confirmQuotePanel.Controls.Add(this.materialLabel);
            this.confirmQuotePanel.Controls.Add(this.label7);
            this.confirmQuotePanel.Controls.Add(this.drawerLabel);
            this.confirmQuotePanel.Controls.Add(this.label9);
            this.confirmQuotePanel.Controls.Add(this.depthLabel);
            this.confirmQuotePanel.Controls.Add(this.label10);
            this.confirmQuotePanel.Controls.Add(this.widthLabel);
            this.confirmQuotePanel.Controls.Add(this.label17);
            this.confirmQuotePanel.Controls.Add(this.dateLabel);
            this.confirmQuotePanel.Controls.Add(this.label19);
            this.confirmQuotePanel.Controls.Add(this.nameLabel);
            this.confirmQuotePanel.Controls.Add(this.label21);
            this.confirmQuotePanel.Controls.Add(this.label22);
            this.confirmQuotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmQuotePanel.Location = new System.Drawing.Point(0, 0);
            this.confirmQuotePanel.Margin = new System.Windows.Forms.Padding(0);
            this.confirmQuotePanel.Name = "confirmQuotePanel";
            this.confirmQuotePanel.Size = new System.Drawing.Size(800, 450);
            this.confirmQuotePanel.TabIndex = 21;
            this.confirmQuotePanel.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(697, 415);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(91, 23);
            this.buttonSubmit.TabIndex = 28;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLabel.Location = new System.Drawing.Point(416, 349);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(40, 20);
            this.rushLabel.TabIndex = 23;
            this.rushLabel.Text = "rush";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(416, 303);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(65, 20);
            this.materialLabel.TabIndex = 21;
            this.materialLabel.Text = "material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rush:";
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(416, 257);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(57, 20);
            this.drawerLabel.TabIndex = 19;
            this.drawerLabel.Text = "drawer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Material:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(416, 211);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(50, 20);
            this.depthLabel.TabIndex = 17;
            this.depthLabel.Text = "depth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Drawers:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(416, 165);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(46, 20);
            this.widthLabel.TabIndex = 15;
            this.widthLabel.Text = "width";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(270, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Depth:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(416, 119);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 20);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(270, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "Width:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(416, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(270, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 20);
            this.label21.TabIndex = 14;
            this.label21.Text = "Date:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(270, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 20);
            this.label22.TabIndex = 12;
            this.label22.Text = "Customer:";
            // 
            // rushPriceTest
            // 
            /*
            this.rushPriceTest.Location = new System.Drawing.Point(601, 95);
            this.rushPriceTest.Name = "rushPriceTest";
            this.rushPriceTest.Size = new System.Drawing.Size(95, 23);
            this.rushPriceTest.TabIndex = 29;
            this.rushPriceTest.Text = "Rush Price Test";
            this.rushPriceTest.UseVisualStyleBackColor = true;
            this.rushPriceTest.Click += new System.EventHandler(this.rushPriceTest_Click);
            */
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmQuotePanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Controls.Add(this.rushPriceTest);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.radioRush7);
            this.Controls.Add(this.radioRush5);
            this.Controls.Add(this.radioRush3);
            this.Controls.Add(this.radioRushNone);
            this.Controls.Add(this.boxDepth);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.comboBoxDrawers);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonExitAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.confirmQuotePanel.ResumeLayout(false);
            this.confirmQuotePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitAdd;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ComboBox comboBoxDrawers;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.TextBox boxDepth;
        private System.Windows.Forms.RadioButton radioRushNone;
        private System.Windows.Forms.RadioButton radioRush3;
        private System.Windows.Forms.RadioButton radioRush5;
        private System.Windows.Forms.RadioButton radioRush7;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel confirmQuotePanel;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        //private System.Windows.Forms.Button rushPriceTest;
    }
}