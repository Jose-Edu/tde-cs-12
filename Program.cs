var empresa = new Empresa();

var func1 = new Funcionario("Carlos", 30);
var gerente = new Gerente("Ana", 40, 2000);
var estagiario = new Estagiario("Pedro", 20);

empresa.AdicionarFuncionario(func1);
empresa.AdicionarFuncionario(gerente);
empresa.AdicionarFuncionario(estagiario);

empresa.ListarFuncionarios();