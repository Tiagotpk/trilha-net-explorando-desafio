using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Maria Sebastiana");
Pessoa p2 = new Pessoa(nome: "José Maria Sebastião");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);



// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("RESERVA EFETUADA COM SUCESSO");
Console.WriteLine($"Qtde Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.Write("Hóspedes: ");
foreach (Pessoa hospede in hospedes)
{
    Console.WriteLine($"{hospede.NomeCompleto} ");
}
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Suíte: {suite.TipoSuite}");