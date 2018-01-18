using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TofasApp
{
    public partial class MainForm : Form
    {
        public static IEnumerable<ComputerValues> computerValues;
        public static ComputerValues computerValue;
        public MainForm()
        {
            InitializeComponent();
            RefreshComputerList();
        }
        private void RefreshComputerList()
        {
            computerValues = Files.ReadFiles();
            computerListComboBox.Items.Clear();
            logsListBox.Items.Clear();
            if (computerValues.Count() > 0)
            {
                computerListComboBox.Items.AddRange(computerValues.ToArray());
                computerListComboBox.SelectedIndex = 0;
                computerListComboBox.Enabled = true;
                saveButton.Enabled = true;
            }
            else
            {
                computerListComboBox.Enabled = false;
                saveButton.Enabled = false;
            }
        }
        private void restartPcButton_Click(object sender, System.EventArgs e)
        {
            var dialogResult = MessageBox.Show(this, "Emin misin?", "Bilgisayar kapatılıyor...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (!Computer.Restart())
                {
                    MessageBox.Show(this, "Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshComputersButton_Click(object sender, System.EventArgs e)
        {
            RefreshComputerList();
        }

        private void computerListComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var comboBox = sender as ComboBox;
            computerValue = comboBox.SelectedItem as ComputerValues;
            computerNameTextBox.Text = computerValue?.ComputerName;
            ipAddressTextBox.Text = computerValue?.IpAddress;
            subnetTextBox.Text = computerValue?.Subnet;
            gatewayTextBox.Text = computerValue?.Gateway;
            networkAdapterTextBox.Text = computerValue?.NetworkAdapter;
            newFolderNameTextBox.Text = computerValue?.NewFolderName;
            oldFolderNameTextBox.Text = computerValue?.OldFolderName;
            folderLocationTextBox.Text = computerValue?.FolderLocation;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (computerValue == null)
            {
                MessageBox.Show(this, "Bilgisayar ayarları seçilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                logsListBox.Items.Add("bilgisayar adı ve IP adresi değiştirme işlemi başladı");
                var success = Computer.RenameAndChangeIpAddress(computerValue);
                if(success)
                {
                    logsListBox.Items.Add("İşlem tamamlandı. Programı yönetici olarak başlatmayı deneyin.");
                }
                else
                {
                    logsListBox.Items.Add("Hata oluştu.");
                    return;
                }
                logsListBox.Items.Add("Dosya işlemleri başladı");
                success = Files.ReadyFiles(computerValue);
                if(success)
                {
                    logsListBox.Items.Add("İşlem tmamlandı. Değişikliklerin geçerli olması için lütfen bilgisayarı yeniden başlatın.");
                }
                else
                {
                    logsListBox.Items.Add("Hata oluştu. Dosya isimlerinin ve konumunun doğru olduğunu kontrol edip tekrar deneyin");
                    return;
                }
                var result = MessageBox.Show(this, "Bilgisayar şimdi yeniden başlatılsın mı?", "Uyarı",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (!Computer.Restart())
                    {
                        MessageBox.Show(this, "Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
