using EscovandoBits.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EscovandoBits
{
    public enum CarroPreferido { Gol = 1, Clio = 2, Onix = 3, Civic = 4, Focus = 5, CRV = 6, Ecosport = 7 };
    public enum DiasDaSemana { Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo };

    public class Program
    {

        public static void Main(string[] args)
        {
            string opcao;
            bool continua;
            do
            {
                Console.Clear();
                Console.WriteLine("Você quer aprender sobre :");
                Console.WriteLine("1 - Tipos por Valor");
                Console.WriteLine("2 - Tipos por Referência");
                Console.WriteLine("3 - Sair");
                opcao = Console.ReadLine();
                if (opcao.Trim() == "1")
                {
                    MenuTipoPorValor();
                }
                else if (opcao.Trim() == "2")
                {
                    MenuTipoPorReferencia();
                }
                continua = opcao.Trim() != "3";
            }
            while (continua);

        }

        private static void Cabecalho(string descricao)
        {
            Console.WriteLine("============================================================");
            Console.WriteLine(descricao);
            Console.WriteLine("============================================================");
            Console.WriteLine("");
        }

        private static void PressioneQualquerTecla()
        {
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }


        #region Tipo Por Valor

        private static void MenuTipoPorValor()
        {
            Console.Clear();
            string opcao;
            bool continua;
            do
            {
                Console.Clear();
                Cabecalho("Tipos Por Valor");
                Console.WriteLine("Você quer aprender sobre :");
                Console.WriteLine("1 - Tipos Simples");
                Console.WriteLine("2 - Pontos Flutuantes");
                Console.WriteLine("3 - Anuláveis");
                Console.WriteLine("4 - Enums");
                Console.WriteLine("5 - Structs");
                Console.WriteLine("6 - Sair");
                opcao = Console.ReadLine().Trim();

                if (opcao == "1")
                    TiposSimples();
                else if (opcao == "2")
                    PontosFlutuantes();
                else if (opcao == "3")
                    Anulaveis();
                else if (opcao == "4")
                    Enums();
                else if (opcao == "4")
                    Structs();
                continua = opcao != "6";
            }
            while (continua);
            
        }

        private static void TiposSimples()
        {

            Cabecalho("Tipos Simples - São Structs");

            //Numéricos(Inteiros, ponto flutuante, decimal), booleanos, Data Hora são struct
            //INTEIROS
            Console.WriteLine("");
            Console.WriteLine("Inteiro (int), método de conversão - ToString()");

            int a = 2147483647;
            int b = a;
            Console.WriteLine("O valor da variável a é: " + a.ToString());
            //Não consigo atrbuir null (a = null;)

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Booleano (bool), método de conversão - ToString()");
            //BOOLEANOS
            bool verdadeiro = a == b;
            Console.WriteLine("A variável ''a'' é igual a variável ''b'' : " + verdadeiro.ToString());
            bool falso = a > b;
            //var falso = a > b;
            Console.WriteLine("A variável ''a'' é maior a variável ''b'' : " + falso.ToString());
            //Não consigo atrbuir null (verdadeiro = null;)

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Data Hora (DateTime), método de conversão - ToString(''dd/MM/yyyy HH:mm:ss''), posso formatar a data e hora");
            //DATA HORA
            Console.WriteLine("Agora são estamos extamente em :" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            DateTime amanha = DateTime.Now.AddDays(1);
            Console.WriteLine($"Amanhã será : {amanha:dd/MM/yyyy}");
            //Não consigo atrbuir null (amanha = null;)

            PressioneQualquerTecla();
        }

        private static void PontosFlutuantes()
        {
            Cabecalho("Tipos Simples (Decimal, float, Double) - São Structs");
            /*
            Float e double trabalham com arredondamento de valores. 
            Por essa razão, são recomendados quando você não se importa se houver um arredondamentos aqui ou ali. 
            São bastante usados para cálculos científicos.

            Com decimal é diferente: usamos com ele quando queremos precisão exata de valores. 
            Geralmente queremos isso quando estamos trabalhando com dinheiro, certo?
            Por causa da precisão alta, trabalhar com decimals é mais lento.

            Em termos de magnitude, conseguimos guardar números maiores em um double, 
            porém com precisão menor.
            Em um decimal guardamos menores, mas com mais precisão.             
             */
            double valor1Double = 10.10;
            double valor2Double = 20.20;
            double valorTotalDouble = 30.30;

            Console.WriteLine("");
            Console.WriteLine(" =>  Double");
            Console.WriteLine("");

            Console.WriteLine($"10.10 + 20.20 é igual a 30.30? => {((valor1Double + valor2Double) == valorTotalDouble)}");

            Console.WriteLine($"Na realidade (10.10 + 20.20) == 30.299999999999997? => {(valor1Double + valor2Double) == 30.299999999999997}");


            Console.WriteLine("");
            Console.WriteLine(" =>  Decimal");
            Console.WriteLine("");

            decimal valor1Decimal = 10.1m;
            decimal valor2Decimal = 20.2m;
            decimal valorTotalDecimal = 30.3m;

            Console.WriteLine($"10.1m + 20.2m é igual a 30.3m? => {((valor1Decimal + valor2Decimal) == valorTotalDecimal)}");

            Console.WriteLine($"Na realidade (10.1m + 20.2m) == 30.299999999999997? => {(valor1Decimal + valor2Decimal) == 30.299999999999997m}");

            PressioneQualquerTecla();
        }

        private static void Anulaveis()
        {
            Cabecalho("Anuláveis (Nullable<T> ou ''Tipo''?)");
            //Anuláveis
            Nullable<int> inteiroAnulavel = null;
            Console.WriteLine($"inteiroAnulavel é igual a : {inteiroAnulavel}");
            inteiroAnulavel = 10;
            Console.WriteLine($"inteiroAnulavel é igual a : {inteiroAnulavel}");

            DateTime? dataAnulavel = null;
            Console.WriteLine($"dataAnulavel é igual a : {dataAnulavel}");
            dataAnulavel = DateTime.Now;
            Console.WriteLine($"dataAnulavel é igual a : {dataAnulavel}");

            bool? alternativa = null;
            if (!alternativa.HasValue)
            {
                Console.WriteLine($"alternativa HasValue verifica se foi atribuido null a variável");
                alternativa = true; // Atribuição é implicita
            }
            Console.WriteLine($"Quando preciso atribuir um valor a uma variavel preciso usar explicitamente a propriedade Value");
            bool alternativaNaoAnulavel = alternativa.Value;


            PressioneQualquerTecla();
        }

        private static string ObterDados(string mensagem)
        {
            Console.WriteLine(mensagem);
            return Console.ReadLine();
        }

        private static void Structs()
        {
            Cabecalho("Tipos de valor definido pelo Usuário -  Struct");
            Double.TryParse(ObterDados("Digite a Base"), out double base1);
            Double.TryParse(ObterDados("Digite a Altura"), out double altura1);

            Retangulo retangulo1 = new Retangulo(base1, altura1);
            try
            {
                Console.WriteLine($"Área do retangulo1 é {retangulo1.CalcularArea()} ");
            }
            catch(Exception)
            {
                Console.WriteLine("Erro ao calcular!");
            }
            Retangulo retangulo2 = retangulo1;

            Double.TryParse(ObterDados("Digite a Base do retangulo2: "), out double base2);
            retangulo2.Base = base2;
            try
            {
                Console.WriteLine($"Área do retangulo2 é {retangulo2.CalcularArea()} ");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao calcular!");
            }

            Console.WriteLine("Struct copia o valor para outra variável, repare que alterei a retangulo2 mas a retangulo 1 não modificou");
            Console.WriteLine("");
            Console.WriteLine($" =>  retangulo1 Base = {retangulo1.Base}; Altura = {retangulo1.Altura}; Area = {retangulo1.CalcularArea()}");
            Console.WriteLine("");
            Console.WriteLine($" =>  retangulo2 Base = {retangulo2.Base}; Altura = {retangulo2.Altura}; Area = {retangulo2.CalcularArea()}");
            PressioneQualquerTecla();
        }

        private static void Enums()
        {
            Cabecalho("Tipos de valor definido pelo Usuário - Enums");
            Console.WriteLine($"{(int)DiasDaSemana.Segunda} {DiasDaSemana.Segunda}");
            Console.WriteLine($"{(int)DiasDaSemana.Terca} {DiasDaSemana.Terca}");
            Console.WriteLine($"{(int)DiasDaSemana.Quarta} {DiasDaSemana.Quarta}");
            Console.WriteLine($"{(int)DiasDaSemana.Quinta} {DiasDaSemana.Quinta}");
            Console.WriteLine($"{(int)DiasDaSemana.Sexta} {DiasDaSemana.Sexta}");
            Console.WriteLine($"{(int)DiasDaSemana.Sabado} {DiasDaSemana.Sabado}");
            Console.WriteLine($"{(int)DiasDaSemana.Domingo} {DiasDaSemana.Domingo}");
            int.TryParse(ObterDados("Que dia da semana é hoje. (Digite o número):"), out int dia);
            Console.WriteLine();
            Console.WriteLine($"Você escolheu o dia {Enum.GetName(typeof(DiasDaSemana), dia)}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{(int)CarroPreferido.Gol} {CarroPreferido.Gol}");
            Console.WriteLine($"{(int)CarroPreferido.Clio} {CarroPreferido.Clio}");
            Console.WriteLine($"{(int)CarroPreferido.Onix} {CarroPreferido.Onix}");
            Console.WriteLine($"{(int)CarroPreferido.Civic} {CarroPreferido.Civic}");
            Console.WriteLine($"{(int)CarroPreferido.Focus} {CarroPreferido.Focus}");
            Console.WriteLine($"{(int)CarroPreferido.CRV} {CarroPreferido.CRV}");
            Console.WriteLine($"{(int)CarroPreferido.Ecosport} {CarroPreferido.Ecosport}");
            int.TryParse(ObterDados("Qual destes carros você prefere? (Digite o número):"), out int carro);
            Console.WriteLine();
            Console.WriteLine($"Você escolheu o carro {Enum.GetName(typeof(CarroPreferido), carro)}");

            PressioneQualquerTecla();
        }
        #endregion

        #region Tipos por Referência

        private static void MenuTipoPorReferencia()
        {
            Console.Clear();
            string opcao;
            bool continua;
            do
            {
                Console.Clear();
                Cabecalho("Tipos Por Referência");
                Console.WriteLine("Você quer aprender sobre :");
                Console.WriteLine("1 - Classes e Objects");
                Console.WriteLine("2 - Interfaces");
                Console.WriteLine("3 - Arrays");
                Console.WriteLine("4 - Delegates");
                Console.WriteLine("5 - Boxing e Unboxing");
                Console.WriteLine("6 - Conversoes");
                Console.WriteLine("7 - Dynamics");
                Console.WriteLine("8 - Sair");
                opcao = Console.ReadLine().Trim();

                if (opcao == "1")
                    ClassesEObjects();
                else if (opcao == "2")
                    Interfaces();
                else if (opcao == "3")
                    OlhaMeuArray();
                else if (opcao == "4")
                    Delegates();
                else if (opcao == "5")
                    BoxingUnboxing();
                else if (opcao == "6")
                    Conversoes();
                else if (opcao == "7")
                    Dynamics();

                continua = opcao != "8";
            }
            while (continua);

        }

        private static void Dynamics()
        {
            Cabecalho("Dynamic");
            dynamic dynamicString = "Eduardo Aguiar";
            dynamic dynamicInt = 42;
            dynamic dynamicDate = DateTime.Now;
            dynamic dynamicList = new List<string> { "A", "B", "CD", "EFG", "H" };

            Console.WriteLine(dynamicString);
            Console.WriteLine(dynamicInt);
            Console.WriteLine(dynamicDate);
            Console.WriteLine(dynamicList);

            Console.WriteLine("");
            Console.WriteLine("Conversão dynamic para o tipo correto");
            string nome = dynamicString;
            int numeroMagico = dynamicInt;
            DateTime dataAtual = dynamicDate;
            List<string> lista = dynamicList;

            Console.WriteLine("");
            Console.WriteLine("Resultado");
            Console.WriteLine(nome);
            Console.WriteLine(numeroMagico);
            Console.WriteLine(dataAtual);
            lista.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("");
            Console.WriteLine("Tentando converter");
            try
            {
                int inteiro = dynamicString;
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} Erro: Conversão incorreta.", ex.Message);
            }
            PressioneQualquerTecla();
        }


        private static void Conversoes()
        {
            Cabecalho("Conversões");

            short i = 10;
            short j = 2;
            int resultado = i + j;
            Console.WriteLine($"Valores convertidos ''i'' = {i}; ''j'' = {j}; (int)''resultado'' = {resultado};");

            decimal salarioBase = 2147483647.45m;
            short salario = 0;
            try
            {
                salario = (short)salarioBase;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("{0} Erro: Conversão incorreta.", e.Message);
            }
            salarioBase = 9501.67m;
            try
            {
                salario = (short)salarioBase;
                Console.WriteLine($"Converteu mais Perdeu! ''salarioBase'' = {salarioBase}; ''salario'' = {salario}");

            }
            catch (OverflowException e)
            {
                Console.WriteLine("{0} Erro: Conversão incorreta.", e.Message);
            }

            Console.WriteLine($"Valor de ''salario'' {salario}");

            PressioneQualquerTecla();
        }

        //TABELA DE CONVERSÕES NUMÉRICAS IMPLÍCITAS
        //=========================================

        //De        Para
        //=============================================================
        //sbyte     short, int, long, float, double ou decimal
        //byte      short, ushort, int, uint, long, ulong, float, double ou decimal
        //short     int, long, float, double ou decimal
        //ushort    int, uint, long, ulong, float, double ou decimal
        //int       long, float, double ou decimal
        //uint      long, ulong, float, double ou decimal
        //long      float, double ou decimal
        //char      ushort, int, uint, long, ulong, float, double ou decimal
        //float     double
        //ulong     float, double ou decimal
        //double    (nenhum)
        //decimal   (nenhum)



        private static void BoxingUnboxing()
        {
            Cabecalho("Boxing e Unboxing");

            int i = 123;
            object o = i;  // boxing implicito

            try
            {
                int j = (int)o; // unbox explícito
                Console.WriteLine($"Copiado o Valor de ''o''={o} para ''j''={j}");
                o = 456;
                Console.WriteLine($"Alterei o Valor de ''o''={o}. O ''j''={j} e o ''i''={i} não foram alterados.");
                int incorrect = (short)o;  
                Console.WriteLine("Unboxing OK.");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("{0} Erro: Unboxing incorreto.", e.Message);
            }
            PressioneQualquerTecla();
        }

        private static void MostrarCalculoNoDelegateDuasCasasDecimais(Produto produto)
        {
            Console.WriteLine("Mostrando Calculo Com duas casas decimais");
            Console.WriteLine($"Valor Total do Produto => {produto.Preco:C2} x {produto.Quantidade} = {produto.Total:C2}");
        }

        private static void MostrarCalculoNoDelegateTresCasasDecimais(Produto produto)
        {
            Console.WriteLine("Mostrando Calculo Com tres casas decimais");
            Console.WriteLine($"Valor Total do Produto => {produto.Preco:C3} x {produto.Quantidade} = {produto.Total:C2}");
        }

        private static void Delegates()
        {
            Cabecalho("Delegates");
            var produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Descricao = "Coca-Cola 2L Gelada";
            produto1.Preco = 5.75m;
            produto1.Quantidade = 5;
            produto1.MostrarCalculo = MostrarCalculoNoDelegateDuasCasasDecimais;
            produto1.CalcularTotal();

            Console.WriteLine("");
            Console.WriteLine("");

            var produto2 = new Produto();
            produto1.Codigo = 2;
            produto1.Descricao = "Gasolina Aditivada 1L";
            produto1.Preco = 5.019m;
            produto1.Quantidade = 13;
            produto1.MostrarCalculo = MostrarCalculoNoDelegateTresCasasDecimais;
            produto1.CalcularTotal();

            PressioneQualquerTecla();
        }


        private static void OlhaMeuArray()
        {
            Cabecalho("Arrays");
            int[] nums = new int[4];
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite um número mágico");
                string valor = Console.ReadLine();
                int.TryParse(valor, out nums[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Seus números mágicos foram!");
            foreach (int numero in nums)
                Console.WriteLine(numero);
            Console.WriteLine("");
            Console.WriteLine("Aumentando o tamanho do Array");
            Array.Resize(ref nums, nums.Length + 3);
            Console.WriteLine("");
            Console.WriteLine("Mostrando os números mágicos de novo após aumentar o array");
            foreach (int numero in nums)
                Console.WriteLine(numero);

            Console.WriteLine("");
            Console.WriteLine("Array bidimensional");
            string[,] jogoDaVelha = new string[3, 3];
            jogoDaVelha[0, 0] = "X";
            jogoDaVelha[0, 1] = "O";
            jogoDaVelha[0, 2] = "O";

            jogoDaVelha[1, 0] = "*";
            jogoDaVelha[1, 1] = "X";
            jogoDaVelha[1, 2] = "*";

            jogoDaVelha[2, 0] = "*";
            jogoDaVelha[2, 1] = "*";
            jogoDaVelha[2, 2] = "X";

            Console.WriteLine($" {jogoDaVelha[0, 0]} | {jogoDaVelha[0, 1]} | {jogoDaVelha[0, 2]}");
            Console.WriteLine($" {jogoDaVelha[1, 0]} | {jogoDaVelha[1, 1]} | {jogoDaVelha[1, 2]}");
            Console.WriteLine($" {jogoDaVelha[2, 0]} | {jogoDaVelha[2, 1]} | {jogoDaVelha[2, 2]}");

            Console.WriteLine("");

            PressioneQualquerTecla();
        }


        private static void Interfaces()
        {
            Cabecalho("Interfaces");
            Console.WriteLine("Instanciando classe Avião.");
            var aviao = new Aviao();
            Console.WriteLine("");
            MostraComoAeronavesFazem(aviao);
            Console.WriteLine("");
            Console.WriteLine("Instanciando classe Helicóptero.");
            var helicoptero = new Helicoptero();
            Console.WriteLine("");
            MostraComoAeronavesFazem(helicoptero);
            PressioneQualquerTecla();
        }

        private static void MostraComoAeronavesFazem(IAeronave aeroNave)
        {
            Console.WriteLine("Para mostrar o que a aeronave faz não preciso da classe, apenas da interface. Conheço a abstração isso já é suficiente.");
            Console.WriteLine("");
            Console.WriteLine($"Nome da Aeronave {aeroNave.Nome}");
            aeroNave.Decolar();
            Console.WriteLine("");
            aeroNave.Pousar();
        }

        private static void ClassesEObjects()
        {
            Cabecalho("Comportamento do Tipo Por Referência - Class(Produto)");
            var produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Descricao = "Coca-Cola 2L Gelada";
            produto1.Preco = 5.75m;
            produto1.Quantidade = 5;
            produto1.CalcularTotal();
            
            Console.WriteLine($"[Antes de Criar ''produto2''] Variável ''produto1'' {produto1}");
            Console.WriteLine("");

            Produto produto2 = produto1;
            produto2.Quantidade = 10;
            produto2.CalcularTotal();

            Console.WriteLine($"[Depois de Criar ''produto2''] Variável ''produto2'' {produto2}");
            Console.WriteLine($"[Depois de Criar ''produto2''] Variável ''produto1'' {produto1}");

            Console.WriteLine("");
            Console.WriteLine("Métodos do Object");

            Console.WriteLine(produto1.ToString());
            Console.WriteLine($"{produto1.GetHashCode()}");
            Console.WriteLine($"{produto1.GetType()}");

            Console.WriteLine("");
            Console.WriteLine("Comparando Referências");

            var produto3 = new Produto();
            produto3.Codigo = 1;
            produto3.Descricao = "Coca-Cola 2L Gelada";
            produto3.Preco = 5.75m;
            produto3.Quantidade = 10;
            produto3.CalcularTotal();

            Console.WriteLine("Repare que os dados do ''produto1'' é exatamente igual ao ''produto3'' ");
            Console.WriteLine($"Variável ''produto1'' {produto1}");
            Console.WriteLine($"Variável ''produto3'' {produto3}");
            Console.WriteLine("Porém ''produto1'' e ''produto3'' não tem a referência ao mesmo objeto armazenado na Heap!");
            Console.WriteLine("");
            Console.WriteLine($"''produto1'' tem a mesma referêcia de ''produto3''? =>{Object.ReferenceEquals(produto1, produto3)}");
            Console.WriteLine("");
            Console.WriteLine($"Embora ''produto1'' e ''produto3'' sejam exatamente iguais. É verdade isso? {produto1.Equals(produto3)}");
            Console.WriteLine("");
            Console.WriteLine("Mas ''produto1'' e ''produto2'' fazem referencia ao mesmo objeto na Heap!");
            Console.WriteLine($"''produto1'' tem a mesma referêcia de ''produto2''? =>{Object.ReferenceEquals(produto1, produto2)}");


            Console.WriteLine("");
            Console.WriteLine("Atribuindo Null");
            produto1 = null;
            try
            {
                Console.WriteLine(produto2.Descricao);
                Console.WriteLine(produto1.Descricao);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Destruimos o conteúdo de ''produto1'' ela não tem mais referência! Não podemos mais acessar seus valores.");
            }


            PressioneQualquerTecla();
        }

        #endregion
    }
}
