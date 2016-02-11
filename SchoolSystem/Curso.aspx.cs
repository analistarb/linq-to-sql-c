using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Curso : System.Web.UI.Page
    {

        private ModelDataContext mdc;


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
                var sourceCurso = from cur in mdc.Curso
                                    select cur;

                switch (pIndex)
                {
                    case 0:
                        {
                            sourceCurso = from cur in mdc.Curso
                                            where cur.idCurso == int.Parse(tbPesqID.Text.Trim())
                                            select cur;

                            break;
                        }
                    case 1:
                        {
                            sourceCurso = from cur in mdc.Curso
                                            where cur.Nome.Contains(tbPesqNome.Text.Trim())
                                            select cur;

                            break;
                        }
                    case 2:
                        {
                            sourceCurso = from cur in mdc.Curso
                                            where cur.Descricao.Contains(tbPesqDescricao.Text.Trim())
                                            select cur;

                            break;
                        }

                }



                gwDados.DataSource = sourceCurso;
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