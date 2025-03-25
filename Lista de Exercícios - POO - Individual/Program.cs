using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; private set; }

    public Produto(string nome, double preco, int quantidadeInicial)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidadeInicial;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade inválida!");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= Quantidade)
        {
            Quantidade -= quantidade;
            Console.WriteLine($"{quantidade} unidades removidas do estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente ou inválida!");
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: R${Preco:F2}\nQuantidade em estoque: {Quantidade}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade inicial em estoque: ");
        int quantidadeInicial = Convert.ToInt32(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidadeInicial);

        int opcao;
        do
        {
            Console.WriteLine("\n1 - Adicionar Estoque");
            Console.WriteLine("2 - Remover Estoque");
            Console.WriteLine("3 - Exibir Detalhes do Produto");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a quantidade para adicionar ao estoque: ");
                    int adicionar = Convert.ToInt32(Console.ReadLine());
                    produto.AdicionarEstoque(adicionar);
                    break;
                case 2:
                    Console.Write("Digite a quantidade para remover do estoque: ");
                    int remover = Convert.ToInt32(Console.ReadLine());
                    produto.RemoverEstoque(remover);
                    break;
                case 3:
                    produto.ExibirDetalhes();
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