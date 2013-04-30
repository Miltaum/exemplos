using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarCombos();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMensagem.Text, txtCaption.Text, TipoButtons(cmbTipo.Text), TipoIcons(cmbIcone.Text));
        }

        private void CarregarCombos()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add(MessageBoxButtons.AbortRetryIgnore.ToString());
            cmbTipo.Items.Add(MessageBoxButtons.OK.ToString());
            cmbTipo.Items.Add(MessageBoxButtons.OKCancel.ToString());
            cmbTipo.Items.Add(MessageBoxButtons.RetryCancel.ToString());
            cmbTipo.Items.Add(MessageBoxButtons.YesNo.ToString());
            cmbTipo.Items.Add(MessageBoxButtons.YesNoCancel.ToString());

            cmbIcone.Items.Clear();
            cmbIcone.Items.Add(MessageBoxIcon.Asterisk.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Error.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Exclamation.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Hand.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Information.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.None.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Question.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Stop.ToString());
            cmbIcone.Items.Add(MessageBoxIcon.Warning.ToString());
        }

        private MessageBoxButtons TipoButtons(string tipo)
        {
            int ret=0;

            switch (tipo)
            {
                case "AbortRetryIgnore":
                    ret = (int)MessageBoxButtons.AbortRetryIgnore;
                    break;
                case "OK":
                    ret = (int)MessageBoxButtons.OK;
                    break;
                case "OKCancel":
                    ret = (int)MessageBoxButtons.OKCancel;
                    break;
                case "RetryCancel":
                    ret = (int)MessageBoxButtons.RetryCancel;
                    break;
                case "YesNo":
                    ret = (int)MessageBoxButtons.YesNo;
                    break;
                case "YesNoCancel":
                    ret = (int)MessageBoxButtons.YesNoCancel;
                    break;
            }

            return (MessageBoxButtons)ret;
        }

        private MessageBoxIcon TipoIcons(string tipo)
        {
            int ret = 0;

            switch (tipo)
            {
                case "Asterisk":
                    ret = (int)MessageBoxIcon.Asterisk;
                    break;
                case "OK":
                    ret = (int)MessageBoxIcon.Error;
                    break;
                case "Exclamation":
                    ret = (int)MessageBoxIcon.Exclamation;
                    break;
                case "Hand":
                    ret = (int)MessageBoxIcon.Hand;
                    break;
                case "Information":
                    ret = (int)MessageBoxIcon.Information;
                    break;
                case "None":
                    ret = (int)MessageBoxIcon.None;
                    break;
                case "Question":
                    ret = (int)MessageBoxIcon.Question;
                    break;
                case "Stop":
                    ret = (int)MessageBoxIcon.Stop;
                    break;
                case "Warning":
                    ret = (int)MessageBoxIcon.Warning;
                    break;
            }

            return (MessageBoxIcon)ret;
        }

    }
}
