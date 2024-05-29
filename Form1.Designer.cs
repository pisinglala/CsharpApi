namespace CsharpApi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.capacityTxtbox = new System.Windows.Forms.TextBox();
            this.locationTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.concertTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionsForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transactionsForm);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(26, 198);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(484, 57);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.capacityTxtbox);
            this.groupBox2.Controls.Add(this.locationTxtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Location);
            this.groupBox2.Controls.Add(this.concertTxtbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 245);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(25, 167);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(484, 57);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // capacityTxtbox
            // 
            this.capacityTxtbox.Location = new System.Drawing.Point(132, 123);
            this.capacityTxtbox.Name = "capacityTxtbox";
            this.capacityTxtbox.Size = new System.Drawing.Size(377, 22);
            this.capacityTxtbox.TabIndex = 5;
            // 
            // locationTxtbox
            // 
            this.locationTxtbox.Location = new System.Drawing.Point(132, 88);
            this.locationTxtbox.Name = "locationTxtbox";
            this.locationTxtbox.Size = new System.Drawing.Size(377, 22);
            this.locationTxtbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacity";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(22, 88);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(58, 16);
            this.Location.TabIndex = 2;
            this.Location.Text = "Location";
            // 
            // concertTxtbox
            // 
            this.concertTxtbox.Location = new System.Drawing.Point(132, 45);
            this.concertTxtbox.Name = "concertTxtbox";
            this.concertTxtbox.Size = new System.Drawing.Size(377, 22);
            this.concertTxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concert Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 122);
            this.dataGridView1.TabIndex = 4;
            // 
            // transactionsForm
            // 
            this.transactionsForm.Location = new System.Drawing.Point(373, 18);
            this.transactionsForm.Name = "transactionsForm";
            this.transactionsForm.Size = new System.Drawing.Size(137, 34);
            this.transactionsForm.TabIndex = 5;
            this.transactionsForm.Text = "Transactions";
            this.transactionsForm.UseVisualStyleBackColor = true;
            this.transactionsForm.Click += new System.EventHandler(this.transactionsForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#-MYSQL API Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox capacityTxtbox;
        private System.Windows.Forms.TextBox locationTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox concertTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button transactionsForm;
    }
}

