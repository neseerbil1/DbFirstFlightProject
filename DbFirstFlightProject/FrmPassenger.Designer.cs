namespace DbFirstFlightProject
{
    partial class FrmPassenger
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCityID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWomenPassengerList = new System.Windows.Forms.Button();
            this.btnMemPassengerList = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.lblTotalPassengerCount = new System.Windows.Forms.Label();
            this.lblWomenCount = new System.Windows.Forms.Label();
            this.lblMenCount = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(517, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 39);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(395, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 39);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(239, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 39);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(12, 187);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 39);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 195);
            this.dataGridView1.TabIndex = 19;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAge.Location = new System.Drawing.Point(154, 73);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(361, 28);
            this.txtAge.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yolcu Soyadı:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(155, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 28);
            this.txtName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yolcu Adı:";
            // 
            // txtCityID
            // 
            this.txtCityID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCityID.Location = new System.Drawing.Point(154, 9);
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.Size = new System.Drawing.Size(361, 28);
            this.txtCityID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "YolcuID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Yolcu Cinsiyeti:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(155, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 28);
            this.textBox2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yolcu Yaşı:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(621, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnWomenPassengerList
            // 
            this.btnWomenPassengerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWomenPassengerList.Location = new System.Drawing.Point(621, 332);
            this.btnWomenPassengerList.Name = "btnWomenPassengerList";
            this.btnWomenPassengerList.Size = new System.Drawing.Size(146, 39);
            this.btnWomenPassengerList.TabIndex = 31;
            this.btnWomenPassengerList.Text = "Kadın Yolcular";
            this.btnWomenPassengerList.UseVisualStyleBackColor = true;
            this.btnWomenPassengerList.Click += new System.EventHandler(this.btnWomenPassengerList_Click);
            // 
            // btnMemPassengerList
            // 
            this.btnMemPassengerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemPassengerList.Location = new System.Drawing.Point(621, 287);
            this.btnMemPassengerList.Name = "btnMemPassengerList";
            this.btnMemPassengerList.Size = new System.Drawing.Size(146, 39);
            this.btnMemPassengerList.TabIndex = 32;
            this.btnMemPassengerList.Text = "Erkek Yolcular";
            this.btnMemPassengerList.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Statistics.Location = new System.Drawing.Point(621, 242);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(146, 39);
            this.Statistics.TabIndex = 33;
            this.Statistics.Text = "İstatistikler";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // lblTotalPassengerCount
            // 
            this.lblTotalPassengerCount.AutoSize = true;
            this.lblTotalPassengerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPassengerCount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPassengerCount.Location = new System.Drawing.Point(572, 13);
            this.lblTotalPassengerCount.Name = "lblTotalPassengerCount";
            this.lblTotalPassengerCount.Size = new System.Drawing.Size(79, 29);
            this.lblTotalPassengerCount.TabIndex = 34;
            this.lblTotalPassengerCount.Text = "label6";
            // 
            // lblWomenCount
            // 
            this.lblWomenCount.AutoSize = true;
            this.lblWomenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWomenCount.ForeColor = System.Drawing.Color.Red;
            this.lblWomenCount.Location = new System.Drawing.Point(572, 53);
            this.lblWomenCount.Name = "lblWomenCount";
            this.lblWomenCount.Size = new System.Drawing.Size(79, 29);
            this.lblWomenCount.TabIndex = 35;
            this.lblWomenCount.Text = "label6";
            // 
            // lblMenCount
            // 
            this.lblMenCount.AutoSize = true;
            this.lblMenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenCount.ForeColor = System.Drawing.Color.Red;
            this.lblMenCount.Location = new System.Drawing.Point(572, 105);
            this.lblMenCount.Name = "lblMenCount";
            this.lblMenCount.Size = new System.Drawing.Size(79, 29);
            this.lblMenCount.TabIndex = 36;
            this.lblMenCount.Text = "label7";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(666, 187);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 37;
            // 
            // FrmPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblMenCount);
            this.Controls.Add(this.lblWomenCount);
            this.Controls.Add(this.lblTotalPassengerCount);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.btnMemPassengerList);
            this.Controls.Add(this.btnWomenPassengerList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCityID);
            this.Controls.Add(this.label1);
            this.Name = "FrmPassenger";
            this.Text = "FrmPassenger";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWomenPassengerList;
        private System.Windows.Forms.Button btnMemPassengerList;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Label lblTotalPassengerCount;
        private System.Windows.Forms.Label lblWomenCount;
        private System.Windows.Forms.Label lblMenCount;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}