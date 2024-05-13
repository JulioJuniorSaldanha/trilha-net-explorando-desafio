namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
           
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
                Console.WriteLine("Hospedes cadastrados com sucesso!!!");
            }
            else
            {
                //Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
               throw new Exception($"O numero de hospedes n~ao pode exceder a capacidade da suite, por favor selecione uma suite com {hospedes.Count.ToString()} ou mais acomodaçoes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            //Retorna o valor da diária
            //Cálculo: DiasReservados X Suite.ValorDiaria
            
            decimal valor = Suite.ValorDiaria * DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
           // if (DiasReservados >= 10)
           // {
           //     valor = valor - (valor * (decimal)0.1);
           // }

            decimal maiordez = DiasReservados >=10 ? valor = valor - (valor * (decimal)0.1) : valor;
            
            return valor;
        }
    }
}