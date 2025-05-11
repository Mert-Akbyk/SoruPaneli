namespace Project0._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int trueNo = 0, falseNo = 0, questioNo = 0;
        private void btnNEXT_Click(object sender, EventArgs e)
        {
            // Butonlar pasif olacak.
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnNEXT.Enabled = false;

            // Resimler gizlenecek.
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            // Soru Sayýsý 1'er artýcak ve soru metni deðiþecek.
            questioNo++;
            QuesNo.Text = questioNo.ToString();

            // Soru sayýsý 5'e ulaþtýðýnda, sonuçlarý göster.
            if (questioNo == 1)
            {
                richTextBox1.Text = "Türkiyen'nin yüzölçümü en büyük komþusu hangisidir? \n \n A) Ýran \n B) Bulgaristan \n C) Gürcistan \n D) Irak \n E) Suriye ";
                btnA.Text = "A) Ýran";
                btnB.Text = "B) Bulgaristan";
                btnC.Text = "C) Gürcistan";
                btnD.Text = "D) Irak";
                btnE.Text = "E) Suriye";
                label3.Text = " A) Ýran";
            }
            else if (questioNo == 2)
            {
                richTextBox1.Text = "2. Soru: 3 + 5 = ? \n \n A) 7 \n B) 8 \n C) 9 \n D) 10 \n E) 11";
                btnA.Text = "A) 7";
                btnB.Text = "B) 8";
                btnC.Text = "C) 9";
                btnD.Text = "D) 10";
                btnE.Text = "E) 11";
                label3.Text = "B) 8";
            }
            else if (questioNo == 3)
            {
                richTextBox1.Text = "3. Soru: 5 + 7 = ? \n \n A) 10 \n B) 11 \n C) 12 \n D) 13 \n E) 14";
                btnA.Text = "A) 10";
                btnB.Text = "B) 11";
                btnC.Text = "C) 12";
                btnD.Text = "D) 13";
                btnE.Text = "E) 14";
                label3.Text = "C) 12";
            }
            else if (questioNo == 4)
            {
                richTextBox1.Text = "4. Soru: 10 - 5 = ? \n \n A) 2 \n B) 3 \n C) 4 \n D) 5 \n E) 6";
                btnA.Text = "A) 2";
                btnB.Text = "B) 3";
                btnC.Text = "C) 4";
                btnD.Text = "D) 5";
                btnE.Text = "E) 6";
                label3.Text = "D) 5";
            }
            else if (questioNo == 5)
            {
                richTextBox1.Text = "5. Soru: 6 - 2 = ? \n \n A) 0 \n B) 1 \n C) 2 \n D) 3 \n E) 4 ";
                btnA.Text = "A) 0";
                btnB.Text = "B) 1";
                btnC.Text = "C) 2";
                btnD.Text = "D) 3";
                btnE.Text = "E) 4";
                label3.Text = "E) 4";
                btnNEXT.Text = "Sonuçlar";
            }
            else
            {
                // Sýnav bittiðinde butunlar pasif olacak.
                richTextBox1.Text = "Sýnavýnýz Bitti.";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnNEXT.Enabled = false;
                MessageBox.Show("Doðru Sayýsý: " + trueNo.ToString() + "\n" + "Yanlýþ Sayýsý: " + falseNo.ToString(), "Sonuçlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnNEXT.Enabled = true;

            label3.Text = btnA.Text;
            if (questioNo == 1)
            {
                trueNo++;
                truee.Text = trueNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseNo++;
                falsee.Text = falseNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnNEXT.Enabled = true;

            label3.Text = btnB.Text;
            if (questioNo == 2)
            {
                trueNo++;
                truee.Text = trueNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseNo++;
                falsee.Text = falseNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnNEXT.Enabled = true;

            label3.Text = btnC.Text;
            if (questioNo == 3)
            {
                trueNo++;
                truee.Text = trueNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseNo++;
                falsee.Text = falseNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnNEXT.Enabled = true;

            label3.Text = btnD.Text;
            if (questioNo == 4)
            {
                trueNo++;
                truee.Text = trueNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseNo++;
                falsee.Text = falseNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnNEXT.Enabled = true;

            label3.Text = btnE.Text;
            if (questioNo == 5)
            {
                trueNo++;
                truee.Text = trueNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseNo++;
                falsee.Text = falseNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
