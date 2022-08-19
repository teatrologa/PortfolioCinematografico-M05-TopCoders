﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio.Presentation
{
    public partial class FrmRegistration : Form
    {
        bool CadastroMostrarSenha = false;
        bool validName = false;
        bool validUserName = false;
        bool validBirthDate = false;
        bool validPassword = false;
        public FrmRegistration()
        {
            InitializeComponent();
            lblCadastroNameValidation.Text = "";
            lblCadastroBirthDateValidation.Text = "";
            lblCadastroUserNameValidation.Text = "";
            lblCadastroPasswordValidation.Text = "";
            lblCadastroPasswordConfirmValidation.Text = "";
            btnCadastroEnviar.Enabled = false;
        }

        private void chbCadastroMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (!CadastroMostrarSenha)
            {
                CadastroMostrarSenha = true;
                txbCadastroTypePassword.UseSystemPasswordChar = false;
                txbCadastroConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                CadastroMostrarSenha = false;
                txbCadastroTypePassword.UseSystemPasswordChar = true;
                txbCadastroConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbCadastroName_TextChanged(object sender, EventArgs e)
        {
            string input = txbCadastroName.Text;
            lblCadastroNameValidation.Text = "";
            validName = false;
            if (input == string.Empty)
            {
                lblCadastroNameValidation.Text = "";
                validName = false;
            }
            else if (input.Replace(" ", "") == "")
            {
                lblCadastroNameValidation.Text = "Nome inválido.";
                lblCadastroNameValidation.ForeColor = Color.Red;
                validName = false;
                return;
            }
            else
            {
                input = txbCadastroName.Text;
                //if (input != string.Empty && input[input.Length - 1] == ' ')
                if (input != string.Empty && input[^1] == ' ')
                {
                    validName = false;
                    return;
                }
                string[] names = input.Split(' ');
                if (names.Length >= 2)
                {
                    if (names[1] != "")
                    {
                        lblCadastroNameValidation.Text = "Nome válido";
                        lblCadastroNameValidation.ForeColor = Color.Green;
                        validName = true;
                    }
                }
            }
        }

        private void mtxBirthDate_TextChanged(object sender, EventArgs e)
        {
            DateTime birthDate;
            string input = mtxBirthDate.Text;
            if (input == string.Empty || input.Length < 10)
                lblCadastroBirthDateValidation.Text = "";
            else if (input.Replace(" ", "") == "")
            {
                lblCadastroBirthDateValidation.Text = "Data inválida.";
                lblCadastroBirthDateValidation.ForeColor = Color.Red;
                return;
            }
            else
            {
                if (DateTime.TryParse(input, out birthDate))
                {
                    lblCadastroBirthDateValidation.Text = "Data válida";
                    lblCadastroBirthDateValidation.ForeColor = Color.Green;
                }
                else
                {
                    lblCadastroBirthDateValidation.Text = "Data inválida";
                    lblCadastroBirthDateValidation.ForeColor = Color.Red;
                }
            }
        }

        private void txbCadastroUserName_TextChanged(object sender, EventArgs e)
        {
            string input = txbCadastroUserName.Text;
            lblCadastroUserNameValidation.Text = "";
            validUserName = false;
            if (input == string.Empty)
            {
                lblCadastroUserNameValidation.Text = "";
                validUserName = false;
            }
            else if (input.Replace(" ", "") == "")
            {
                lblCadastroUserNameValidation.Text = "Nome inválido.";
                lblCadastroUserNameValidation.ForeColor = Color.Red;
                validUserName = false;
                return;
            }
            else
            {
                input = lblCadastroUserNameValidation.Text;
                //if (input != string.Empty && input[input.Length - 1] == ' ')
                if (input != string.Empty && input[^1] == ' ')
                {
                    validUserName = false;
                    return;
                }
                string[] names = input.Split(' ');
                if (names.Length >= 2)
                {
                    if (names[1] != "")
                    {
                        lblCadastroUserNameValidation.Text = "Nome válido";
                        lblCadastroUserNameValidation.ForeColor = Color.Green;
                        validUserName = true;
                    }
                }
            }
        }
    }
}
