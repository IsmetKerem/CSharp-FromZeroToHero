namespace FinancialCrm
{
    partial class FrmExpenses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExpensesAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExpensesRemove = new System.Windows.Forms.Button();
            this.btnExpensesUpdate = new System.Windows.Forms.Button();
            this.btnExpensesList = new System.Windows.Forms.Button();
            this.txtExpensesName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpensesAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpensesDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpensesId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(242, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1144, 380);
            this.panel3.TabIndex = 6;
            // 
            // btnExpensesAdd
            // 
            this.btnExpensesAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesAdd.ForeColor = System.Drawing.Color.Black;
            this.btnExpensesAdd.Location = new System.Drawing.Point(369, 265);
            this.btnExpensesAdd.Name = "btnExpensesAdd";
            this.btnExpensesAdd.Size = new System.Drawing.Size(174, 50);
            this.btnExpensesAdd.TabIndex = 13;
            this.btnExpensesAdd.Text = "Yeni Gider";
            this.btnExpensesAdd.UseVisualStyleBackColor = false;
            this.btnExpensesAdd.Click += new System.EventHandler(this.btnExpensesAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnExpensesAdd);
            this.panel2.Controls.Add(this.btnExpensesRemove);
            this.panel2.Controls.Add(this.btnExpensesUpdate);
            this.panel2.Controls.Add(this.btnExpensesList);
            this.panel2.Controls.Add(this.txtExpensesName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtExpensesAmount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtExpensesDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtExpensesId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(242, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 318);
            this.panel2.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Khaki;
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(103, 224);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(1027, 32);
            this.cmbCategory.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Katagori:";
            // 
            // btnExpensesRemove
            // 
            this.btnExpensesRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesRemove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesRemove.ForeColor = System.Drawing.Color.Black;
            this.btnExpensesRemove.Location = new System.Drawing.Point(593, 265);
            this.btnExpensesRemove.Name = "btnExpensesRemove";
            this.btnExpensesRemove.Size = new System.Drawing.Size(174, 50);
            this.btnExpensesRemove.TabIndex = 12;
            this.btnExpensesRemove.Text = "Gider Sil";
            this.btnExpensesRemove.UseVisualStyleBackColor = false;
            this.btnExpensesRemove.Click += new System.EventHandler(this.btnExpensesRemove_Click);
            // 
            // btnExpensesUpdate
            // 
            this.btnExpensesUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnExpensesUpdate.Location = new System.Drawing.Point(843, 265);
            this.btnExpensesUpdate.Name = "btnExpensesUpdate";
            this.btnExpensesUpdate.Size = new System.Drawing.Size(174, 50);
            this.btnExpensesUpdate.TabIndex = 11;
            this.btnExpensesUpdate.Text = "Gider Güncelle";
            this.btnExpensesUpdate.UseVisualStyleBackColor = false;
            this.btnExpensesUpdate.Click += new System.EventHandler(this.btnExpensesUpdate_Click);
            // 
            // btnExpensesList
            // 
            this.btnExpensesList.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesList.ForeColor = System.Drawing.Color.Black;
            this.btnExpensesList.Location = new System.Drawing.Point(125, 265);
            this.btnExpensesList.Name = "btnExpensesList";
            this.btnExpensesList.Size = new System.Drawing.Size(174, 50);
            this.btnExpensesList.TabIndex = 10;
            this.btnExpensesList.Text = "Gider Listesi";
            this.btnExpensesList.UseVisualStyleBackColor = false;
            this.btnExpensesList.Click += new System.EventHandler(this.btnExpensesList_Click);
            // 
            // txtExpensesName
            // 
            this.txtExpensesName.BackColor = System.Drawing.Color.Khaki;
            this.txtExpensesName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpensesName.Location = new System.Drawing.Point(105, 77);
            this.txtExpensesName.Name = "txtExpensesName";
            this.txtExpensesName.Size = new System.Drawing.Size(1027, 32);
            this.txtExpensesName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gider İsmi:";
            // 
            // txtExpensesAmount
            // 
            this.txtExpensesAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtExpensesAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpensesAmount.Location = new System.Drawing.Point(105, 131);
            this.txtExpensesAmount.Name = "txtExpensesAmount";
            this.txtExpensesAmount.Size = new System.Drawing.Size(1027, 32);
            this.txtExpensesAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miktar:";
            // 
            // txtExpensesDate
            // 
            this.txtExpensesDate.BackColor = System.Drawing.Color.Khaki;
            this.txtExpensesDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpensesDate.Location = new System.Drawing.Point(103, 180);
            this.txtExpensesDate.Name = "txtExpensesDate";
            this.txtExpensesDate.Size = new System.Drawing.Size(1027, 32);
            this.txtExpensesDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // txtExpensesId
            // 
            this.txtExpensesId.BackColor = System.Drawing.Color.Khaki;
            this.txtExpensesId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpensesId.Location = new System.Drawing.Point(105, 20);
            this.txtExpensesId.Name = "txtExpensesId";
            this.txtExpensesId.Size = new System.Drawing.Size(1027, 32);
            this.txtExpensesId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider İd:";
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(25, 120);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(174, 51);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(20)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 742);
            this.panel1.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(25, 483);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 51);
            this.button8.TabIndex = 4;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(25, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 51);
            this.button6.TabIndex = 3;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(25, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 51);
            this.button5.TabIndex = 3;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(25, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExpenses";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExpensesAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExpensesRemove;
        private System.Windows.Forms.Button btnExpensesUpdate;
        private System.Windows.Forms.Button btnExpensesList;
        private System.Windows.Forms.TextBox txtExpensesName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExpensesAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpensesDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpensesId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}