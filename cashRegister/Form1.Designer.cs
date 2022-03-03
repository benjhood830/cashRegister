namespace cashRegister
{
    partial class Burgers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Burgers));
            this.titleLabel = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.cokeLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.fryInput = new System.Windows.Forms.TextBox();
            this.cokeInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.borderLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptItems = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.receiptTitle = new System.Windows.Forms.Label();
            this.receiptDate = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Elephant", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(59, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(741, 83);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "BURGERS BY BEN";
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(12, 101);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(160, 20);
            this.burgerLabel.TabIndex = 1;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Gold;
            this.menuLabel.Location = new System.Drawing.Point(70, 82);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(43, 13);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "MENU";
            // 
            // fryLabel
            // 
            this.fryLabel.AutoSize = true;
            this.fryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryLabel.Location = new System.Drawing.Point(12, 137);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(137, 20);
            this.fryLabel.TabIndex = 3;
            this.fryLabel.Text = "Number of Fries";
            // 
            // cokeLabel
            // 
            this.cokeLabel.AutoSize = true;
            this.cokeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cokeLabel.Location = new System.Drawing.Point(12, 175);
            this.cokeLabel.Name = "cokeLabel";
            this.cokeLabel.Size = new System.Drawing.Size(147, 20);
            this.cokeLabel.TabIndex = 4;
            this.cokeLabel.Text = "Number of Cokes";
            // 
            // burgerInput
            // 
            this.burgerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerInput.Location = new System.Drawing.Point(179, 94);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(100, 26);
            this.burgerInput.TabIndex = 5;
            // 
            // fryInput
            // 
            this.fryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryInput.Location = new System.Drawing.Point(179, 131);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(100, 26);
            this.fryInput.TabIndex = 6;
            // 
            // cokeInput
            // 
            this.cokeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cokeInput.Location = new System.Drawing.Point(179, 169);
            this.cokeInput.Name = "cokeInput";
            this.cokeInput.Size = new System.Drawing.Size(100, 26);
            this.cokeInput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(22, 205);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(249, 32);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Price";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 284);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(37, 20);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(179, 243);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 26);
            this.subtotalOutput.TabIndex = 10;
            this.subtotalOutput.Text = "                           ";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(11, 249);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(86, 20);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(179, 314);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 26);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.Text = "                           ";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(179, 278);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 26);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.Text = "                           ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 320);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(49, 20);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total";
            // 
            // borderLabel
            // 
            this.borderLabel.BackColor = System.Drawing.Color.Black;
            this.borderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabel.Location = new System.Drawing.Point(5, 352);
            this.borderLabel.Name = "borderLabel";
            this.borderLabel.Size = new System.Drawing.Size(284, 14);
            this.borderLabel.TabIndex = 15;
            this.borderLabel.Text = "                           ";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 379);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(85, 20);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(200, 373);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(79, 26);
            this.tenderedInput.TabIndex = 17;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(22, 409);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(249, 32);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 455);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 20);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.White;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(179, 449);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 26);
            this.changeOutput.TabIndex = 20;
            this.changeOutput.Text = "                           ";
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Green;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.White;
            this.receiptButton.Location = new System.Drawing.Point(22, 490);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(249, 50);
            this.receiptButton.TabIndex = 21;
            this.receiptButton.Text = "Print Reciept";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "$";
            // 
            // receiptItems
            // 
            this.receiptItems.BackColor = System.Drawing.Color.White;
            this.receiptItems.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptItems.Location = new System.Drawing.Point(442, 237);
            this.receiptItems.Name = "receiptItems";
            this.receiptItems.Size = new System.Drawing.Size(394, 263);
            this.receiptItems.TabIndex = 23;
            this.receiptItems.Text = "                           ";
            this.receiptItems.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::cashRegister.Properties.Resources.coke_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 445);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // receiptTitle
            // 
            this.receiptTitle.BackColor = System.Drawing.Color.White;
            this.receiptTitle.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTitle.Location = new System.Drawing.Point(442, 95);
            this.receiptTitle.Name = "receiptTitle";
            this.receiptTitle.Size = new System.Drawing.Size(394, 83);
            this.receiptTitle.TabIndex = 26;
            this.receiptTitle.Text = "                           ";
            this.receiptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.receiptTitle.Visible = false;
            // 
            // receiptDate
            // 
            this.receiptDate.BackColor = System.Drawing.Color.White;
            this.receiptDate.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptDate.Location = new System.Drawing.Point(442, 178);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(394, 59);
            this.receiptDate.TabIndex = 27;
            this.receiptDate.Visible = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Red;
            this.newButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(488, 508);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(312, 32);
            this.newButton.TabIndex = 28;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Visible = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // Burgers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 552);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(this.receiptTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.receiptItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.borderLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.cokeInput);
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.cokeLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Burgers";
            this.Text = "Burgers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label cokeLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox fryInput;
        private System.Windows.Forms.TextBox cokeInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label borderLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label receiptItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label receiptTitle;
        private System.Windows.Forms.Label receiptDate;
        private System.Windows.Forms.Button newButton;
    }
}

