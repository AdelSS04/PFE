﻿using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
    public partial class ManageMachine : Form // MetroFramework.Forms.MetroForm
    {
        public ManageMachine()
        {
            InitializeComponent();
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {


        }
        public void sizeDGV(DataGridView dgv, GroupBox GRP)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            //dgv.ScrollBars = ScrollBars.None;

            var totalWidth = dgv.Columns.GetColumnsWidth(states);
            dgv.ClientSize = new Size(totalWidth, 180);
            GRP.ClientSize = new Size(totalWidth + 2, 180);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;

                }
                else
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

        }
        private void ManageMachine_Load(object sender, EventArgs e)
        {
            DataPick.Items.Add(DateTime.Now.Year);
            DataPick.Items.Add((DateTime.Now.Year + 1));
            DataPick.Items.Add((DateTime.Now.Year + 2));
            List<Machine> machines = MachineDBO.GetAllMachine();
            dataGridView1.DataSource = machines;
            foreach (Machine u in machines)
            { metroComboBox1.Items.Add(u.MachineID); }
            sizeDGV(dataGridView1, groupBox1);
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Columns[0].ReadOnly = true;
                Machine machine = MachineDBO.GetMachine(metroComboBox1.SelectedItem.ToString());
                List<Machine> LMachine = new List<Machine>();
                LMachine.Add(machine);
                dataGridView1.DataSource = LMachine;
                List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), DateTime.Now.Year);
                dataGridView2.DataSource = CapaMach;
                dataGridView2.Columns[0].ReadOnly = true;
                dataGridView2.Columns[1].ReadOnly = true;
                dataGridView2.Columns[2].ReadOnly = true;
                sizeDGV(dataGridView2, groupBox2);
                UpButton.Enabled = true;
                DelButton.Enabled = true;
                UpGrid.Enabled = true;
                UpAll.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<MachineOpenDay> machineOpenDays = new List<MachineOpenDay>();
                machineOpenDays = dataGridView2.DataSource as List<MachineOpenDay>;
                bool state = true;
                foreach (MachineOpenDay openDay in machineOpenDays)
                {
                    if (!MachineDBO.UpdateMachineOpenDay(openDay))
                        state = false;
                }
                if (state)
                {
                    MessageBox.Show("done");
                    List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), DateTime.Now.Year);
                    dataGridView2.DataSource = CapaMach;
                    sizeDGV(dataGridView2, groupBox2);
                }
                else
                    MessageBox.Show("error");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MachineOpenDay openDay = new MachineOpenDay
                {
                    MachineID = metroComboBox1.SelectedItem.ToString(),
                    YearT = int.Parse(DataPick.SelectedItem.ToString()),
                    WeekT = int.Parse(WeekT.Text),
                    NumberOfshift = int.Parse(NumberOfshift.Text),
                    OpenDay = int.Parse(openday.Text),
                };
#pragma warning disable CS0219 // La variable 'state' est assignée, mais sa valeur n'est jamais utilisée
                bool state = true;
#pragma warning restore CS0219 // La variable 'state' est assignée, mais sa valeur n'est jamais utilisée

                if (MachineDBO.UpdateAllMachineOpenDay(openDay))
                {
                    MessageBox.Show("done");
                    List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), DateTime.Now.Year);
                    dataGridView2.DataSource = CapaMach;
                    sizeDGV(dataGridView2, groupBox2);

                }
                else
                {
                    DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                    DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
                    Calendar cal = dfi.Calendar;
                    for (int i = 1; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
                    {
                        openDay.WeekT = i;
                        MachineDBO.SetOpenDay(openDay);
                    }
                    MessageBox.Show("Add done");
                    List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), DateTime.Now.Year);
                    dataGridView2.DataSource = CapaMach;
                    sizeDGV(dataGridView2, groupBox2);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Machine> machines = new List<Machine>();
                machines = dataGridView1.DataSource as List<Machine>;

                if (MachineDBO.UpdateMchine(machines[0]))
                    MessageBox.Show("Update !!");
                else
                    MessageBox.Show("No Update !!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MachineDBO.DeletMachine(metroComboBox1.SelectedItem.ToString()))
                {
                    MessageBox.Show("done");
                    List<Machine> machines = MachineDBO.GetAllMachine();
                    dataGridView1.DataSource = machines;
                    metroComboBox1.Items.Clear();
                    foreach (Machine u in machines)
                    { metroComboBox1.Items.Add(u.MachineID); }
                    dataGridView2.DataSource = null;


                    UpButton.Enabled = false;
                    DelButton.Enabled = false;
                    UpGrid.Enabled = false;
                    UpAll.Enabled = false;
                }
                else
                { MessageBox.Show("non"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
