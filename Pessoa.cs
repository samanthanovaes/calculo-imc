
using System;

public class Pessoa
{
    private string nome;
    private string cpf;
    private string sexo;
    private double peso;
    private double idade;
    private double altura;
    public Pessoa(string nome, string cpf, string sexo, double peso, double idade, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.sexo = sexo;
        this.peso = peso;
        this.idade = idade;
        this.altura = altura;
    }

    public (double, string, string) CalcularIMC()
    {
        double calculo = peso / (Math.Pow(altura, 2));

        if (calculo < 18.5)
        {
            return (calculo, "Magreza", "0");
        }
        else if (calculo >= 18.5 && calculo < 25 )
        {
            return (calculo, "Normal", "0");
        }
        else if (calculo >= 25 && calculo < 30 )
        {
            return (calculo, "Sobrepeso", "I");
        }
        else if (calculo >= 30 && calculo < 40)
        {
            return (calculo, "Obesidade", "II");
        }
        else if (calculo >= 40)
        {
            return (calculo, "Obesidade grave", "III");
        }
        else
        {
            return (0.00, "Erro ao imprimir", "Erro ao imprimir");
        }
    }
    public string GetNome ()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome; 
    }
    public string GetCpf()
    {
        return this.cpf;
    }
    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public string GetSexo()
    {
        return this.sexo;
    }
    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }
    public double GetIdade()
    {
        return this.idade;
    }
    public void SetIdade(double idade)
    {
        this.idade = idade;
    }
    public double GetPeso()
    {
        return this.peso;
    }
    public void SetPeso(double peso)
    {
        this.peso = peso;
    }
    public double GetAltura()
    {
        return this.altura;
    }
    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

}