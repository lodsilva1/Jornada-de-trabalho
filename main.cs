using System;

class Program {
  public static void Main (string[] args) {
    
Double salario_hora, horas_trabalhadas, horas_extras, salario_hora_extra,salario_extra, salario_final;
String entrada; 
    
Console.WriteLine("Horas trabalhadas no mês: ");
entrada = Console.ReadLine ();
    horas_trabalhadas = Double.Parse(entrada);
    
Console.WriteLine("Salário por hora de trabalho: ");
entrada = Console.ReadLine ();
    salario_hora = Double.Parse(entrada);

horas_extras = horas_trabalhadas - 160.0;
 
salario_hora_extra = salario_hora * 1.5;


salario_extra = salario_hora_extra * horas_extras;

salario_final = (salario_hora_extra * horas_extras) + (160.0 * salario_hora);

Console.WriteLine ("Salário : " + 160.0*salario_hora);
Console.WriteLine ("Salário das horas extras : " +salario_extra);
Console.WriteLine ("Salário final : "+salario_final);
    
  }
}