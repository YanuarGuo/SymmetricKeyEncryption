namespace SymmetricKeyEncryption
{
    partial class SymmetricKeyEncryption
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
            GbConfigs = new GroupBox();
            BtnConfirmConfigs = new Button();
            label5 = new Label();
            CbMode = new ComboBox();
            label4 = new Label();
            CbPadding = new ComboBox();
            CheckHash = new CheckBox();
            TxtKey = new TextBox();
            label3 = new Label();
            label2 = new Label();
            CbKeySize = new ComboBox();
            label1 = new Label();
            CbEncType = new ComboBox();
            GbEnc = new GroupBox();
            BtnEncrypt = new Button();
            BtnClearEnc = new Button();
            label10 = new Label();
            CbOutFormat = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            TxtIVEncString = new TextBox();
            RbIVEncString = new RadioButton();
            TxtIVEncHEX = new TextBox();
            label7 = new Label();
            RbIVEncHEX = new RadioButton();
            label6 = new Label();
            TxtPlain = new TextBox();
            GbDec = new GroupBox();
            BtnDecrypt = new Button();
            BtnClearDec = new Button();
            label11 = new Label();
            CbInFormat = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            TxtIVDecString = new TextBox();
            RbIVDecString = new RadioButton();
            TxtIVDecHEX = new TextBox();
            label14 = new Label();
            RbIVDecHEX = new RadioButton();
            label15 = new Label();
            TxtCipher = new TextBox();
            BtnConfirmType = new Button();
            GbConfigs.SuspendLayout();
            GbEnc.SuspendLayout();
            GbDec.SuspendLayout();
            SuspendLayout();
            // 
            // GbConfigs
            // 
            GbConfigs.Controls.Add(BtnConfirmConfigs);
            GbConfigs.Controls.Add(label5);
            GbConfigs.Controls.Add(CbMode);
            GbConfigs.Controls.Add(label4);
            GbConfigs.Controls.Add(CbPadding);
            GbConfigs.Controls.Add(CheckHash);
            GbConfigs.Controls.Add(TxtKey);
            GbConfigs.Controls.Add(label3);
            GbConfigs.Controls.Add(label2);
            GbConfigs.Controls.Add(CbKeySize);
            GbConfigs.Location = new Point(12, 60);
            GbConfigs.Name = "GbConfigs";
            GbConfigs.Size = new Size(492, 225);
            GbConfigs.TabIndex = 0;
            GbConfigs.TabStop = false;
            GbConfigs.Text = "Encryption Configurations";
            // 
            // BtnConfirmConfigs
            // 
            BtnConfirmConfigs.Location = new Point(370, 183);
            BtnConfirmConfigs.Name = "BtnConfirmConfigs";
            BtnConfirmConfigs.Size = new Size(105, 23);
            BtnConfirmConfigs.TabIndex = 21;
            BtnConfirmConfigs.Text = "Confirm";
            BtnConfirmConfigs.UseVisualStyleBackColor = true;
            BtnConfirmConfigs.Click += BtnConfirmConfigs_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 125);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 11;
            label5.Text = "Cipher Mode";
            // 
            // CbMode
            // 
            CbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMode.FormattingEnabled = true;
            CbMode.Items.AddRange(new object[] { "CBC", "ECB" });
            CbMode.Location = new Point(250, 143);
            CbMode.Name = "CbMode";
            CbMode.Size = new Size(223, 23);
            CbMode.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Padding";
            // 
            // CbPadding
            // 
            CbPadding.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPadding.FormattingEnabled = true;
            CbPadding.Items.AddRange(new object[] { "PKCS7", "ZeroPadding" });
            CbPadding.Location = new Point(19, 143);
            CbPadding.Name = "CbPadding";
            CbPadding.Size = new Size(223, 23);
            CbPadding.TabIndex = 8;
            // 
            // CheckHash
            // 
            CheckHash.AutoSize = true;
            CheckHash.Location = new Point(361, 95);
            CheckHash.Name = "CheckHash";
            CheckHash.Size = new Size(119, 19);
            CheckHash.TabIndex = 7;
            CheckHash.Text = "Use Key Hashing*";
            CheckHash.UseVisualStyleBackColor = true;
            CheckHash.MouseEnter += CheckHash_MouseEnter;
            // 
            // TxtKey
            // 
            TxtKey.Location = new Point(74, 66);
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new Size(401, 23);
            TxtKey.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 69);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 5;
            label3.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 29);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Key Size";
            // 
            // CbKeySize
            // 
            CbKeySize.DropDownStyle = ComboBoxStyle.DropDownList;
            CbKeySize.FormattingEnabled = true;
            CbKeySize.Location = new Point(74, 26);
            CbKeySize.Name = "CbKeySize";
            CbKeySize.Size = new Size(401, 23);
            CbKeySize.TabIndex = 3;
            CbKeySize.SelectedIndexChanged += CbKeySize_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Encryption Type";
            // 
            // CbEncType
            // 
            CbEncType.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEncType.FormattingEnabled = true;
            CbEncType.Items.AddRange(new object[] { "DES", "TDES", "AES" });
            CbEncType.Location = new Point(109, 20);
            CbEncType.Name = "CbEncType";
            CbEncType.Size = new Size(273, 23);
            CbEncType.TabIndex = 2;
            CbEncType.SelectedIndexChanged += CbEncType_SelectedIndexChanged;
            // 
            // GbEnc
            // 
            GbEnc.Controls.Add(BtnEncrypt);
            GbEnc.Controls.Add(BtnClearEnc);
            GbEnc.Controls.Add(label10);
            GbEnc.Controls.Add(CbOutFormat);
            GbEnc.Controls.Add(label9);
            GbEnc.Controls.Add(label8);
            GbEnc.Controls.Add(TxtIVEncString);
            GbEnc.Controls.Add(RbIVEncString);
            GbEnc.Controls.Add(TxtIVEncHEX);
            GbEnc.Controls.Add(label7);
            GbEnc.Controls.Add(RbIVEncHEX);
            GbEnc.Controls.Add(label6);
            GbEnc.Controls.Add(TxtPlain);
            GbEnc.Location = new Point(12, 301);
            GbEnc.Name = "GbEnc";
            GbEnc.Size = new Size(242, 396);
            GbEnc.TabIndex = 1;
            GbEnc.TabStop = false;
            GbEnc.Text = "Encryption";
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(125, 356);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(105, 23);
            BtnEncrypt.TabIndex = 21;
            BtnEncrypt.Text = "Encrypt";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnClearEnc
            // 
            BtnClearEnc.Location = new Point(13, 356);
            BtnClearEnc.Name = "BtnClearEnc";
            BtnClearEnc.Size = new Size(105, 23);
            BtnClearEnc.TabIndex = 20;
            BtnClearEnc.Text = "Clear";
            BtnClearEnc.UseVisualStyleBackColor = true;
            BtnClearEnc.Click += BtnClearEnc_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 290);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 19;
            label10.Text = "Output Format";
            // 
            // CbOutFormat
            // 
            CbOutFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbOutFormat.FormattingEnabled = true;
            CbOutFormat.Items.AddRange(new object[] { "HEX", "Base64" });
            CbOutFormat.Location = new Point(13, 308);
            CbOutFormat.Name = "CbOutFormat";
            CbOutFormat.Size = new Size(217, 23);
            CbOutFormat.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(157, 197);
            label9.Name = "label9";
            label9.Size = new Size(73, 13);
            label9.TabIndex = 17;
            label9.Text = "HEX (32 Chars)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(147, 240);
            label8.Name = "label8";
            label8.Size = new Size(83, 13);
            label8.TabIndex = 16;
            label8.Text = "String (16 Chars)";
            // 
            // TxtIVEncString
            // 
            TxtIVEncString.Location = new Point(33, 253);
            TxtIVEncString.Name = "TxtIVEncString";
            TxtIVEncString.Size = new Size(197, 23);
            TxtIVEncString.TabIndex = 15;
            // 
            // RbIVEncString
            // 
            RbIVEncString.AutoSize = true;
            RbIVEncString.Location = new Point(13, 257);
            RbIVEncString.Name = "RbIVEncString";
            RbIVEncString.Size = new Size(14, 13);
            RbIVEncString.TabIndex = 14;
            RbIVEncString.TabStop = true;
            RbIVEncString.UseVisualStyleBackColor = true;
            RbIVEncString.CheckedChanged += RbIVEncString_CheckedChanged;
            // 
            // TxtIVEncHEX
            // 
            TxtIVEncHEX.Location = new Point(33, 210);
            TxtIVEncHEX.Name = "TxtIVEncHEX";
            TxtIVEncHEX.Size = new Size(197, 23);
            TxtIVEncHEX.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 176);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 12;
            label7.Text = "Initialization Vector";
            // 
            // RbIVEncHEX
            // 
            RbIVEncHEX.AutoSize = true;
            RbIVEncHEX.Location = new Point(13, 214);
            RbIVEncHEX.Name = "RbIVEncHEX";
            RbIVEncHEX.Size = new Size(14, 13);
            RbIVEncHEX.TabIndex = 11;
            RbIVEncHEX.TabStop = true;
            RbIVEncHEX.UseVisualStyleBackColor = true;
            RbIVEncHEX.CheckedChanged += RbIVEncHEX_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 32);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Plain Text";
            // 
            // TxtPlain
            // 
            TxtPlain.Location = new Point(13, 50);
            TxtPlain.Multiline = true;
            TxtPlain.Name = "TxtPlain";
            TxtPlain.Size = new Size(217, 113);
            TxtPlain.TabIndex = 3;
            // 
            // GbDec
            // 
            GbDec.Controls.Add(BtnDecrypt);
            GbDec.Controls.Add(BtnClearDec);
            GbDec.Controls.Add(label11);
            GbDec.Controls.Add(CbInFormat);
            GbDec.Controls.Add(label12);
            GbDec.Controls.Add(label13);
            GbDec.Controls.Add(TxtIVDecString);
            GbDec.Controls.Add(RbIVDecString);
            GbDec.Controls.Add(TxtIVDecHEX);
            GbDec.Controls.Add(label14);
            GbDec.Controls.Add(RbIVDecHEX);
            GbDec.Controls.Add(label15);
            GbDec.Controls.Add(TxtCipher);
            GbDec.Location = new Point(262, 301);
            GbDec.Name = "GbDec";
            GbDec.Size = new Size(242, 396);
            GbDec.TabIndex = 22;
            GbDec.TabStop = false;
            GbDec.Text = "Decryption";
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(125, 356);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(105, 23);
            BtnDecrypt.TabIndex = 21;
            BtnDecrypt.Text = "Decrypt";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // BtnClearDec
            // 
            BtnClearDec.Location = new Point(13, 356);
            BtnClearDec.Name = "BtnClearDec";
            BtnClearDec.Size = new Size(105, 23);
            BtnClearDec.TabIndex = 20;
            BtnClearDec.Text = "Clear";
            BtnClearDec.UseVisualStyleBackColor = true;
            BtnClearDec.Click += BtnClearDec_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 290);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 19;
            label11.Text = "Input Format";
            // 
            // CbInFormat
            // 
            CbInFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbInFormat.FormattingEnabled = true;
            CbInFormat.Items.AddRange(new object[] { "HEX", "Base64" });
            CbInFormat.Location = new Point(13, 308);
            CbInFormat.Name = "CbInFormat";
            CbInFormat.Size = new Size(217, 23);
            CbInFormat.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(157, 197);
            label12.Name = "label12";
            label12.Size = new Size(73, 13);
            label12.TabIndex = 17;
            label12.Text = "HEX (32 Chars)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(147, 240);
            label13.Name = "label13";
            label13.Size = new Size(83, 13);
            label13.TabIndex = 16;
            label13.Text = "String (16 Chars)";
            // 
            // TxtIVDecString
            // 
            TxtIVDecString.Location = new Point(33, 253);
            TxtIVDecString.Name = "TxtIVDecString";
            TxtIVDecString.Size = new Size(197, 23);
            TxtIVDecString.TabIndex = 15;
            // 
            // RbIVDecString
            // 
            RbIVDecString.AutoSize = true;
            RbIVDecString.Location = new Point(13, 257);
            RbIVDecString.Name = "RbIVDecString";
            RbIVDecString.Size = new Size(14, 13);
            RbIVDecString.TabIndex = 14;
            RbIVDecString.TabStop = true;
            RbIVDecString.UseVisualStyleBackColor = true;
            RbIVDecString.CheckedChanged += RbIVDecString_CheckedChanged;
            // 
            // TxtIVDecHEX
            // 
            TxtIVDecHEX.Location = new Point(33, 210);
            TxtIVDecHEX.Name = "TxtIVDecHEX";
            TxtIVDecHEX.Size = new Size(197, 23);
            TxtIVDecHEX.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 176);
            label14.Name = "label14";
            label14.Size = new Size(107, 15);
            label14.TabIndex = 12;
            label14.Text = "Initialization Vector";
            // 
            // RbIVDecHEX
            // 
            RbIVDecHEX.AutoSize = true;
            RbIVDecHEX.Location = new Point(13, 214);
            RbIVDecHEX.Name = "RbIVDecHEX";
            RbIVDecHEX.Size = new Size(14, 13);
            RbIVDecHEX.TabIndex = 11;
            RbIVDecHEX.TabStop = true;
            RbIVDecHEX.UseVisualStyleBackColor = true;
            RbIVDecHEX.CheckedChanged += RbIVDecHEX_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 32);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 10;
            label15.Text = "Cipher Text";
            // 
            // TxtCipher
            // 
            TxtCipher.Location = new Point(13, 50);
            TxtCipher.Multiline = true;
            TxtCipher.Name = "TxtCipher";
            TxtCipher.Size = new Size(217, 113);
            TxtCipher.TabIndex = 3;
            // 
            // BtnConfirmType
            // 
            BtnConfirmType.Location = new Point(399, 20);
            BtnConfirmType.Name = "BtnConfirmType";
            BtnConfirmType.Size = new Size(105, 23);
            BtnConfirmType.TabIndex = 22;
            BtnConfirmType.Text = "Confirm";
            BtnConfirmType.UseVisualStyleBackColor = true;
            BtnConfirmType.Click += BtnConfirmType_Click;
            // 
            // SymmetricKeyEncryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 709);
            Controls.Add(BtnConfirmType);
            Controls.Add(GbDec);
            Controls.Add(GbEnc);
            Controls.Add(CbEncType);
            Controls.Add(label1);
            Controls.Add(GbConfigs);
            Name = "SymmetricKeyEncryption";
            Text = "SymmetricKeyEncryption";
            GbConfigs.ResumeLayout(false);
            GbConfigs.PerformLayout();
            GbEnc.ResumeLayout(false);
            GbEnc.PerformLayout();
            GbDec.ResumeLayout(false);
            GbDec.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GbConfigs;
        private Label label1;
        private ComboBox CbEncType;
        private GroupBox GbEnc;
        private Label label2;
        private ComboBox CbKeySize;
        private Label label5;
        private ComboBox CbMode;
        private Label label4;
        private ComboBox CbPadding;
        private CheckBox CheckHash;
        private TextBox TxtKey;
        private Label label3;
        private Label label6;
        private TextBox TxtPlain;
        private RadioButton RbIVEncHEX;
        private Label label8;
        private TextBox TxtIVEncString;
        private RadioButton RbIVEncString;
        private TextBox TxtIVEncHEX;
        private Label label7;
        private Button BtnEncrypt;
        private Button BtnClearEnc;
        private Label label10;
        private ComboBox CbOutFormat;
        private Label label9;
        private GroupBox GbDec;
        private Button BtnDecrypt;
        private Button BtnClearDec;
        private Label label11;
        private ComboBox CbInFormat;
        private Label label12;
        private Label label13;
        private TextBox TxtIVDecString;
        private RadioButton RbIVDecString;
        private TextBox TxtIVDecHEX;
        private Label label14;
        private RadioButton RbIVDecHEX;
        private Label label15;
        private TextBox TxtCipher;
        private Button BtnConfirmConfigs;
        private Button BtnConfirmType;
    }
}
