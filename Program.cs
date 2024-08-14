#region Atividades

#region Exercicio 1

Console.WriteLine("Digite um número inteiro: ");
int valor = Convert.ToInt32(Console.ReadLine());

if (valor > 10){
    Console.WriteLine("Número digitado Maior que 10");
}
else{
    Console.WriteLine("Número digitado Menor ou igual a 10");
}

#endregion

#region Exercicio 2

Console.WriteLine("Digite o primeiro valor: ");
int valor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int valor2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A soma dos valores digitados é: " + (valor1+valor2));

#endregion

#region Exercicio 3

Console.WriteLine("Digite o primeiro valor: ");
int valor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int valor2 = Convert.ToInt32(Console.ReadLine());

if (valor1 > valor2) {
    Console.WriteLine($"Primeiro valor ({valor1}) é maior que o Segundo ({valor2})");
}
else if (valor1 < valor2) {
    Console.WriteLine($"Primeiro valor ({valor1}) é menor que o Segundo ({valor2})");
}
else {
    Console.WriteLine("Valores inválidos");
}

#endregion

#region  Exercicio 4

Console.WriteLine("Digite o primeiro valor: ");
int valor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int valor2 = Convert.ToInt32(Console.ReadLine());

int sum = valor1 + valor2;
int sub = valor1 - valor2;
int mult = valor1 * valor2;
double div = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
Console.WriteLine($"{valor1} + {valor2} = {sum}");
Console.WriteLine($"{valor1} - {valor2} = {sub}");
Console.WriteLine($"{valor1} * {valor2} = {mult}");
Console.WriteLine($"{valor1} / {valor2} = {div}");

#endregion

#region Exercicio 5

Console.WriteLine("Digite o primeiro valor: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Valor A: {a} \nValor B: {b}");
int temp = a;
a = b;
b = temp;
Console.Write($"\nValor A: {a} \nValor B: {b}");

#endregion

#endregion