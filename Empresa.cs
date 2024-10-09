public class Empresa {

    private List<Funcionario> funcionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario) {

        funcionarios.Add(funcionario);

    }

    public void ListarFuncionarios() {

        foreach(var funcionario in funcionarios) {

            Console.WriteLine($"Nome: {funcionario.Nome}, Salário: {funcionario.CalcularSalario().ToString("C")}, Idade: {funcionario.Idade}");

        }

    }

}