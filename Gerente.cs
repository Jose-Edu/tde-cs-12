public class Gerente:Funcionario {
    public Gerente(string nome, int idade, double bonus) : base(nome, idade)
    {
        Nome = nome;
        Idade = idade;
        Bonus = bonus;
    }

    public double Bonus { get; set; }

    public override double CalcularSalario() {

        return base.CalcularSalario()+Bonus;

    }

}