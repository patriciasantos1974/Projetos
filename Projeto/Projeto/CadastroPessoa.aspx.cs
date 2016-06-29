using Bussiness;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["IDPessoa"]!= null)
                {
                    var idpessoa = Convert.ToInt32(Request.QueryString["IDPessoa"]);
                    var PessoaBO = new PessoaBussiness();

                    var pessoa = PessoaBO.SelecionarPessoaPorId(idpessoa);

                    txtNome.Text = pessoa.Nome;
                    ddlSexo.SelectedValue = pessoa.Sexo;
                    txtSalario.Text = pessoa.Salario.ToString();
                    txtDtNascimento.Text = pessoa.DataNascimento.ToString();

                }
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa();

            if (Request.QueryString["IDPessoa"] != null)
            {
                pessoa.IDPessoa = Convert.ToInt32(Request.QueryString["IDPessoa"]);
            }

            pessoa.Nome = txtNome.Text;
            pessoa.Sexo = ddlSexo.SelectedValue;
            pessoa.Salario = Convert.ToDecimal(txtSalario.Text);
            pessoa.DataNascimento = Convert.ToDateTime(txtDtNascimento.Text);

            var PessoaBO = new PessoaBussiness();
            PessoaBO.Salvar(pessoa);

        }
    }
}