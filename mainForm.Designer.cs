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
            this.atk_btn = new System.Windows.Forms.Button();
            this.def_btn = new System.Windows.Forms.Button();
            this.stamina_btn = new System.Windows.Forms.Button();
            this.tokens_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.tokenBar = new System.Windows.Forms.ProgressBar();
            this.bitcoinAddr = new System.Windows.Forms.Label();
            this.bitconAddressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.satoshiWithdraw_btn = new System.Windows.Forms.Button();
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Atk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Def";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(5, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stamina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(5, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tokens";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(5, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Satoshi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(5, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Arena Points";
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
            this.levelValue.Location = new System.Drawing.Point(76, 58);
            this.levelValue.Name = "levelValue";
            this.levelValue.ReadOnly = true;
            this.levelValue.Size = new System.Drawing.Size(59, 22);
            this.levelValue.TabIndex = 13;
            // 
            // atkValue
            // 
            this.atkValue.Location = new System.Drawing.Point(76, 125);
            this.atkValue.Name = "atkValue";
            this.atkValue.ReadOnly = true;
            this.atkValue.Size = new System.Drawing.Size(114, 22);
            this.atkValue.TabIndex = 14;
            // 
            // defValue
            // 
            this.defValue.Location = new System.Drawing.Point(76, 163);
            this.defValue.Name = "defValue";
            this.defValue.ReadOnly = true;
            this.defValue.Size = new System.Drawing.Size(114, 22);
            this.defValue.TabIndex = 15;
            // 
            // staminaValue
            // 
            this.staminaValue.Location = new System.Drawing.Point(76, 200);
            this.staminaValue.Name = "staminaValue";
            this.staminaValue.ReadOnly = true;
            this.staminaValue.Size = new System.Drawing.Size(114, 22);
            this.staminaValue.TabIndex = 16;            
            // 
            // tokensValue
            // 
            this.tokensValue.Location = new System.Drawing.Point(76, 237);
            this.tokensValue.Name = "tokensValue";
            this.tokensValue.ReadOnly = true;
            this.tokensValue.Size = new System.Drawing.Size(114, 22);
            this.tokensValue.TabIndex = 17;
            // 
            // goldValue
            // 
            this.goldValue.Location = new System.Drawing.Point(76, 273);
            this.goldValue.Name = "goldValue";
            this.goldValue.ReadOnly = true;
            this.goldValue.Size = new System.Drawing.Size(114, 22);
            this.goldValue.TabIndex = 18;
            // 
            // satoshiValue
            // 
            this.satoshiValue.Location = new System.Drawing.Point(76, 308);
            this.satoshiValue.Name = "satoshiValue";
            this.satoshiValue.ReadOnly = true;
            this.satoshiValue.Size = new System.Drawing.Size(114, 22);
            this.satoshiValue.TabIndex = 19;
            // 
            // arenapointsValue
            // 
            this.arenapointsValue.Location = new System.Drawing.Point(104, 346);
            this.arenapointsValue.Name = "arenapointsValue";
            this.arenapointsValue.ReadOnly = true;
            this.arenapointsValue.Size = new System.Drawing.Size(112, 22);
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
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Class";
            // 
            // atk_btn
            // 
            this.atk_btn.Location = new System.Drawing.Point(213, 124);
            this.atk_btn.Name = "atk_btn";
            this.atk_btn.Size = new System.Drawing.Size(138, 23);
            this.atk_btn.TabIndex = 23;
            this.atk_btn.Text = "button1";
            this.atk_btn.UseVisualStyleBackColor = true;
            this.atk_btn.Click += new System.EventHandler(this.atk_btn_Click);
            // 
            // def_btn
            // 
            this.def_btn.Location = new System.Drawing.Point(213, 163);
            this.def_btn.Name = "def_btn";
            this.def_btn.Size = new System.Drawing.Size(138, 23);
            this.def_btn.TabIndex = 24;
            this.def_btn.Text = "button2";
            this.def_btn.UseVisualStyleBackColor = true;
            this.def_btn.Click += new System.EventHandler(this.def_btn_Click);
            // 
            // stamina_btn
            // 
            this.stamina_btn.Location = new System.Drawing.Point(213, 200);
            this.stamina_btn.Name = "stamina_btn";
            this.stamina_btn.Size = new System.Drawing.Size(138, 23);
            this.stamina_btn.TabIndex = 25;
            this.stamina_btn.Text = "button3";
            this.stamina_btn.UseVisualStyleBackColor = true;
            this.stamina_btn.Click += new System.EventHandler(this.stamina_btn_Click);
            // 
            // tokens_btn
            // 
            this.tokens_btn.Location = new System.Drawing.Point(213, 237);
            this.tokens_btn.Name = "tokens_btn";
            this.tokens_btn.Size = new System.Drawing.Size(138, 23);
            this.tokens_btn.TabIndex = 26;
            this.tokens_btn.Text = "button4";
            this.tokens_btn.UseVisualStyleBackColor = true;
            this.tokens_btn.Click += new System.EventHandler(this.tokens_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(15, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 27;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(124, 12);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 28;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(341, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 29;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(231, 12);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 30;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // tokenBar
            // 
            this.tokenBar.Location = new System.Drawing.Point(577, 91);
            this.tokenBar.Name = "tokenBar";
            this.tokenBar.Size = new System.Drawing.Size(183, 23);
            this.tokenBar.TabIndex = 31;
            // 
            // bitcoinAddr
            // 
            this.bitcoinAddr.AutoSize = true;
            this.bitcoinAddr.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bitcoinAddr.Location = new System.Drawing.Point(5, 385);
            this.bitcoinAddr.Name = "bitcoinAddr";
            this.bitcoinAddr.Size = new System.Drawing.Size(108, 16);
            this.bitcoinAddr.TabIndex = 32;
            this.bitcoinAddr.Text = "Bitcoin Address";
            // 
            // bitconAddressTextBox
            // 
            this.bitconAddressTextBox.Location = new System.Drawing.Point(8, 413);
            this.bitconAddressTextBox.Name = "bitconAddressTextBox";
            this.bitconAddressTextBox.Size = new System.Drawing.Size(280, 22);
            this.bitconAddressTextBox.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satoshiWithdraw_btn
            // 
            this.satoshiWithdraw_btn.Location = new System.Drawing.Point(213, 308);
            this.satoshiWithdraw_btn.Name = "satoshiWithdraw_btn";
            this.satoshiWithdraw_btn.Size = new System.Drawing.Size(171, 23);
            this.satoshiWithdraw_btn.TabIndex = 35;
            this.satoshiWithdraw_btn.Text = "Withdraw (Min. 100000 Satoshi)";
            this.satoshiWithdraw_btn.UseVisualStyleBackColor = true;            
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 554);
            this.Controls.Add(this.satoshiWithdraw_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bitconAddressTextBox);
            this.Controls.Add(this.bitcoinAddr);
            this.Controls.Add(this.tokenBar);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.tokens_btn);
            this.Controls.Add(this.stamina_btn);
            this.Controls.Add(this.def_btn);
            this.Controls.Add(this.atk_btn);
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
        private System.Windows.Forms.Button atk_btn;
        private System.Windows.Forms.Button def_btn;
        private System.Windows.Forms.Button stamina_btn;
        private System.Windows.Forms.Button tokens_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.ProgressBar tokenBar;
        private System.Windows.Forms.Label bitcoinAddr;
        private System.Windows.Forms.TextBox bitconAddressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button satoshiWithdraw_btn;
    }
}