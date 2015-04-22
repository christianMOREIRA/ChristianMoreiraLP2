using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Lista1
    {
        static void Main(string[] args)
        {
            int i = 0;
            string exercicio;
            Console.WriteLine("Qual o exercicio ?");
            exercicio = Console.ReadLine();
            while (i != 1)
         {
            if (exercicio == "1")
            {
                exercicio1();
            }
            else if (exercicio == "2")
            {
                exercicio2();
            }
            else if (exercicio == "3")
            {
                exercicio3();
            }
            else if (exercicio == "4")
            {
                exercicio4();
            }
            else if (exercicio == "5")
            {
                exercicio5();
            }
            else if (exercicio == "6")
            {
                exercicio6();
            }
            else if (exercicio == "7")
            {
                exercicio7();
            }
            else if (exercicio == "8")
            {
                exercicio8();
            }
            else 
            {
                Console.WriteLine("Exercicio inválido!");
                i = 1;
            }
        }
        }



        static void exercicio1()
        {
            int n = 0;
            int fatorial = 1;
            Console.WriteLine("Digite um número :");
            n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine("O fatorial de {0}! é:  {1} ",n  , fatorial);
        }



        static void exercicio2()
        {
            double fator = 1;
            double n = 0;
            double resultado = 0;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    resultado += i / fator;
                    Console.WriteLine("-{0}! / {1} ", i, fator);

                }
                else
                {
                    resultado += i / fator;
                    Console.WriteLine("{0}! / {1} ", i, fator);

                }
                fator = fator * 2 + 1;
            }
            Console.WriteLine("O reultado é: {0}", resultado);
        }

        static void exercicio3()
        {
            int num = 1;
            Console.WriteLine("Qual o número de fúncionarios ?");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {


                string[] funcionario = new string[n];
                int[] salario = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Digite o nome do {0} funcionário: ", num);
                    funcionario[i] = Console.ReadLine();
                    Console.WriteLine("Digite o salário do(a) {0} : ", funcionario[i]);
                    salario[i] = int.Parse(Console.ReadLine());
                    num++;
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Funcionário {0}", funcionario[j]);
                    Console.WriteLine(" :   O salário atual é de {0}", salario[j]);
                    if (salario[j] < 3000)
                    {
                        salario[j] = salario[j] + salario[j] / 4;
                        Console.WriteLine("O salário com ajuste do(a) {0} será de: {1}", funcionario[j], salario[j]);
                        Console.WriteLine();

                    }
                    else if (salario[j] > 2999 && salario[j] < 4000)
	                {
                        salario[j] = salario[j] + salario[j] / 5;
                        Console.WriteLine("O salário com ajuste do(a) {0} será de:  {1}", funcionario[j], salario[j]);
                        Console.WriteLine();
	                }
                    else if (salario[j] > 3999 && salario[j] < 5000)
                    {
                        salario[j] = salario[j] + salario[j] * 15/100;
                        Console.WriteLine("O salário com ajuste do(a) {0} será de:  {1}", funcionario[j], salario[j]);
                        Console.WriteLine();
                    }

                    else

                    {
                        salario[j] = salario[j] + salario[j] / 10;
                        Console.WriteLine("O salário com ajuste do(a) {0} será de:  {1}", funcionario[j], salario[j]);
                        Console.WriteLine();
                    }


                }

            }
            else
            {
                Console.WriteLine("Número de funcionário inexistente");
            }
        }



        static void exercicio4()
        {
            int jogador1 = 0;
            int jogador2 = 0;
            int campeao = 0;
            int vice = 0;  

            while (campeao < 21)
            {
                Console.WriteLine("qual jogador fez ponto ? 1 ou 2 ");
                string ponto = Console.ReadLine();

                if (ponto == "1")
                {
                    jogador1++;
                }
                else if (ponto == "2")
	            {
                    jogador2++;
	            }
             if (jogador1 > jogador2)
             {
                 campeao = jogador1;
                 vice = jogador2;
             }
             if (jogador2 > jogador1)
             {
                 campeao = jogador2;
                 vice = jogador2;
             }
            }
            while (campeao < vice + 2)
            {
                Console.WriteLine("qual jogador fez ponto ? 1 ou 2 ");
                string ponto = Console.ReadLine();

                if (ponto == "1")
                {
                    jogador1++;
                }
                else if (ponto == "2")
                {
                    jogador2++;
                }
                if (jogador1 > jogador2)
                {
                    campeao = jogador1;
                    vice = jogador2;
                }
                if (jogador2 > jogador1)
                {
                    campeao = jogador2;
                    vice = jogador2;
                }
            }



            if (jogador1 > jogador2 + 1)
            {
                Console.WriteLine("O jogador1 venceu a partida, com o placar de: {0} x {1}", jogador1 , jogador2);
            }
            else if (jogador2 > jogador1 + 1)
            {
                Console.WriteLine("O jogador2 venceu a partida, com o placar de: {0} x {1}", jogador2 , jogador1);
            }
            
        }


        static void exercicio5()
          {
            double distancia = 600;
            double litros = 50;
            double percorrida = 0;
            double lgastos = 0;
                while (distancia > percorrida)
                {

                Console.WriteLine("Digite a distancia percorrida desde a ultima medição");
                percorrida += double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos litros foram gastos");
                lgastos += double.Parse(Console.ReadLine());

                    if (lgastos > litros)
                {
                    Console.WriteLine("O carro parou antes de cheguar ao destino.");
                    percorrida = 601;
                }

                }


                 if(lgastos <= litros)
	          {
                Console.WriteLine("O carro chegou ao seu destino.");
	          }

          }




        static void exercicio6()  //Não consegui terminar
        {
            ArrayList nome = new ArrayList();
            ArrayList altura = new ArrayList();
            int cm = 0;
            int maior = 1;
            int posicao = 0;
            int posicao2 = 0;
            int maior2 = 0;
            int count = 0;
            int count2 = 0;
            int mudar = 0;
            int i = 0;
            int parar = 999999;
            while(i != parar)
            {
                i++;
                int k = 0;
                Console.WriteLine("Digite o nome: (digite fim para terminar)");
                string fim = Console.ReadLine();
                if (fim == "fim")
                {
                    i = parar;
                }
                else
                {
                    nome.Add(fim);
                    Console.WriteLine("Digite a altura da {0} em centímetros: ", fim);
                    cm = int.Parse(Console.ReadLine());
                    altura.Add(cm);


                    if (cm > maior)
                    {
                        mudar = maior;
                        maior = cm;
                        posicao = k;
                        cm = mudar;
                        count = 1;
                        
                    }
                    if (cm > maior2 && cm < maior )
                    {
                        maior2 = cm;
                        posicao2 = k;
                        count2 = 1;
                        
                    }
                    if (cm == maior)
                    {
                        count++;
                    }
                    else if (cm == maior2)
                    {
                        count2++;
                    }
                    k++;
                }
            }
            if (nome.Count > 0)
                Console.WriteLine("As duas maiores alturas são {0} e {1} ; que apareceram em {2} e {3} mulheres respectivamente.", altura[posicao], altura[maior2], count, count2);
            else
                Console.WriteLine("Você não digitou nenhum nome: ");
        }



        static void exercicio7()
        {
            ArrayList nadadores = new ArrayList();
            ArrayList ClacificacaoNadador = new ArrayList();
            ArrayList TmpDosNadadores = new ArrayList();
            ArrayList ClubDosNadadores = new ArrayList();
            int[] PntsClubeProvas = new int[2] { 0, 0 };
            int[] PntsClubeCompeticao = new int[2] { 0, 0 };
            int NumDaProva = 0;
            int QntDeNadadores = 0;
            double[] LgrTempo = new double[4] { 0, 0, 0, 0 };
            string[] LgrsClub = new string[4] { "", "", "", "" };
            

            while (NumDaProva != 9999 || QntDeNadadores != 0)
            {
                Console.WriteLine("Informe o número da prova: ");
                NumDaProva = int.Parse(Console.ReadLine());

                Console.WriteLine("Irforme a quandidade de nadadores que participaram: ");
                QntDeNadadores = int.Parse(Console.ReadLine());

                if (QntDeNadadores != 0 || NumDaProva != 9999  )
                {

                    for (int i = 0; i < QntDeNadadores; i++)
                    {
                        Console.WriteLine("Informe o nome do {0}° nadador: ", i + 1);
                        nadadores.Add(Console.ReadLine());

                        Console.WriteLine("Informe a classificação dele: ");
                        ClacificacaoNadador.Add(Console.ReadLine());

                        Console.WriteLine("Informe o tempo (em segundos): ");
                        TmpDosNadadores.Add(double.Parse(Console.ReadLine()));

                        Console.WriteLine("Informe qual o clube  dele: ");
                        ClubDosNadadores.Add(Console.ReadLine().ToUpper());

                    }

                    int I = 0;

                    foreach (double tempo in TmpDosNadadores)
                    {
                        if (tempo < LgrTempo[0] || I == 0)
                        {
                            LgrTempo[3] = LgrTempo[2];
                            LgrTempo[2] = LgrTempo[1];
                            LgrTempo[1] = LgrTempo[0];
                            LgrTempo[0] = tempo;

                            LgrsClub[3] = LgrsClub[2];
                            LgrsClub[2] = LgrsClub[1];
                            LgrsClub[1] = LgrsClub[0];
                            LgrsClub[0] = ClubDosNadadores[I].ToString();
                        }

                        else if (tempo < LgrTempo[1] || I == 1)
                        {
                            LgrTempo[3] = LgrTempo[2];
                            LgrTempo[2] = LgrTempo[1];
                            LgrTempo[1] = tempo;

                            LgrsClub[3] = LgrsClub[2];
                            LgrsClub[2] = LgrsClub[1];
                            LgrsClub[1] = ClubDosNadadores[I].ToString();
                        }

                        else if (tempo < LgrTempo[2] || I == 2)
                        {
                            LgrTempo[3] = LgrTempo[2];
                            LgrTempo[2] = tempo;

                            LgrsClub[3] = LgrsClub[2];
                            LgrsClub[2] = ClubDosNadadores[I].ToString();
                        }

                        else if (tempo < LgrTempo[3] || I == 3)
                        {
                            LgrTempo[3] = tempo;

                            LgrsClub[3] = ClubDosNadadores[I].ToString();
                        }
                        I++;
                    }

                    I = 0;
                    foreach (string clube in LgrsClub)
                    {
                        if (clube == "A")
                        {
                            if (I == 0)
                            {
                                PntsClubeProvas[0] += 9;
                                PntsClubeCompeticao[0] += 9;
                            }

                            else if (I == 1)
                            {
                                PntsClubeProvas[0] += 6;
                                PntsClubeCompeticao[0] += 6;
                            }

                            else if (I == 2)
                            {
                                PntsClubeProvas[0] += 4;
                                PntsClubeCompeticao[0] += 4;
                            }

                            else
                            {
                                PntsClubeProvas[0] += 3;
                                PntsClubeCompeticao[0] += 3;
                            }
                        }

                        else if (clube == "B")
                        {
                            if (I == 0)
                            {
                                PntsClubeProvas[1] += 9;
                                PntsClubeCompeticao[1] += 9;
                            }

                            else if (I == 1)
                            {
                                PntsClubeProvas[1] += 6;
                                PntsClubeCompeticao[1] += 6;
                            }

                            else if (I == 2)
                            {
                                PntsClubeProvas[1] += 4;
                                PntsClubeCompeticao[1] += 4;
                            }

                            else
                            {
                                PntsClubeProvas[1] += 3;
                                PntsClubeCompeticao[1] += 3;
                            }
                        }

                        I++;
                    }

                    Console.WriteLine("Na prova: {0} , o clube A ganhou: {1} pontos e o clube B ganhou: {2} pontos", NumDaProva, PntsClubeProvas[0], PntsClubeProvas[1]);
                }
            }

            if (PntsClubeCompeticao[0] > PntsClubeCompeticao[1])
            {
                Console.WriteLine("O clube A ganhou.");
            }

            else if (PntsClubeCompeticao[1] > PntsClubeCompeticao[0])
            {
                Console.WriteLine("O clube B ganhou.");
            }

            else
            {
                Console.WriteLine("Os times empataram.");
            }

        }

        static void exercicio8()
        {
            int n = 0;
            int resultado = 0;
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                resultado += i;
            }
            Console.WriteLine("O valor da soma de todos os inteiros entre 1 e {0} é = {1}", n, resultado);

        }
            
  }

 }


