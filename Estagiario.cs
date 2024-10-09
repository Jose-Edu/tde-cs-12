public class Estagiario : Funcionario {

    public Estagiario(string nome, int idade) : base(nome, idade) {

        Nome = nome;
        Idade = idade;

    }

    public override double CalcularSalario() {

        return base.CalcularSalario()/2;

    }

}