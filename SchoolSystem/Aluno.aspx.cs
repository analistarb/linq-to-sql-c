using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Aluno : System.Web.UI.Page
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
                var sourceMateria = from aluno in mdc.Aluno
                                    select aluno;

                switch (pIndex)
                {
                    case 0:
                        {
                            sourceMateria = from aluno in mdc.Aluno
                                            where aluno.idAluno == int.Parse(tbPesqID.Text.Trim())
                                            select aluno;

                            break;
                        }
                    case 1:
                        {
                            sourceMateria = from aluno in mdc.Aluno
                                            where aluno.Nome.Contains(tbPesqNome.Text.Trim())
                                            select aluno;

                            break;
                        }
                    case 2:
                        {
                            sourceMateria = from aluno in mdc.Aluno
                                            where aluno.Endereco.Contains(tbEndereco.Text.Trim())
                                            select aluno;

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
            tbEndereco.Text = "";
        }
    }
}