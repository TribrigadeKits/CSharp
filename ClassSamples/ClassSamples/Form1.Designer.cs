namespace ClassSamples
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
            btnAnimalInstanceCreate = new Button();
            txtName1 = new TextBox();
            txtName2 = new TextBox();
            txtColor1 = new TextBox();
            txtColor2 = new TextBox();
            txtSing1 = new TextBox();
            txtSing2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAnimalInstanceCreate
            // 
            btnAnimalInstanceCreate.Location = new Point(103, 38);
            btnAnimalInstanceCreate.Name = "btnAnimalInstanceCreate";
            btnAnimalInstanceCreate.Size = new Size(373, 29);
            btnAnimalInstanceCreate.TabIndex = 0;
            btnAnimalInstanceCreate.Text = "動物クラスのインスタンス生成";
            btnAnimalInstanceCreate.UseVisualStyleBackColor = true;
            btnAnimalInstanceCreate.Click += btnAnimalInstanceCreate_Click;
            // 
            // txtName1
            // 
            txtName1.Location = new Point(103, 156);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(148, 27);
            txtName1.TabIndex = 1;
            // 
            // txtName2
            // 
            txtName2.Location = new Point(328, 157);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(148, 27);
            txtName2.TabIndex = 2;
            // 
            // txtColor1
            // 
            txtColor1.Location = new Point(103, 208);
            txtColor1.Name = "txtColor1";
            txtColor1.Size = new Size(148, 27);
            txtColor1.TabIndex = 3;
            // 
            // txtColor2
            // 
            txtColor2.Location = new Point(328, 208);
            txtColor2.Name = "txtColor2";
            txtColor2.Size = new Size(148, 27);
            txtColor2.TabIndex = 4;
            // 
            // txtSing1
            // 
            txtSing1.Location = new Point(103, 259);
            txtSing1.Name = "txtSing1";
            txtSing1.Size = new Size(148, 27);
            txtSing1.TabIndex = 5;
            // 
            // txtSing2
            // 
            txtSing2.Location = new Point(328, 259);
            txtSing2.Name = "txtSing2";
            txtSing2.Size = new Size(148, 27);
            txtSing2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 112);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "動物1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 112);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "動物2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 157);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "名前";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 208);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 10;
            label4.Text = "色";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 266);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 11;
            label5.Text = "鳴き声";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 356);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSing2);
            Controls.Add(txtSing1);
            Controls.Add(txtColor2);
            Controls.Add(txtColor1);
            Controls.Add(txtName2);
            Controls.Add(txtName1);
            Controls.Add(btnAnimalInstanceCreate);
            Name = "Form1";
            Text = "Animal Class Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnimalInstanceCreate;
        private TextBox txtName1;
        private TextBox txtName2;
        private TextBox txtColor1;
        private TextBox txtColor2;
        private TextBox txtSing1;
        private TextBox txtSing2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
