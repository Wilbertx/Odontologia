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
public class InserirAgendamento : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public InserirAgendamento()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);

        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar as informações deste agendamento?" +
                $"",
                "Atualizar Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento alterado com sucesso! " +
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