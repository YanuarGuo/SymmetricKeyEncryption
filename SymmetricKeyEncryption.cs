using System.Buffers.Text;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using AESLib;
using DESLib;
using TDESLib;

namespace SymmetricKeyEncryption
{
    public partial class SymmetricKeyEncryption : Form
    {
        public string? Key { get; set; }
        public string? IV { get; set; }
        public string? Mode { get; set; }
        public string? KeySize { get; set; }
        public new string? Padding { get; set; }

        private readonly ToolTip toolTip = new();

        public SymmetricKeyEncryption()
        {
            InitializeComponent();
            GbEnc.Enabled = false;
            GbDec.Enabled = false;
            GbConfigs.Enabled = false;
        }

        private void BtnConfirmType_Click(object sender, EventArgs e)
        {
            GbConfigs.Enabled = true;

            if (CbEncType.Text == "DES")
            {
                CbKeySize.Enabled = false;
            }
            else
            {
                CbKeySize.Enabled = true;
            }
            MessageBox.Show("Encryption type confirmed!");
        }

        private void CbEncType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbKeySize.Items.Clear();

            if (CbEncType.SelectedItem == null)
            {
                return;
            }

            switch (CbEncType.SelectedItem.ToString())
            {
                case "DES":
                    break;

                case "TDES":
                    CbKeySize.Items.Add("TDES-112");
                    CbKeySize.Items.Add("TDES-168");
                    CbKeySize.SelectedIndex = 0;
                    break;

                case "AES":
                    CbKeySize.Items.Add("AES-128");
                    CbKeySize.Items.Add("AES-192");
                    CbKeySize.Items.Add("AES-256");
                    CbKeySize.SelectedIndex = 0;
                    break;
            }
        }

        private void BtnConfirmConfigs_Click(object sender, EventArgs e)
        {
            if (CbEncType.Text == "DES")
            {
                if (
                    string.IsNullOrEmpty(TxtKey.Text)
                    || string.IsNullOrEmpty(CbPadding.Text)
                    || string.IsNullOrEmpty(CbMode.Text)
                )
                {
                    MessageBox.Show("Please enter all configurations!");
                    return;
                }
            }
            else
            {
                if (
                    string.IsNullOrEmpty(TxtKey.Text)
                    || string.IsNullOrEmpty(CbPadding.Text)
                    || string.IsNullOrEmpty(CbMode.Text)
                    || string.IsNullOrEmpty(CbKeySize.Text)
                )
                {
                    MessageBox.Show("Please enter all configurations!");
                    return;
                }
            }

            KeySize = CbKeySize.Text;
            Key = TxtKey.Text;
            Padding = CbPadding.Text;
            Mode = CbMode.Text;
            GbEnc.Enabled = true;
            GbDec.Enabled = true;

            if (CbMode.Text == "ECB")
            {
                TxtIVEncHEX.Text = "";
                TxtIVDecHEX.Text = "";
                TxtIVEncString.Text = "";
                TxtIVDecString.Text = "";
                TxtIVEncHEX.Enabled = false;
                TxtIVEncString.Enabled = false;
                TxtIVDecHEX.Enabled = false;
                TxtIVDecString.Enabled = false;
                RbIVDecHEX.Enabled = false;
                RbIVDecString.Enabled = false;
                RbIVEncHEX.Enabled = false;
                RbIVEncString.Enabled = false;
                RbIVDecHEX.Checked = false;
                RbIVDecString.Checked = false;
                RbIVEncHEX.Checked = false;
                RbIVEncString.Checked = false;
            }
            else
            {
                TxtIVEncHEX.Enabled = true;
                TxtIVDecHEX.Enabled = true;
                TxtIVEncString.Enabled = true;
                TxtIVDecString.Enabled = true;
                RbIVDecHEX.Enabled = true;
                RbIVDecString.Enabled = true;
                RbIVEncHEX.Enabled = true;
                RbIVEncString.Enabled = true;
            }
            MessageBox.Show("Configurations saved!");
        }

        private void BtnClearEnc_Click(object sender, EventArgs e)
        {
            TxtPlain.Text = "";
            TxtIVEncHEX.Text = "";
            TxtIVEncString.Text = "";
            CbOutFormat.SelectedIndex = -1;
        }

