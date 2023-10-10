using System;
using System.Collections.Generic;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        List<string> tarefas = new List<string>();

        Console.WriteLine("Listagem de tarefas iniciada");
        Thread.Sleep(1000);
        Console.WriteLine("Adicione suas tarefas do dia:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Tarefa {i + 1}: ");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
        }

        while (true)
        {
            Thread.Sleep(900);
            Console.WriteLine("Seu dia possui os seguintes itens a serem executados e concluídos:");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }

            Console.WriteLine("Deseja adicionar mais tarefas? (Sim/Não)");
            string respostaPositiva = Console.ReadLine();

            if (!respostaPositiva.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine("Iniciando próxima etapa");
                Thread.Sleep(999);
                break;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Tarefa {tarefas.Count + 1}: ");
                string tarefa = Console.ReadLine();
                tarefas.Add(tarefa);
            }
        }

        while (true)
        {
            Console.WriteLine("Deseja excluir alguma tarefa? (Sim/Não)");
            string respostaExcluir = Console.ReadLine();

            if (!respostaExcluir.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Iniciando próxima etapa");
                break;
            }

            Console.WriteLine("Escolha o número da tarefa que deseja excluir:");

            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }

            int numeroTarefaExcluir;
            if (int.TryParse(Console.ReadLine(), out numeroTarefaExcluir) && numeroTarefaExcluir >= 1 && numeroTarefaExcluir <= tarefas.Count)
            {
                tarefas.RemoveAt(numeroTarefaExcluir - 1);
                Console.WriteLine("Tarefa excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Número de tarefa inválido. Tarefa não excluída.");
            }
        }

        while (true)
        {
            Console.WriteLine("Deseja marcar alguma tarefa como concluída? (Sim/Não)");
            string respostaMarcarConcluida = Console.ReadLine();

            if (!respostaMarcarConcluida.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Encerrando o programa");
                break;
            }

            Console.WriteLine("Escolha o número da tarefa que deseja marcar como concluída:");

            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }

            int numeroTarefaConcluida;
            if (int.TryParse(Console.ReadLine(), out numeroTarefaConcluida) && numeroTarefaConcluida >= 1 && numeroTarefaConcluida <= tarefas.Count)
            {
                int indiceTarefa = numeroTarefaConcluida - 1;

                if (indiceTarefa >= 0 && indiceTarefa < tarefas.Count)
                {
                    Console.WriteLine($"Tarefa selecionada: {tarefas[indiceTarefa]}");
                    Console.WriteLine("Tarefa concluída com sucesso");
                    tarefas.RemoveAt(numeroTarefaConcluida - 1);
                }
                else
                {
                    Console.WriteLine("Número de tarefa inválido. Tarefa não concluída.");
                }
            }
            else
            {
                Console.WriteLine("Número de tarefa inválido. Tarefa não concluída.");
            }
        }

        //PAREI AQUI 

        //while (true)
        //{
        //    Console.WriteLine("Qual opção você deseja ?");
        //    Console.WriteLine("1 - Listagem de tarefas restantes");
        //    Console.WriteLine("2 - Adicionar nova tarefa");
        //    Console.WriteLine("3 - Excluir tarefa");
        //    Console.WriteLine("4 - Finalizar");

            //String opcao = Console.ReadLine();  

            //switch (opcao) 
            //{
            //    case "1":
            //        ListarTarefas(tarefas);
            //    case "2":
            //        AdicionarTarefas(tarefas);
            //    case "3":
            //        ExcluirTarefas(tarefas);
            //    case "4":
            //        Environment.Exit(0);    

            //}
        //}
    }
}
