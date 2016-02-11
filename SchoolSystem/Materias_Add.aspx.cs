using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Materias_Add : System.Web.UI.Page
    {
        private ModelDataContext mdc;


        protected void Page_Load(object sender, EventArgs e)
        {
            tbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }


        protected void btnCadastrar_Click(object obj, EventArgs e)
        {
            this.onInsert();
        }

        private void onInsert()
        {
            mdc = new ModelDataContext();
            try
            {
                Materia materia = new Materia();

                materia.Nome = tbNome.Text.Trim();
                materia.Descricao = tbDescricao.Text.Trim();
                materia.dataCadastro = Convert.ToDateTime(tbDataCadastro.Text.Trim());
                
                mdc.Materia.InsertOnSubmit(materia);
                mdc.SubmitChanges();

                Response.Redirect("Materias.aspx");

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