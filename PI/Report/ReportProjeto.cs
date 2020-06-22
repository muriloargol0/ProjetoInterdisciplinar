using Microsoft.Reporting.WinForms;
using PI.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.Report
{
    public partial class ReportProjeto : Form
    {
        public ReportProjeto()
        {
            InitializeComponent();
        }

        public int idProjeto { get; set; }

        private void ReportProjeto_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            using (var ctx = new DBContext())
            {
                var proj = ctx.PROJETO.Where(x => x.ID_PROJETO == 3).FirstOrDefault();

                var itens = (from c in ctx.CIRCUITO_PROJETO
                             join ci in ctx.CIRCUITO on c.ID_CIRCUITO equals ci.ID_CIRCUITO
                             where c.ID_PROJETO == idProjeto
                             select new { c, ci }).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("COD_CIRCUITO", typeof(int));
                dataTable.Columns.Add("DESCRICAO");
                dataTable.Columns.Add("DISJUNTOR", typeof(int));
                dataTable.Columns.Add("FASES", typeof(int));
                dataTable.Columns.Add("FATOR_POTENCIA");

                foreach (var item in itens)
                {
                    dataTable.Rows.Add(item.ci.COD_CIRCUITO.ToString(), item.ci.DESCRICAO, item.ci.DISJUNTOR, item.c.ENTRADA, item.ci.BITOLA_CABO);
                }

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSCircuito", dataTable));

                reportViewer1.LocalReport.SetParameters(new ReportParameter("DescricaoProjeto", proj.DESCRICAO));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("Entradas", proj.ENTRADAS.ToString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("DataImpressao", DateTime.Now.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))));

            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
