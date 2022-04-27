using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Views
{
public class AtualizarDentista : Form //Atualizar Dentista
    {
        Label lblNome;
        Label lblCpf;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblRegistro;
        Label lblSalario;
        Label lblEspecialidade;

        TextBox txtNome;
        TextBox txtCpf;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidade;

        Button btnConfirm;
        Button btnCancel;

        public AtualizarDentista()
        {

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);

            this.lblRegistro = new Label();
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Location = new Point(128, 320);

            this.lblSalario = new Label();
            this.lblSalario.Text = "Salario";
            this.lblSalario.Location = new Point(128, 380);

            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(120, 440);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.txtRegistro = new TextBox();
            this.txtRegistro.Location = new Point(10, 350);
            this.txtRegistro.Size = new Size(280, 30);

            this.txtSalario = new TextBox();
            this.txtSalario.Location = new Point(10, 410);
            this.txtSalario.Size = new Size(280, 30);

            this.txtEspecialidade = new TextBox();
            this.txtEspecialidade.Location = new Point(10, 470);
            this.txtEspecialidade.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 520);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 520);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidade);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEspecialidade);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar os dados deste dentista?" +
                $"",
                "Atualizar Dentista",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Dentista alterado com sucesso! " +
                    $"",
                    "",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}