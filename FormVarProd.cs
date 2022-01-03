using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mc_Donalds
{
    public partial class FormVarProd : Form
    {
        public FormVarProd()
        {
            InitializeComponent();
        }

        private void btnDesayunos_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = true;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;




        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = true;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnPollo_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = true;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnCajita_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = true;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = true;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnEnsaladas_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = true;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = true;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = true;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnLineaSig_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = true;
            pnlMccafeProdu.Visible = false;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblLat_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormVarProd_Load(object sender, EventArgs e)
        {
            
               
        }

        private void lblMcpollo_Click(object sender, EventArgs e)
        {

        }

        private void lblConBacon_Click(object sender, EventArgs e)
        {

        }

        private void lblTostadoNapo_Click(object sender, EventArgs e)
        {

        }

        private void lblBigMac_Click(object sender, EventArgs e)
        {

        }

        private void btnMccafe_Click(object sender, EventArgs e)
        {
            pnlDesayunos.Visible = false;
            pnlHamCarne.Visible = false;
            pnlHamPollo.Visible = false;
            pnlPapasComp.Visible = false;
            pnlBebidas.Visible = false;
            pnlEnsaladas.Visible = false;
            pnlPostres.Visible = false;
            pnlCajiFel.Visible = false;
            pnlLineaSig.Visible = false;
            pnlMccafeProdu.Visible = true;
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;

        }

        private void btnBebidasFrias_Click(object sender, EventArgs e)
        {
            pnlBebidasFrias.Visible = true;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = false;
        }

        private void btnBebidasCalientes_Click(object sender, EventArgs e)
        {
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = true;
            pnlPasteleria.Visible = false;
        }

        private void btnPasteleria_Click(object sender, EventArgs e)
        {
            pnlBebidasFrias.Visible = false;
            pnlBebidasCalientes.Visible = false;
            pnlPasteleria.Visible = true;
        }
    }
}
