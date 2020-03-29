using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisMaker
{
    public partial class Form1 : Form
    {
        BisFile boot0, boot1, bcpkg2_1, bcpkg2_3;

        private void btn_openbcpkg2_1_Click(object sender, EventArgs e)
        {
            DialogResult result = FileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                bcpkg2_1 = new BisFile(ref FileDialog, BisTypes.BCPKG2_1);
                lbl_bcpkg2_1_path.Text = bcpkg2_1.path;
                lbl_bcpkg2_1_size.Text = $"Size: {bcpkg2_1.size}";
            }
        }

        private void btn_openbcpkg2_3_Click(object sender, EventArgs e)
        {
            DialogResult result = FileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                bcpkg2_3 = new BisFile(ref FileDialog, BisTypes.BCPKG2_3);
                lbl_bcpkg2_3_path.Text = bcpkg2_3.path;
                lbl_bcpkg2_3_size.Text = $"Size: {bcpkg2_3.size}";
            }
        }

        private void btn_generate_bis_Click(object sender, EventArgs e)
        {
            btn_generate_bis.Enabled = false;
            lbl_status.Text = "Generating...";
            lbl_status.Refresh();
            try
            {
                Validator.Validate(boot0, BisTypes.BOOT0);
                Validator.Validate(boot1, BisTypes.BOOT1);
                Validator.Validate(bcpkg2_1, BisTypes.BCPKG2_1);
                Validator.Validate(bcpkg2_3, BisTypes.BCPKG2_3);
                Validator.ValidateVersion(tb_embeddedversion.Text);
            }
            catch (Exception f)
            {
                lbl_status.Text = $"Error: {f.Message}";
                btn_generate_bis.Enabled = true;
                return;
            }

            pb_creation.Value = 0;
            Builder builder = new Builder(boot0, boot1, bcpkg2_1, bcpkg2_3);
            builder.Build("./user.bis", tb_embeddedversion.Text, ref pb_creation);
            lbl_status.Text = "Done!";
            btn_generate_bis.Enabled = true;
        }

        private void btn_openboot1_Click(object sender, EventArgs e)
        {
            DialogResult result = FileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                boot1 = new BisFile(ref FileDialog, BisTypes.BOOT1);
                lbl_boot1_path.Text = boot1.path;
                lbl_boot1_size.Text = $"Size: {boot1.size}";
            }
        }

        public Form1()
        {
            InitializeComponent();
            lbl_status.Text = "Ready!";
        }

        private void btn_openboot0_Click(object sender, EventArgs e)
        {
            DialogResult result = FileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                boot0 = new BisFile(ref FileDialog, BisTypes.BOOT0);
                lbl_boot0_path.Text = boot0.path;
                lbl_boot0_size.Text = $"Size: {boot0.size}";
            }
        }
    }
}
