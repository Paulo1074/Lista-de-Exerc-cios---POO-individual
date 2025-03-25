using System;

class Lampada
{
    private bool Ligada;

    public void Ligar()
    {
        Ligada = true;
        Console.WriteLine("Lâmpada ligada.");
    }

    public void Desligar()
    {
        Ligada = false;
        Console.WriteLine("Lâmpada desligada.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine(Ligada ? "A lâmpada está ligada." : "A lâmpada está desligada.");
    }
}

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();
        int opcao;

        do
        {
            Console.WriteLine("\n1 - Ligar Lâmpada");
            Console.WriteLine("2 - Desligar Lâmpada");
            Console.WriteLine("3 - Mostrar Estado");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    lampada.Ligar();
                    break;
                case 2:
                    lampada.Desligar();
                    break;
                case 3:
                    lampada.MostrarEstado();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
}