        private void BtnClearDec_Click(object sender, EventArgs e)
        {
            TxtCipher.Text = "";
            TxtIVDecHEX.Text = "";
            TxtIVDecString.Text = "";
            CbInFormat.SelectedIndex = -1;
        }

        private void CbKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbKeySize.Text == "AES-128")
            {
                TxtKey.Text = "";
                TxtKey.MaxLength = 16;
            }
            else if (CbKeySize.Text == "AES-192")
            {
                TxtKey.Text = "";
                TxtKey.MaxLength = 24;
            }
            else if (CbKeySize.Text == "AES-256")
            {
                TxtKey.Text = "";
                TxtKey.MaxLength = 32;
            }
            else if (CbKeySize.Text == "TDES-112")
            {
                TxtKey.Text = "";
                TxtKey.MaxLength = 16;
            }
            else if (CbKeySize.Text == "TDES-168")
            {
                TxtKey.Text = "";
                TxtKey.MaxLength = 24;
            }
        }

        private void RbIVEncHEX_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVEncString.Clear();
            TxtIVEncString.Enabled = false;
            TxtIVEncHEX.Enabled = true;
        }

        private void RbIVEncString_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVEncHEX.Clear();
            TxtIVEncHEX.Enabled = false;
            TxtIVEncString.Enabled = true;
        }

        private void RbIVDecString_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVDecHEX.Clear();
            TxtIVDecHEX.Enabled = false;
            TxtIVDecString.Enabled = true;
        }

        private void RbIVDecHEX_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVDecString.Clear();
            TxtIVDecString.Enabled = false;
            TxtIVDecHEX.Enabled = true;
        }

        private void CheckHash_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(
                (Control)sender,
                "Enable key hashing to match the selected key size. Click to apply."
            );
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            IV = RbIVEncHEX.Checked ? TxtIVEncHEX.Text : TxtIVEncString.Text;
            string encryptedText = string.Empty;

            if (CbEncType.Text == "DES")
            {
                if (
                    string.IsNullOrEmpty(Key)
                    || string.IsNullOrEmpty(Padding)
                    || string.IsNullOrEmpty(Mode)
                )
                {
                    MessageBox.Show("Key / Padding / Mode cannot be null or empty!");
                    return;
                }
            }
            else if (CbEncType.Text == "TDES")
            {
                if (
                    string.IsNullOrEmpty(Key)
                    || string.IsNullOrEmpty(Padding)
                    || string.IsNullOrEmpty(Mode)
                    || string.IsNullOrEmpty(KeySize)
                )
                {
                    MessageBox.Show("Key / Padding / Mode / Key Size cannot be null or empty!");
                    return;
                }
            }
            else if (CbEncType.Text == "AES")
            {
                if (
                    string.IsNullOrEmpty(Key)
                    || string.IsNullOrEmpty(Padding)
                    || string.IsNullOrEmpty(Mode)
                    || string.IsNullOrEmpty(KeySize)
                )
                {
                    MessageBox.Show("Key / Padding / Mode / Key Size cannot be null or empty!");
                    return;
                }
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            IV = RbIVDecHEX.Checked ? TxtIVDecHEX.Text : TxtIVDecString.Text;

            if (CbEncType.Text == "DES")
            {
                if (
                    string.IsNullOrEmpty(Key)
                    || string.IsNullOrEmpty(Padding)
                    || string.IsNullOrEmpty(Mode)
                )
                {
                    MessageBox.Show("Key / Padding / Mode cannot be null or empty!");
                    return;
                }
            }
            else if (CbEncType.Text == "TDES")
            {
                if (
                    string.IsNullOrEmpty(Key)
                    || string.IsNullOrEmpty(Padding)
                    || string.IsNullOrEmpty(Mode)
                    || string.IsNullOrEmpty(KeySize)
                )
                {
                    MessageBox.Show("Key / Padding / Mode / Key Size cannot be null or empty!");
                    return;
                }
            }
            else if (CbEncType.Text == "AES")
            {
                if (
                    string.IsNullOrEmpty(Key)
                    || string.IsNullOrEmpty(Padding)
                    || string.IsNullOrEmpty(Mode)
                    || string.IsNullOrEmpty(KeySize)
                )
                {
                    MessageBox.Show("Key / Padding / Mode / Key Size cannot be null or empty!");
                    return;
                }
            }
        }
    }
}
