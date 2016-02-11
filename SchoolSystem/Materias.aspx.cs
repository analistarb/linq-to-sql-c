using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

 
namespace SchoolSystem
{
    public partial class Default : System.Web.UI.Page
    {

        private ModelDataContext mdc;

        //postback é toda ida no servidor, ele gera um postback
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.populateGrid();
            }


        }

        private void populateGrid(int pIndex = -1)
        {
            mdc = new ModelDataContext();

            try
            {
                var sourceMateria = from mat in mdc.Materia
                                    select mat;

                switch (pIndex)
                {
                    case 0:
                        {
                            sourceMateria = from mat in mdc.Materia
                                            where mat.idMateria == int.Parse(tbPesqID.Text.Trim())
                                            select mat;

                            break;
                        }
                    case 1:
                        {
                            sourceMateria = from mat in mdc.Materia
                                            where mat.Nome.Contains(tbPesqNome.Text.Trim())
                                            select mat;

                            break;
                        }
                    case 2:
                        {
                            sourceMateria = from mat in mdc.Materia
                                            where mat.Descricao.Contains(tbPesqDescricao.Text.Trim())
                                            select mat;

                            break;
                        }
                    
                }



                gwDados.DataSource = sourceMateria;
                gwDados.DataBind();
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.populateGrid(rlbTypeSearch.SelectedIndex);
        }

        protected void btnLimpaPesq_Click(object sender, EventArgs e)
        {
            this.populateGrid();
            tbPesqID.Text = "";
            tbPesqNome.Text = "";
            tbPesqDescricao.Text = "";
        }
       


    }
}