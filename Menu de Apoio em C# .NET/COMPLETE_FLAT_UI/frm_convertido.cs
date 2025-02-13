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
    public partial class frm_convertido : Form
    {
        public frm_convertido()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void InsertarFilas()
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_apps frm = Owner as frm_apps;
            //FormMembresia frm = new FormMembresia();

          
            this.Close();
        }

        private void btn_relatorioturno_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Relatório de Turno - Fardos.XLSX";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://suzano-my.sharepoint.com/:x:/r/personal/hudson_sr_suzano_com_br/Documents/NOVO%20-%20Invent%C3%A1rio%20Fardos%20Tissue/Inventario%20Fardos%20Tissue.xlsm?d=wf62387fc8ce74fc8bd911861a29390f5&csf=1&web=1&e=oJN2Ff");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_inventInsumos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\DFSSuzano\DELIN\Equipe Tissue\Insumos Tissue\Insumos Tissue.xlsm";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_plancubagem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\CÁLCULO DE CUBAGEM CARREGAMENTO";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://www.barcode-generator.de/V2/pt/index.jsp");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btnPrensados_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\CONTROLE DE ESTOCAGEM DE FARDOS PRENSADOS";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_contigencia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Indisponibilidade SAP - Controle Contingência";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_devolucao_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\DEVOLUÇÕES";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_planTransfer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\TRANSFERENCIA";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_planCarregamento_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\PLANILHA DE CARREGAMENTO";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_romaneio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\ROMANEIOS DE INSUMOS SALVOS";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Indicadores de horas";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void btn_relTurnoSancol_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\SANCOL\Relatório Turno Sancol";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;

        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\HISTÓRICO EMAIL'S INVENTÁRIO FARDOS";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Indicador Materiais Estocados\Dash e Planilha tempo de estoque";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Registro de erros de carregamento";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "chrome.exe";
            proc.StartInfo.Arguments = (@"https://suzano-my.sharepoint.com/:x:/r/personal/hudson_sr_suzano_com_br/Documents/Informa%C3%A7%C3%B5es%20Complementares%20Invent%C3%A1rio%20Tissue.xlsm?d=wc5d620698de64a55b7e425d842090222&csf=1&web=1&e=Xr6e8h");
            proc.Start();
            proc.Dispose();
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"\\suzano.com.br\dfssuzano\DELIN\Equipe Tissue\Planilha Inspeção palete e bobinas";
            System.Diagnostics.Process.Start(startInfo);
            FormMenuPrincipal fp = new FormMenuPrincipal();
            fp.WindowState = FormWindowState.Minimized;
        }
    }
}
