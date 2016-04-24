﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppLocForWeb
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string nomeBairro = Convert.ToString(DropDownList1.SelectedItem);
            string nomeTipoImovel = Convert.ToString(DropDownList2.SelectedItem);
            string quantidadeQuarto = Convert.ToString(DropDownList4.SelectedItem);
            string url = null;


            if (nomeBairro == "")
            {
                //Response.Redirect("Principal.aspx");
                url = "Escolher_Aluguel.aspx?nomeBairro=" + nomeBairro + "&nomeTipoImovel=" + nomeTipoImovel + "&quantidadeQuarto=" + quantidadeQuarto;
            }
            else
            {
                url = "Escolher_Aluguel.aspx?nomeBairro=" + nomeBairro + "&nomeTipoImovel=" + nomeTipoImovel + "&quantidadeQuarto=" + quantidadeQuarto;

            }
            Response.Redirect(url);
        }
    }
}