namespace szamlak
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.numericUpDownEgyenleg = new System.Windows.Forms.NumericUpDown();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.szin = new System.Windows.Forms.Label();
            this.evjarat = new System.Windows.Forms.Label();
            this.rendszam = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgyenleg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 450);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.numericUpDownEgyenleg);
            this.groupBox1.Controls.Add(this.textBoxNev);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.szin);
            this.groupBox1.Controls.Add(this.evjarat);
            this.groupBox1.Controls.Add(this.rendszam);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(246, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Számla";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(13, 286);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(295, 51);
            this.delete.TabIndex = 11;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(13, 229);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(295, 51);
            this.update.TabIndex = 10;
            this.update.Text = "Módosítás";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(14, 172);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(295, 51);
            this.insert.TabIndex = 9;
            this.insert.Text = "Új adat";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // numericUpDownEgyenleg
            // 
            this.numericUpDownEgyenleg.Location = new System.Drawing.Point(108, 92);
            this.numericUpDownEgyenleg.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownEgyenleg.Name = "numericUpDownEgyenleg";
            this.numericUpDownEgyenleg.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownEgyenleg.TabIndex = 8;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(107, 66);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(146, 20);
            this.textBoxNev.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(107, 40);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // szin
            // 
            this.szin.AutoSize = true;
            this.szin.Location = new System.Drawing.Point(36, 118);
            this.szin.Name = "szin";
            this.szin.Size = new System.Drawing.Size(65, 13);
            this.szin.TabIndex = 3;
            this.szin.Text = "Nyitasdatum";
            // 
            // evjarat
            // 
            this.evjarat.AutoSize = true;
            this.evjarat.Location = new System.Drawing.Point(48, 92);
            this.evjarat.Name = "evjarat";
            this.evjarat.Size = new System.Drawing.Size(51, 13);
            this.evjarat.TabIndex = 2;
            this.evjarat.Text = "Egyenleg";
            // 
            // rendszam
            // 
            this.rendszam.AutoSize = true;
            this.rendszam.Location = new System.Drawing.Point(11, 66);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(86, 13);
            this.rendszam.TabIndex = 1;
            this.rendszam.Text = "Tulajdonos neve";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(48, 40);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgyenleg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.NumericUpDown numericUpDownEgyenleg;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label szin;
        private System.Windows.Forms.Label evjarat;
        private System.Windows.Forms.Label rendszam;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

