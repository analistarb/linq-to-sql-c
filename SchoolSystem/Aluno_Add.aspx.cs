using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;


namespace SchoolSystem
{
    public partial class Aluno_Add : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            tbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }



        private void onInsert()
        {

            try
            {
                using (ModelDataContext mdc = new ModelDataContext())
                {
                    Model.Aluno aluno = new Model.Aluno()
                    {
                        Nome = tbNome.Text.Trim(),
                        Endereco = tbEndereco.Text.Trim(),
                        Cep = tbCEP.Text.Trim(),
                        Telefone = tbTelefone.Text.Trim(),
                        Celular = tbCelular.Text.Trim(),
                        dataNascimento = DateTime.Parse(tbDataNasc.Text.Trim()),
                        dataCadastro = DateTime.Parse(DateTime.Now.ToShortDateString())
                    };

                mdc.Aluno.InsertOnSubmit(aluno);
                mdc.SubmitChanges();

                Response.Redirect("Aluno.aspx");

                }
            }
            catch (Exception)
            {
                throw;
            }



        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            onInsert();
        }

    }
}