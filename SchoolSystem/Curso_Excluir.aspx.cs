using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Curso_Excluir : System.Web.UI.Page
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
                Model.Curso curso = mdc.Curso.First(cur => cur.idCurso == int.Parse(tbCodCurso.Text.Trim()));

                mdc.Curso.DeleteOnSubmit(curso);
                mdc.SubmitChanges();

                Response.Redirect("Curso.aspx");

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
                    Model.Curso curso = mdc.Curso.First(cur => cur.idCurso == pGetID);

                    tbCodCurso.Text = pGetID.ToString();
                    tbNome.Text = curso.Nome.Trim();
                    tbDescricao.Text = curso.Descricao.Trim();

                }
                else
                {
                    Response.Redirect("Curso.aspx");
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