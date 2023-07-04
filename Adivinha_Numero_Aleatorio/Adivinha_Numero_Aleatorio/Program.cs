// See https://aka.ms/new-console-template for more information
/*
 Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário 
deve adivinhar qual é esse número. 
O programa utiliza o if-else e switch case para verificar se o número 
digitado pelo usuário é maior ou menor 
do que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while 
para permitir que o usuário faça várias tentativas até acertar o número. 
Quando o usuário acertar o número, o jogo acaba e o programa exibe 
uma mensagem indicando que o jogo acabou.
 */

int respostaUsuario = 0;
int numeroAleatorio = new Random().Next(1,100);

Console.WriteLine("------\n" + numeroAleatorio + "\n------");

Console.WriteLine("Adivinha qual é o numero??");
respostaUsuario = int.Parse(Console.ReadLine());



if (respostaUsuario > 0 && respostaUsuario < 100)
{
    if (numeroAleatorio == respostaUsuario)
    {
        Console.WriteLine("Você acertou!");
    }
}
else
{
    Console.WriteLine("Numero inválido! \nInsira um numero entre 1 a 100");
}




