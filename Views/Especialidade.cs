using System;
using Controllers;
using Models;

namespace Views
{
    public class EspecialidadeView
    {
        public static void InserirEspecialidade()
        {
            string Descricao;
            string Tarefas;
            Console.WriteLine("Digite a descrição da especialidade: ");
            try
            {
                Descricao = Console.ReadLine();
            }
            catch
            {
                throw new Exception("Descrição Inválida.");
            }
            Console.WriteLine("Digite as tarefas da especialidade: ");
            try
            {
                Tarefas = Console.ReadLine();
            }
            catch
            {
                throw new Exception("Tarefas Inválidas.");
            }

            EspecialidadeController.InserirEspecialidade(
                Descricao,
                Tarefas
            );

        }

        public static void AlterarEspecialidade()
        {
            int Id = 0;
            string Descricao;
            string Tarefas;
            Console.WriteLine("Digite o ID da especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }            
            Console.WriteLine("Digite a descrição da especialidade: ");
            try
            {
                Descricao = Console.ReadLine();
            }
            catch
            {
                throw new Exception("Descrição Inválida.");
            }
            Console.WriteLine("Digite as tarefas da especialidade: ");
            try
            {
                Tarefas = Console.ReadLine();
            }
            catch
            {
                throw new Exception("Tarefas Inválidas.");
            }

            EspecialidadeController.AlterarEspecialidade(
                Id,
                Descricao,
                Tarefas
            );
        }

        public static void ExcluirEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            EspecialidadeController.ExcluirEspecialidade(
                Id
            );

        }

        public static void ListarEspecialidades()
        {
            foreach (Especialidade item in EspecialidadeController.VisualizarEspecialidade())
            {
                Console.WriteLine(item);
            }
        }
    }
}