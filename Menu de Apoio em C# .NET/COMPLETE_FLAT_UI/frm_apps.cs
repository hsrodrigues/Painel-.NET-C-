using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class frm_apps : Form
    {
        public frm_apps()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frm_convertido hijo = new frm_convertido();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();
           
            hijo.Show();  
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_appinsumos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://apps.powerapps.com/play/867d7e94-dbeb-42cd-b5c3-d2b1d4a0e452?tenantId=a7109315-9727-4adf-97ad-4849bb63edcb");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_appempilhadeira_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://apps.powerapps.com/play/3a8ddf4e-f415-496f-bee9-32f73fb0a741?tenantId=a7109315-9727-4adf-97ad-4849bb63edcb");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_appreclamacoes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://apps.powerapps.com/play/30d081a1-15a6-47e1-b30e-e9aeab6e06b9?tenantId=a7109315-9727-4adf-97ad-4849bb63edcb");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }
    }
}
