//Primeiro, declaram-se as variáveis
string N, S;

//Pedimos ao usuário para inserir o valor (nome)
Console.WriteLine("Ur first Name");
//Declaramos a variável a qual vai ser atribuído o valor
N = Console.ReadLine();

//Mesma coisa, agora para segunda variável (sobrenome)
Console.WriteLine("Now your last name");
//Atribuindo o valor inserido
S = Console.ReadLine();

//Imprimindo o resultado do conteudo inserido
Console.WriteLine("{0} {1}", N, S);
// O 0 e 1 entre chaves são necessários para indicar a ordem da exibição das duas variáveis, sendo 0 o primeiro