﻿//Primeiro, declaram-se as variáveis

//String é o tipo da variável
string Nome, Sobrenome;

//Pedimos ao usuário para inserir o valor (nome)
Console.WriteLine("Insira seu primeiro nome");
//Declaramos a variável a qual vai ser atribuído o valor
Nome = Console.ReadLine();

//Mesma coisa, agora para segunda variável (sobrenome)
Console.WriteLine("Agora insira seu sobrenome");
//Atribuindo o valor inserido
Sobrenome = Console.ReadLine();

//Imprimindo o resultado do conteudo inserido
Console.Write("{0} {1}", Nome, Sobrenome);
// O 0 e 1 entre chaves são necessários para indicar a ordem da exibição das duas variáveis, sendo 0 o primeiro

// Para rodar o algoritmo, escrever no console o comando dotnet run