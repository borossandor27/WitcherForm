
namespace WitcherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Karakterek = new System.Windows.Forms.TabPage();
            this.tab_Kuldetesek = new System.Windows.Forms.TabPage();
            this.tab_Szornyek = new System.Windows.Forms.TabPage();
            this.tab_Targyak = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_Karakterek = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Karakter_update = new System.Windows.Forms.Button();
            this.button_Karakter_delete = new System.Windows.Forms.Button();
            this.button_Karakter_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_Karakter = new System.Windows.Forms.PictureBox();
            this.textBox_Karakter_nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_Ero = new System.Windows.Forms.NumericUpDown();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.textBox_Karakter_gyengeseg = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_Karakterek.SuspendLayout();
            this.tab_Targyak.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Karakter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ero)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Karakterek);
            this.tabControl1.Controls.Add(this.tab_Kuldetesek);
            this.tabControl1.Controls.Add(this.tab_Szornyek);
            this.tabControl1.Controls.Add(this.tab_Targyak);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Karakterek
            // 
            this.tab_Karakterek.Controls.Add(this.button_Karakter_delete);
            this.tab_Karakterek.Controls.Add(this.button_Karakter_insert);
            this.tab_Karakterek.Controls.Add(this.button_Karakter_update);
            this.tab_Karakterek.Controls.Add(this.groupBox2);
            this.tab_Karakterek.Controls.Add(this.listBox_Karakterek);
            this.tab_Karakterek.Location = new System.Drawing.Point(4, 22);
            this.tab_Karakterek.Name = "tab_Karakterek";
            this.tab_Karakterek.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Karakterek.Size = new System.Drawing.Size(792, 424);
            this.tab_Karakterek.TabIndex = 0;
            this.tab_Karakterek.Text = "Karakterek";
            this.tab_Karakterek.UseVisualStyleBackColor = true;
            // 
            // tab_Kuldetesek
            // 
            this.tab_Kuldetesek.Location = new System.Drawing.Point(4, 22);
            this.tab_Kuldetesek.Name = "tab_Kuldetesek";
            this.tab_Kuldetesek.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Kuldetesek.Size = new System.Drawing.Size(792, 424);
            this.tab_Kuldetesek.TabIndex = 1;
            this.tab_Kuldetesek.Text = "Küldetések";
            this.tab_Kuldetesek.UseVisualStyleBackColor = true;
            // 
            // tab_Szornyek
            // 
            this.tab_Szornyek.Location = new System.Drawing.Point(4, 22);
            this.tab_Szornyek.Name = "tab_Szornyek";
            this.tab_Szornyek.Size = new System.Drawing.Size(792, 424);
            this.tab_Szornyek.TabIndex = 2;
            this.tab_Szornyek.Text = "Szörnyek";
            this.tab_Szornyek.UseVisualStyleBackColor = true;
            // 
            // tab_Targyak
            // 
            this.tab_Targyak.Controls.Add(this.groupBox1);
            this.tab_Targyak.Controls.Add(this.listBox1);
            this.tab_Targyak.Location = new System.Drawing.Point(4, 22);
            this.tab_Targyak.Name = "tab_Targyak";
            this.tab_Targyak.Size = new System.Drawing.Size(792, 424);
            this.tab_Targyak.TabIndex = 3;
            this.tab_Targyak.Text = "Tárgyak";
            this.tab_Targyak.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 424);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(251, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karakter adatai";
            // 
            // listBox_Karakterek
            // 
            this.listBox_Karakterek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Karakterek.FormattingEnabled = true;
            this.listBox_Karakterek.Location = new System.Drawing.Point(3, 3);
            this.listBox_Karakterek.Name = "listBox_Karakterek";
            this.listBox_Karakterek.Size = new System.Drawing.Size(233, 418);
            this.listBox_Karakterek.TabIndex = 0;
            this.listBox_Karakterek.SelectedIndexChanged += new System.EventHandler(this.listBox_Karakterek_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Karakter_gyengeseg);
            this.groupBox2.Controls.Add(this.radioButton_No);
            this.groupBox2.Controls.Add(this.radioButton_Ferfi);
            this.groupBox2.Controls.Add(this.numericUpDown_Ero);
            this.groupBox2.Controls.Add(this.textBox_Karakter_nev);
            this.groupBox2.Controls.Add(this.pictureBox_Karakter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(364, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Karakter adatai";
            // 
            // button_Karakter_update
            // 
            this.button_Karakter_update.Location = new System.Drawing.Point(261, 106);
            this.button_Karakter_update.Name = "button_Karakter_update";
            this.button_Karakter_update.Size = new System.Drawing.Size(75, 23);
            this.button_Karakter_update.TabIndex = 2;
            this.button_Karakter_update.Text = "Módosít";
            this.button_Karakter_update.UseVisualStyleBackColor = true;
            // 
            // button_Karakter_delete
            // 
            this.button_Karakter_delete.Location = new System.Drawing.Point(261, 156);
            this.button_Karakter_delete.Name = "button_Karakter_delete";
            this.button_Karakter_delete.Size = new System.Drawing.Size(75, 23);
            this.button_Karakter_delete.TabIndex = 2;
            this.button_Karakter_delete.Text = "Töröl";
            this.button_Karakter_delete.UseVisualStyleBackColor = true;
            // 
            // button_Karakter_insert
            // 
            this.button_Karakter_insert.Location = new System.Drawing.Point(261, 56);
            this.button_Karakter_insert.Name = "button_Karakter_insert";
            this.button_Karakter_insert.Size = new System.Drawing.Size(75, 23);
            this.button_Karakter_insert.TabIndex = 2;
            this.button_Karakter_insert.Text = "Új";
            this.button_Karakter_insert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Erő";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gyengeség";
            // 
            // pictureBox_Karakter
            // 
            this.pictureBox_Karakter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_Karakter.Location = new System.Drawing.Point(3, 168);
            this.pictureBox_Karakter.Name = "pictureBox_Karakter";
            this.pictureBox_Karakter.Size = new System.Drawing.Size(419, 247);
            this.pictureBox_Karakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Karakter.TabIndex = 4;
            this.pictureBox_Karakter.TabStop = false;
            // 
            // textBox_Karakter_nev
            // 
            this.textBox_Karakter_nev.Location = new System.Drawing.Point(57, 29);
            this.textBox_Karakter_nev.Name = "textBox_Karakter_nev";
            this.textBox_Karakter_nev.Size = new System.Drawing.Size(351, 20);
            this.textBox_Karakter_nev.TabIndex = 5;
            // 
            // numericUpDown_Ero
            // 
            this.numericUpDown_Ero.Location = new System.Drawing.Point(57, 69);
            this.numericUpDown_Ero.Name = "numericUpDown_Ero";
            this.numericUpDown_Ero.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Ero.TabIndex = 6;
            this.numericUpDown_Ero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(103, 106);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.Size = new System.Drawing.Size(42, 17);
            this.radioButton_Ferfi.TabIndex = 7;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Text = "férfi";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(166, 106);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(39, 17);
            this.radioButton_No.TabIndex = 7;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // textBox_Karakter_gyengeseg
            // 
            this.textBox_Karakter_gyengeseg.Location = new System.Drawing.Point(88, 135);
            this.textBox_Karakter_gyengeseg.Name = "textBox_Karakter_gyengeseg";
            this.textBox_Karakter_gyengeseg.Size = new System.Drawing.Size(320, 20);
            this.textBox_Karakter_gyengeseg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Witcher adatbázis kezelése";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Karakterek.ResumeLayout(false);
            this.tab_Targyak.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Karakter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Karakterek;
        private System.Windows.Forms.Button button_Karakter_delete;
        private System.Windows.Forms.Button button_Karakter_insert;
        private System.Windows.Forms.Button button_Karakter_update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Karakter_gyengeseg;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ero;
        private System.Windows.Forms.TextBox textBox_Karakter_nev;
        private System.Windows.Forms.PictureBox pictureBox_Karakter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Karakterek;
        private System.Windows.Forms.TabPage tab_Kuldetesek;
        private System.Windows.Forms.TabPage tab_Szornyek;
        private System.Windows.Forms.TabPage tab_Targyak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

