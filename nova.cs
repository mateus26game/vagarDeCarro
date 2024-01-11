using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace visual_studui
{
    public class nova
    {
    static void Main() {
        while (true) {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Fichar estacionamento");
            Console.WriteLine("2 - Pagar estacionamento");
            Console.WriteLine("3 - Sair do programa");

            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    FicharEstacionamento();
                    break;
                case "2":
                    PagarEstacionamento();
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void FicharEstacionamento() {
        // Obtém o horário atual do sistema
        DateTime horarioAtual = DateTime.Now;

        // Imprime o horário no formato padrão
        Console.WriteLine("Fichando estacionamento... sua hora: " + horarioAtual);
        // Lógica para fichar estacionamento
    }

    static void PagarEstacionamento() {
        // Pergunta a hora que o usuário sai do estacionamento
        Console.WriteLine("Digite a hora que você está saindo do estacionamento (formato HH:mm): ");
        string horaSaidaString = Console.ReadLine();

        // Tenta converter a hora de saída para um objeto DateTime
        if (DateTime.TryParseExact(horaSaidaString, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime horaSaida)) {
            // Calcula a diferença em minutos
            TimeSpan diferenca = horaSaida - DateTime.Now;

            // Compara com 15 minutos
            if (diferenca.TotalMinutes <= 15) {
                Console.WriteLine("Você não precisa pagar. Menos de 15 minutos no estacionamento.");
            } else {
                Console.WriteLine("Você precisa pagar. Mais de 15 minutos no estacionamento.");
            }
        } else {
            Console.WriteLine("Formato de hora inválido. Utilize o formato HH:mm.");
        }
    }
}

    }
