using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Aluno_Excluir : System.Web.UI.Page
    {
        private ModelDataContext mdc;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                try
                {
                    this.populateFields(int.Parse(Request.QueryString["id"]));
                }
                catch (Exception)
                {

                    this.populateFields();
                }
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            this.onDelete();
        }


        private void onDelete()
        {
            mdc = new ModelDataContext();
            try
            {

                Model.Aluno aluno = mdc.Aluno.First(alun => alun.idAluno == int.Parse(tbCodAluno.Text.Trim()));

                mdc.Aluno.DeleteOnSubmit(aluno);
                mdc.SubmitChanges();

                Response.Redirect("Aluno.aspx");

            }
            catch (Exception)
            {


            }
            finally
            {
                mdc.Dispose();
            }
        }







        private void populateFields(int pGetID = 0)
        {

            mdc = new ModelDataContext();
            try
            {
                if (pGetID > 0)
                {
                    Model.Aluno aluno = mdc.Aluno.First(alun => alun.idAluno == pGetID);

                    tbCodAluno.Text = pGetID.ToString();
                    tbNome.Text = aluno.Nome.Trim();
                    tbEndereco.Text = aluno.Endereco.Trim();


                    tbCEP.Text = aluno.Cep.Trim();
                    tbTelefone.Text = aluno.Telefone.Trim();
                    tbCelular.Text = aluno.Celular.Trim();

                    tbDataNasc.Text = DateTime.Parse(aluno.dataNascimento.ToString()).ToShortDateString();
                    tbDataCadastro.Text = DateTime.Parse(aluno.dataCadastro.ToString()).ToShortDateString();
                }
                else
                {
                    Response.Redirect("Aluno.aspx");
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                mdc.Dispose();
            }





        }


    }
}