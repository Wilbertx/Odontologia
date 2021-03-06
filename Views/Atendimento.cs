using System;
using Controllers;
using Models;

namespace Views
{
    public class AtendimentoView
    {
        public static void InserirAtendimento()
        {
            int IdAgendamento;
            int IdProcedimento;
            Console.WriteLine("Digite o ID do Agendamento: ");
            try
            {
                IdAgendamento = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                IdProcedimento = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            AtendimentoController.InserirAtendimento(
                IdAgendamento,
                IdProcedimento
            );
        }

        public static void ExcluirAgendamento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do Atendimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            AtendimentoController.ExcluirAtendimento(
                Id
            );
        }

        public static void ListarAtendimentos()
        {
            foreach (Atendimento item in AtendimentoController.VisualizarAtendimentos())
            {
                Console.WriteLine(item);
            }
        }
    }
}