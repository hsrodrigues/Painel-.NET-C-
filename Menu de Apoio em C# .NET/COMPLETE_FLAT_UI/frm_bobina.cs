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
    public partial class frm_bobina : Form
    {
        public frm_bobina()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_relatorioturno_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\Suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Relatório de Turno - Bobina.xlsx";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\INVENTARIO DIARIO TISSUE BOBINAS\";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_refugo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Refugo Tissue\";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_etiqueta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\BOBINA\Etiqueta de Lote - Bobina";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_optivision_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://industrialweb.suzano.com.br/PortalRelatorios/Sismenu.aspx");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_laudo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://webcls.suzano.com.br/laudoqualidade/Login");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_re_etiqueta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"http://optivisiontissueprd.suzano.com.br/optiwebmenu/");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_particularidade_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Particularidades Clientes Tissue\Particularidades dos Clientes Tissue.xlsm";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }
    }
}
