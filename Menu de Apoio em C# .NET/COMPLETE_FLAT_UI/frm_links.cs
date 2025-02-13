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
    public partial class frm_links : Form
    {
        public frm_links()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://home.suzano.com.br/");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_sousuzano_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://https://sts.suzano.com.br/adfs/ls/idpinitiatedsignon.aspx?logintoRP=https://www.successfactors.com/C0001105449P/");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_csc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://suzanoprod.service-now.com/csc/");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void portalTi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://suzanoprod.service-now.com/suzano_ti/");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void portalDNA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://sdweb.suzanonet.com.br/dna/login.aspx");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btnRefeicoes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://portais.suzano.com.br/sites/InfraestruturaCorporativa/Lists/Solicitao/NewForm.aspx?Source=http://portais.suzano.com.br/sites/InfraestruturaCorporativa/Lists/Solicitao/AllItems.aspx&RootFolder=/");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_filah_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://dcwvwebp001.suzano.com.br:8088/portaltransportador/login");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_popsuzano_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Atualização POP - Mucuri e Imperatriz";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }
    }
}
