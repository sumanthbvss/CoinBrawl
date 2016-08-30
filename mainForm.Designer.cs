namespace WindowsFormsApplication1
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.levelValue = new System.Windows.Forms.TextBox();
            this.atkValue = new System.Windows.Forms.TextBox();
            this.defValue = new System.Windows.Forms.TextBox();
            this.staminaValue = new System.Windows.Forms.TextBox();
            this.tokensValue = new System.Windows.Forms.TextBox();
            this.goldValue = new System.Windows.Forms.TextBox();
            this.satoshiValue = new System.Windows.Forms.TextBox();
            this.arenapointsValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Atk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(9, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Def";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(5, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stamina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(9, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tokens";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(12, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(10, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Satoshi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(12, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Arena Points";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(0, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1073, 2);
            this.label12.TabIndex = 11;
            // 
            // levelValue
            // 
            this.levelValue.Location = new System.Drawing.Point(57, 58);
            this.levelValue.Name = "levelValue";
            this.levelValue.ReadOnly = true;
            this.levelValue.Size = new System.Drawing.Size(59, 22);
            this.levelValue.TabIndex = 13;
            // 
            // atkValue
            // 
            this.atkValue.Location = new System.Drawing.Point(57, 138);
            this.atkValue.Name = "atkValue";
            this.atkValue.ReadOnly = true;
            this.atkValue.Size = new System.Drawing.Size(114, 22);
            this.atkValue.TabIndex = 14;
            // 
            // defValue
            // 
            this.defValue.Location = new System.Drawing.Point(57, 183);
            this.defValue.Name = "defValue";
            this.defValue.ReadOnly = true;
            this.defValue.Size = new System.Drawing.Size(114, 22);
            this.defValue.TabIndex = 15;
            // 
            // staminaValue
            // 
            this.staminaValue.Location = new System.Drawing.Point(69, 231);
            this.staminaValue.Name = "staminaValue";
            this.staminaValue.ReadOnly = true;
            this.staminaValue.Size = new System.Drawing.Size(116, 22);
            this.staminaValue.TabIndex = 16;
            // 
            // tokensValue
            // 
            this.tokensValue.Location = new System.Drawing.Point(69, 281);
            this.tokensValue.Name = "tokensValue";
            this.tokensValue.ReadOnly = true;
            this.tokensValue.Size = new System.Drawing.Size(116, 22);
            this.tokensValue.TabIndex = 17;
            // 
            // goldValue
            // 
            this.goldValue.Location = new System.Drawing.Point(62, 331);
            this.goldValue.Name = "goldValue";
            this.goldValue.ReadOnly = true;
            this.goldValue.Size = new System.Drawing.Size(135, 22);
            this.goldValue.TabIndex = 18;
            // 
            // satoshiValue
            // 
            this.satoshiValue.Location = new System.Drawing.Point(76, 382);
            this.satoshiValue.Name = "satoshiValue";
            this.satoshiValue.ReadOnly = true;
            this.satoshiValue.Size = new System.Drawing.Size(121, 22);
            this.satoshiValue.TabIndex = 19;
            // 
            // arenapointsValue
            // 
            this.arenapointsValue.Location = new System.Drawing.Point(106, 446);
            this.arenapointsValue.Name = "arenapointsValue";
            this.arenapointsValue.ReadOnly = true;
            this.arenapointsValue.Size = new System.Drawing.Size(86, 22);
            this.arenapointsValue.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(463, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 508);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Class";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arenapointsValue);
            this.Controls.Add(this.satoshiValue);
            this.Controls.Add(this.goldValue);
            this.Controls.Add(this.tokensValue);
            this.Controls.Add(this.staminaValue);
            this.Controls.Add(this.defValue);
            this.Controls.Add(this.atkValue);
            this.Controls.Add(this.levelValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox levelValue;
        private System.Windows.Forms.TextBox atkValue;
        private System.Windows.Forms.TextBox defValue;
        private System.Windows.Forms.TextBox staminaValue;
        private System.Windows.Forms.TextBox tokensValue;
        private System.Windows.Forms.TextBox goldValue;
        private System.Windows.Forms.TextBox satoshiValue;
        private System.Windows.Forms.TextBox arenapointsValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}