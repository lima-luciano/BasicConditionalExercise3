//19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua média e mostre na tela. No final, analise a média e mostre se o aluno teve ou não um bom aproveitamento (se ficou acima da média 7.0).
Console.WriteLine("Para saber a média do aluno digite a primeira nota:");
double note1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
double note2 = double.Parse(Console.ReadLine());

double avarage = (note1 + note2) / 2;

if (avarage > 7.0)
{
    Console.WriteLine($"A média do aluno foi de {avarage.ToString("F2")}. Está acima da média, foi um bom aproveitamento!");
}
else
{
    Console.WriteLine($"A média do aluno foi de {avarage.ToString("F2")}. Está abaixo da média.");
}