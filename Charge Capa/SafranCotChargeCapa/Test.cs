﻿using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
        public DataSet FlipDataSet(DataSet my_DataSet)
        {
            DataSet ds = new DataSet();


            foreach (System.Data.DataTable dt in my_DataSet.Tables)
            {
                System.Data.DataTable table = new System.Data.DataTable();

                for (int i = 0; i <= dt.Rows.Count; i++)
                { table.Columns.Add(Convert.ToString(i)); }

                DataRow r;
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    r = table.NewRow();
                    r[0] = dt.Columns[k].ToString();
                    for (int j = 1; j <= dt.Rows.Count; j++)
                    { r[j] = dt.Rows[j - 1][k]; }
                    table.Rows.Add(r);
                }
                ds.Tables.Add(table);
            }

            return ds;
        }

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone. Utilisez l'opérateur 'await' pour attendre les appels d'API non bloquants ou 'await Task.Run(…)' pour effectuer un travail utilisant le processeur sur un thread d'arrière-plan.
        private async void button1_Click(object sender, EventArgs e)
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone. Utilisez l'opérateur 'await' pour attendre les appels d'API non bloquants ou 'await Task.Run(…)' pour effectuer un travail utilisant le processeur sur un thread d'arrière-plan.
        {
            OleDbConnection con = new OleDbConnection("	Provider = Microsoft.ACE.OLEDB.12.0; data source = " + sFileName + "; Extended Properties = Excel 12.0; ");
            StringBuilder stbQuery = new StringBuilder();

            stbQuery.Append("SELECT * FROM[Moulage$" + TcInput.Text.ToString() + "]");
            OleDbDataAdapter adpp = new OleDbDataAdapter(stbQuery.ToString(), con);
            DataSet dsXLSi = new DataSet();
            adpp.Fill(dsXLSi);
            DataView dvEmpi = new DataView(dsXLSi.Tables[0]);
            this.dataGridView1.DataSource = dvEmpi;
            List<string> lala = dataGridView1.DataSource as List<string>;
            DemandeDBO.DeletAllOperationTime(2020);
            DemandeDBO.DeletAllOperationTime(2021);
            DemandeDBO.DeletAllOperationTime(2022);
            //DemandeDBO.Restee();

#pragma warning disable CS0168 // La variable 'name' est déclarée, mais jamais utilisée
            string name;
#pragma warning restore CS0168 // La variable 'name' est déclarée, mais jamais utilisée
            for (int j = 1; j < (dataGridView1.RowCount - 1); j++)
            {
                for (int i = 3; i < dataGridView1.ColumnCount; i++)
                {





                    Demande dd = new Demande
                    {
                        YearDem = Convert.ToDateTime(dataGridView1.Columns[i].Name).Year,
                        WeekDem = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Convert.ToDateTime(dataGridView1.Columns[i].Name), CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                        DemandeQTE = int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()),
                        ProductID = dataGridView1.Rows[j].Cells[0].Value.ToString()
                    };

                    //	MessageBox.Show(dd.YearDem.ToString() + "//" + dd.WeekDem.ToString());

                    try
                    {


                        DemandeDBO.AddDemande(dd);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("done");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("	Provider = Microsoft.ACE.OLEDB.12.0; data source = " + sFileName + "; Extended Properties = Excel 12.0; ");
                StringBuilder stbQuery = new StringBuilder();
                stbQuery.Append("SELECT * FROM[F2$A1:C53] ");
                OleDbDataAdapter adpp = new OleDbDataAdapter(stbQuery.ToString(), con);
                DataSet dsXLSi = new DataSet();
                adpp.Fill(dsXLSi);
                DataView dvEmpi = new DataView(dsXLSi.Tables[0]);
                this.dataGridView1.DataSource = dvEmpi;
                List<Calendrier> lala = new List<Calendrier>();
#pragma warning disable CS0168 // La variable 'cl' est déclarée, mais jamais utilisée
                Calendrier cl;
#pragma warning restore CS0168 // La variable 'cl' est déclarée, mais jamais utilisée
                //MessageBox.Show(dataGridView1.Rows[1].Cells[1].Value.ToString());
                CalendrierDBO.DeletAllCall(int.Parse(dataGridView1.Rows[1].Cells[1].Value.ToString()));
                for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
                {

                    Calendrier dd = new Calendrier
                    {
                        WeekT = int.Parse(dataGridView1.Rows[j].Cells[2].Value.ToString()),
                        YearT = int.Parse(dataGridView1.Rows[j].Cells[1].Value.ToString()),
                        OpenDayPerWeek = int.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString()),
                    };

                    CalendrierDBO.SetCal(dd);



                }
                MessageBox.Show("done");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string sFileName;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel Files |*.xls;*.xlsx";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                button1.Enabled = true; button2.Enabled = true;

            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            help1 cc = new help1();
            cc.ShowDialog();
        }
    }

}