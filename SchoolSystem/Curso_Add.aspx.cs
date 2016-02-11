using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Curso_Add : System.Web.UI.Page
    {
        private ModelDataContext mdc;


        protected void Page_Load(object sender, EventArgs e)
        {
            tbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.onInsert();
        }


        private void onInsert()
        {
            mdc = new ModelDataContext();
            try
            {
                Model.Curso curso = new Model.Curso();
                curso.idAluno = 1;
                curso.idMateria = 1;
                curso.Nome = tbNome.Text.Trim();
                curso.Descricao = tbDescricao.Text.Trim();
                curso.dataCadastro = Convert.ToDateTime(tbDataCadastro.Text.Trim());

                mdc.Curso.InsertOnSubmit(curso);
                mdc.SubmitChanges();

                Response.Redirect("Curso.aspx");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mdc.Dispose();
            }

        }

    }
}