using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppLocForWeb
{
    public partial class Escolher_Aluguel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string grid = Convert.ToString(GridView1.DataSource);

            string resultado = GridView1.Rows.Count.ToString();
            lblResultado.Text = resultado;

            if (GridView1.Rows.Count == 0)
            {
                btnEscolherAluguel.Visible = false;
            }
            else
            {
                btnEscolherAluguel.Visible = true;
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtCodigo.Text = GridView1.SelectedRow.Cells[1].Text;
            txtBairro.Text = GridView1.SelectedRow.Cells[2].Text;
            txtTipoImovel.Text = GridView1.SelectedRow.Cells[3].Text;
            txtTipoNegocio.Text = GridView1.SelectedRow.Cells[4].Text;
            txtQuarto.Text = GridView1.SelectedRow.Cells[5].Text;
            //txtSituacao.Text = GridView1.SelectedRow.Cells[6].Text;
            txtValor.Text = GridView1.SelectedRow.Cells[6].Text;
        }

        protected void btnEscolherAluguel_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string bairro = txtBairro.Text;
                string tipo = txtTipoImovel.Text;
                string negocio = txtTipoNegocio.Text;
                string situacao = txtSituacao.Text;
                int quarto = Convert.ToInt32(txtQuarto.Text);
                float valor = Convert.ToUInt32(txtValor.Text);
                string url = null;

                if (codigo == 0)
                {
                    Response.Redirect("Principal.aspx");
                }
                else
                {
                    url = "Detalhes.aspx?codigoImovel=" + codigo + "&nomeBairro=" + bairro + "&tipo=" + tipo + "&negocio=" + negocio + "&situacao=" + situacao + "&quarto=" + quarto + "&valor=" +valor;

                }
                Response.Redirect(url);
            }
            else
            {
                lblMensagem.Text = "Escolha uma opção! ";
            }
        }

        protected void Inicio_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Principal.aspx");

            //decimal ValorTotal = 0;

            //foreach (GridViewRow row in GridView1.Rows)
            //{
            //    if (row.RowType != DataControlRowType.Header && row.RowType != DataControlRowType.Footer)
            //    {
            //        if (row.Cells[7].Text != null && row.Cells[7].Text != string.Empty)
            //        {
            //            ValorTotal += Convert.ToDecimal(row.Cells[7].Text);
            //        }

            //    }
            //}

            //lblMensagem.Text = ValorTotal.ToString("C2");

        }
    }
}