using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Atendimento
    {
        public int Id { set; get; }
        [Required]
        public int ProcedimentoId { set; get; }
        public Procedimento Procedimento { get; }
        [Required]
        public int AgendamentoId { set; get; }
        public Agendamento Agendamento { get; }

        public Atendimento(){}

        public Atendimento(
            int ProcedimentoId,
            int AgendamentoId
        ) 
        {
            this.Id = Id;
            this.ProcedimentoId = ProcedimentoId;
            this.AgendamentoId = AgendamentoId;
            Context db = new Context();
            db.Atendimentos.Add(this);
            db.SaveChanges();

        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nPaciente: {this.Agendamento.Paciente.Nome}"
                + $"\nDentista: {this.Agendamento.Dentista.Nome}"
                + $"\nData: {this.Agendamento.Data}"
                + $"\nSala: {this.Agendamento.Sala}"
                + $"\nProcedimento: {this.Procedimento.Descricao}"
                + $"\nPreço: {this.Procedimento.Preco}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Atendimento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Atendimento it = (Atendimento) obj;
            return it.Id == this.Id;
        }
        public static List<Atendimento> GetAtendimentos()
        {   
            Context db = new Context();
            return (from Atendimento in db.Atendimentos select Atendimento).ToList();
        }

        public static void RemoverAtendimento(Atendimento atendimento)
        {   
            Context db = new Context();
            db.Atendimentos.Remove(atendimento);
        }
    }
}