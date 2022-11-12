using System;

namespace ConsoleApp12
{
    internal class Program
    {
        public struct dados
        {
            public string nome;
            public string telefone;
            public string empresa;
            public int situacao;
        }

        static void enviar(dados[] inf)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite seu Nome: ");
                inf[i].nome = Console.ReadLine();

                Console.Write("Digite seu Telefone: ");
                inf[i].telefone = Console.ReadLine();

                Console.Write("Digite onde Trabalha: ");
                inf[i].empresa = Console.ReadLine();

                inf[i].situacao = 1;
                Console.Clear();
            }
            Console.WriteLine("Cadastros enviados com Sucesso !");
        }

        static void excluir(dados[] inf)
        {
            Console.Clear();

            Console.Write("Qual o nome do Contato que deseja exluir ?: ");
            string contato = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (inf[i].nome == contato)
                {
                    Console.WriteLine($"Contato número {i}");
                    Console.WriteLine($"Nome: {inf[i].nome}");
                    Console.WriteLine($"Telefone: {inf[i].telefone}");
                    Console.WriteLine($"Empresa: {inf[i].empresa}");
                    Console.WriteLine("");
                    Console.Write("Deseja realmente excluír este cadastro ? (S/N) ");
                    string escolha = Console.ReadLine().ToString().ToUpper();
                    Console.Clear();

                    if (escolha == "S")
                    {
                        inf[i].situacao = 0;
                        Console.WriteLine("Cadastro excluído com Sucesso !");
                    }
                    else
                    {
                        Console.WriteLine("Cadastro não será apagado !");
                    }
                }
            }
        }

        static void listar(dados[] inf)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (inf[i].situacao == 1)
                {
                    Console.WriteLine($"Contato número: {i} ");
                    Console.WriteLine($"Nome: {inf[i].nome}");
                    Console.WriteLine($"Telefone: {inf[i].telefone}");
                    Console.WriteLine($"Empresa: {inf[i].empresa}");
                    Console.WriteLine("");
                }
            }
        }

        static void alterar(dados[] inf)
        {
            string nome;
            string telefone;
            string empresa;

            Console.Clear();
            Console.Write("Qual contato deseja alterar ?: ");
            string contato = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                if (inf[i].nome == contato)
                {
                    Console.WriteLine($"Contato número {i}");
                    Console.WriteLine($"Nome: {inf[i].nome}");
                    Console.WriteLine($"Telefone: {inf[i].telefone}");
                    Console.WriteLine($"Empresa: {inf[i].empresa}");
                    Console.WriteLine("");

                    Console.WriteLine("Alterar Nome (1) ");
                    Console.WriteLine("Alterar Telefone (2) ");
                    Console.WriteLine("Alterar Empresa (3) ");
                    Console.WriteLine("Alterar Todos os Dados (4) ");
                    Console.Write("Deseja alterar: ");
                    int escolha = int.Parse(Console.ReadLine());

                    while(escolha > 4)
                    {
                        Console.Write("Opcão inválida, Digite novamente: ");
                        escolha = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    switch (escolha)
                    {
                        case 1:
                            Console.Write("Deseja alterar para qual Nome: ");
                            nome = Console.ReadLine();
                            inf[i].nome = nome;
                            Console.Clear();
                            Console.WriteLine("Nome Alterado com Sucesso !");
                            break;
                        case 2:
                            Console.Write("Deseja alterar para qual Telefone: ");
                            telefone = Console.ReadLine();
                            inf[i].telefone = telefone;
                            Console.Clear();
                            Console.WriteLine("Telefone Alterado com Sucesso !");
                            break;
                        case 3:
                            Console.Write("Deseja alterar para qual Empresa: ");
                            empresa = Console.ReadLine();
                            inf[i].empresa = empresa;
                            Console.Clear();
                            Console.WriteLine("Empresa Alterada com Sucesso !");
                            break;
                        case 4:
                            Console.Write("Deseja alterar para qual Nome: ");
                            nome = Console.ReadLine();
                            inf[i].nome = nome;
                            Console.Write("Deseja alterar para qual Telefone: ");
                            telefone = Console.ReadLine();
                            inf[i].telefone = telefone;
                            Console.Write("Deseja alterar para qual Empresa: ");
                            empresa = Console.ReadLine();
                            inf[i].empresa = empresa;
                            Console.Clear();
                            Console.WriteLine("Dados alterados com Sucesso !");
                            break;
                    }
                }

            }
        }

        static void pesquisar(dados[] inf)
        {
            Console.Clear();

            Console.WriteLine("Digite o Nome do cadastro que deseja pesquisar: ");
            string pesquisa = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                if (inf[i].nome == pesquisa && inf[i].situacao == 0)
                {
                    Console.WriteLine($"Cadastro não está mais ativo na agenda !");
                }
                if(inf[i].nome == pesquisa)
                {
                    Console.WriteLine($"Contato número: {i} ");
                    Console.WriteLine($"Nome: {inf[i].nome}");
                    Console.WriteLine($"Telefone: {inf[i].telefone}");
                    Console.WriteLine($"Empresa: {inf[i].empresa}");
                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            dados[] inf = new dados[3];

            string opc = "S";

            while (opc == "S")
            {
                Console.WriteLine("Bem vindo a agenda eletrônica ! ");
                Console.WriteLine("");
                Console.WriteLine("(1) Adicionar contato:");
                Console.WriteLine("(2) Excluír contato:");
                Console.WriteLine("(3) Listar todos Contatos:");
                Console.WriteLine("(4) Alterar Contato:");
                Console.WriteLine("(5) Pesquisar um Contato:");
                Console.WriteLine("(6) Sair:");
                Console.WriteLine("");
                Console.Write("Qual opção deseja ?: ");
                int escolha = int.Parse(Console.ReadLine());

                while(escolha > 6)
                {
                    Console.Write("Opcão inválida, Digite novamente: ");
                    escolha = int.Parse(Console.ReadLine());
                }

                switch (escolha)
                {
                    case 1:
                        enviar(inf);
                        Console.WriteLine("");
                        Console.WriteLine("Tecle para Continuar !");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        excluir(inf);
                        Console.WriteLine("");
                        Console.WriteLine("Tecle para Continuar !");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        listar(inf);
                        Console.WriteLine("");
                        Console.WriteLine("Tecle para Continuar !");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        alterar(inf);
                        Console.WriteLine("");
                        Console.WriteLine("Tecle para Continuar !");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        pesquisar(inf);
                        Console.WriteLine("");
                        Console.WriteLine("Tecle para Continuar !");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("O programa irá Encerrar !");
                        Console.ReadKey();
                        opc = "N";
                        break;
                }
            }
        }
    }
}
