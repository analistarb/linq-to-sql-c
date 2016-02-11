using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Materias_Excluir : System.Web.UI.Page
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


        protected void btnExcluir_Click(object obj, EventArgs e)
        {
            this.onDelete();
        }


        private void onDelete()
        {
            mdc = new ModelDataContext();
            try
            {

                //select * from materia where idMateria = pGetID
                Materia materia = mdc.Materia.First(mat => mat.idMateria == int.Parse(tbCodigo.Text.Trim()));

                mdc.Materia.DeleteOnSubmit(materia);
                mdc.SubmitChanges();

                Response.Redirect("Materias.aspx");

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
                    //select * from materia where idMateria = pGetID
                    Materia materia = mdc.Materia.First(mat => mat.idMateria == pGetID);

                    tbCodigo.Text = pGetID.ToString();
                    tbNome.Text = materia.Nome.Trim();
                    tbDescricao.Text = materia.Descricao.Trim();

                }
                else
                {
                    Response.Redirect("Materias.aspx");
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