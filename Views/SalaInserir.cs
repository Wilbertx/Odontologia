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
public class InserirSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public InserirSala()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir esta nova sala?" +
                $"",
                "Inserir Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala cadastrada com sucesso! " +
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