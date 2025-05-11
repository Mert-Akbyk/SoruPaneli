namespace Project0._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            label1 = new Label();
            label2 = new Label();
            QuesNo = new Label();
            label4 = new Label();
            truee = new Label();
            falsee = new Label();
            btnNEXT = new Button();
            label3 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(504, 248);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.BackColor = SystemColors.Control;
            btnA.Location = new Point(22, 266);
            btnA.Name = "btnA";
            btnA.Size = new Size(85, 29);
            btnA.TabIndex = 1;
            btnA.Tag = "";
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(113, 266);
            btnB.Name = "btnB";
            btnB.Size = new Size(85, 29);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(223, 266);
            btnC.Name = "btnC";
            btnC.Size = new Size(85, 29);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(331, 266);
            btnD.Name = "btnD";
            btnD.Size = new Size(85, 29);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnE
            // 
            btnE.Location = new Point(422, 266);
            btnE.Name = "btnE";
            btnE.Size = new Size(85, 29);
            btnE.TabIndex = 5;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(539, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 6;
            label1.Text = "Soru Nu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(553, 57);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 7;
            label2.Text = "Doğru:";
            // 
            // QuesNo
            // 
            QuesNo.AutoSize = true;
            QuesNo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            QuesNo.Location = new Point(630, 21);
            QuesNo.Name = "QuesNo";
            QuesNo.Size = new Size(20, 23);
            QuesNo.TabIndex = 8;
            QuesNo.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(553, 101);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 9;
            label4.Text = "Yanlış:";
            // 
            // truee
            // 
            truee.AutoSize = true;
            truee.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            truee.Location = new Point(630, 57);
            truee.Name = "truee";
            truee.Size = new Size(20, 23);
            truee.TabIndex = 10;
            truee.Text = "0";
            // 
            // falsee
            // 
            falsee.AutoSize = true;
            falsee.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            falsee.Location = new Point(630, 101);
            falsee.Name = "falsee";
            falsee.Size = new Size(20, 23);
            falsee.TabIndex = 11;
            falsee.Text = "0";
            // 
            // btnNEXT
            // 
            btnNEXT.Location = new Point(535, 138);
            btnNEXT.Name = "btnNEXT";
            btnNEXT.Size = new Size(138, 29);
            btnNEXT.TabIndex = 12;
            btnNEXT.Text = "Sonraki Soru";
            btnNEXT.UseVisualStyleBackColor = true;
            btnNEXT.Click += btnNEXT_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 251);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 18;
            label3.Text = "label3";
            label3.Visible = false;
           // label3.Click += this.label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 277);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "label5";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(539, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(535, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 305);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnNEXT);
            Controls.Add(falsee);
            Controls.Add(truee);
            Controls.Add(label4);
            Controls.Add(QuesNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnE);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Tag = "A";
            Text = "Quiz Panel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Label label1;
        private Label label2;
        private Label QuesNo;
        private Label label4;
        private Label truee;
        private Label falsee;
        private Button btnNEXT;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
