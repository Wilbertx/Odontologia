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
public class TelaAgendamento : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblAgendamento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public TelaAgendamento()
        {
            this.lblAgendamento = new Label();
            this.lblAgendamento.Text = "Agendamento";
            this.lblAgendamento.Location = new Point(200, 10);

            this.Controls.Add(this.lblAgendamento);

            listView = new ListView();
            listView.Location = new Point(100, 70);
            listView.Size = new Size(280, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("2022/03/21");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("PacienteId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("DentistaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("SalaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmAgendamentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmAgendamentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmAgendamentoAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(480, 300);
        }

        private void handleConfirmAgendamentoAtualizar(object sender, EventArgs e)
        {
            AtualizarAgendamento menu = new AtualizarAgendamento();
            menu.Size = new Size(325, 400);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoDeletar(object sender, EventArgs e)
        {
            DeletarAgendamento menu = new DeletarAgendamento();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoInserir(object sender, EventArgs e)
        {
            InserirAgendamento menu = new InserirAgendamento();
            menu.Size = new Size(325, 400);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}