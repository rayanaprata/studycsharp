using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            CriandoMenu();
            Console.WriteLine("=======================================");
            UtilizandoEnum();
            Console.WriteLine("=======================================");
            VerificarFaixaEtaria();
            Console.WriteLine("=======================================");
            UtilizandoArray();
            Console.WriteLine("=======================================");
            UtilizandoSwitch();
            Console.WriteLine("=======================================");

            //declarando uma constante, valor que não será mais alterado pois ele é constante
            const float numPI = 3.14159265f;

            String name = "";
            Console.Write($"Insira seu nome: ");
            name = Console.ReadLine();
            Console.WriteLine($"\nOlá {name}, tudo bem?");

            int idade = 20;
            float mediaSemestre = 10.0f;
            bool aprovado = true;

            Console.Write($"Idade: ");
            Console.WriteLine(idade);

            Console.Write($"Média do semestre: ");
            Console.WriteLine(mediaSemestre);

            Console.Write($"Aprovado: ");
            if (aprovado)
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }

            var piQuadrado = Math.Pow(numPI, 2);
            Console.WriteLine($"PI ao quadrado: {piQuadrado.ToString("F")}");

        }
           
        static void VerificarFaixaEtaria()
        {
            /* toda informação que o usuário digita no console é considerada uma String
            // para converter esse valor de string pro tipo que eu quero (nesse caso int)
            // eu utilizo int.Parse(Console.ReadLine()); >Também conhecido como CAST. */

            Console.Write("Insira sua idade: ");
            int yearOld = int.Parse(Console.ReadLine());

            if (yearOld >= 0 && yearOld <= 11)
            {
                Console.WriteLine("Criança");
            }
            else if (yearOld > 11 && yearOld < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (yearOld >= 18 && yearOld <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }
        }

        static void UtilizandoArray()
        {
            const int tam = 10;
            int[] teste = new int[tam] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(teste[i]);
            }

            string[] arrayString = { "Valor 1", "Valor 2", "Valor 3" };
            for (int j=0; j < 3; j++)
            {
                Console.WriteLine(arrayString[j]);
            }
        }

        static void UtilizandoSwitch()
        {
            string opcao = "";
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine(" Menu | Créditos");
            Console.WriteLine("\nOpção escolhida: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "Menu":
                    Console.WriteLine("O programa chamaria a função Menu.");
                    //implementaria uma função menu e chamaria ela aqui
                    break;
                case "Créditos":
                    Console.WriteLine("Este sistema foi desenvolvido por Rayana Prata.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        //os enums são declarados fora das funções pois funcionam como uma constante ou variável global
/* Enums não podem ser declarados dentro de métodos, o compilador acusará um erro quando este código for escrito. Os enums podem ser de declarados dentro de uma classe ou fora da mesma, abaixo do namespace ou então acima do mesmo. Mas nunca dentro de métodos.*/
public enum Generos
{
    Aventura = 7089,
    Romance,
    Suspense,
    Terror
    //mesmo sendo string não é necessário utilizar aspar
}

public enum Cor { Azul, Verde, Amarelo, Vermelho }

public enum Opc { Sim = 1, Não }

static void UtilizandoEnum()
{
    Console.WriteLine("Enums, o que são?");
    Console.WriteLine("Enums são constantes fortamente tipadas. Elas são estáticas, ou seja não é possível nem preciso acessar os seus valores instaciando um objeto utilizando a palavra reservada new. O acesso é feito a partir do nome da classe em que está contido e em seguida o nome do enum a ser utilizado. (A declaração é bem parecida com uma declaração de variável).");

            Generos valor = Generos.Romance;
            Console.WriteLine($"Gênero: {valor} \nOutra forma de apresentar: {(Generos)7091} \nCada item no Enum tem um índice: {(int)Generos.Aventura}");

            Cor corFavorita = Cor.Amarelo;
            Cor corFavoritaJoao = Cor.Azul;
            Cor corFavoritaJuliana = Cor.Vermelho;

            Console.WriteLine((Cor)2);
            Console.WriteLine($"Cor favorita da Juliana: {corFavoritaJuliana} \nCor favorita do João: {corFavoritaJoao} \nCor favorita aleatória: {corFavorita}");

            Opc validacao = Opc.Sim;
            Console.WriteLine(validacao);

}

        public enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}

        public static void CriandoMenu ()
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1 - Criar \n2 - Deletar \n3 - Editar \n4 - Listar \n5 - Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você tem certeza de que quer criar algo?");
                    Console.WriteLine("1 - Sim \n2 - Não");
                    int indx = int.Parse(Console.ReadLine());
                    Opc confirmacao = (Opc)indx;
                    if (confirmacao == Opc.Sim)
                    {
                        //chamar funcao que cria algo
                    } else
                    {
                        //retornar pro menu
                    }
                                        
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo.");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer editar algo.");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você quer listar algo.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            
        }

}
}