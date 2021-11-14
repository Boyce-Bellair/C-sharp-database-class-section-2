﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_database_class_section_2
{
    public partial class frmDataEntry : Form
    {
        
        TimeSpan elapsedTime;
        DateTime lastElapsed;

        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void frmDataEntry_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //txtName.Text = sender.ToString();
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtName.Focus();
        }

        private void timTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastElapsed;
            lastElapsed = DateTime.Now;

            txtTimer.Text = Convert.ToString(new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            timTimer.Enabled = true;
            grbDataEntry.Enabled = true;
            txtName.Focus();
            lastElapsed = DateTime.Now;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            grbDataEntry.Enabled = false;
            timTimer.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string dataEntry;

            if (txtName.Text.Equals("") || txtAddress.Text.Equals("") ||
                txtCity.Text.Equals("") || txtState.Text.Equals("") || txtZip.Text.Equals(""))
            {
                MessageBox.Show("Each field must be filled out", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;


            }

            dataEntry = txtName.Text + "\r\n" + txtAddress.Text + "\r\n" +
                txtCity.Text + "\r\n" + txtState.Text + "\r\n" +
                txtZip.Text;
            MessageBox.Show(dataEntry, "Data Entry", MessageBoxButtons.OK);
            btnClear.PerformClick();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
