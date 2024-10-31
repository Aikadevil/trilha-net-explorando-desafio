namespace DesafioProjetoHospedagem.Reserva;
using DesafioProjetoHospedagem.Pessoa;
using DesafioProjetoHospedagem.Suite;


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
            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A número de hóspedes deve ser menor ou igual que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return(Hospedes.Count);
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = 0;
                decimal desconto = 0.1M;
                valor = (DiasReservados * Suite.ValorDiaria)-((DiasReservados * Suite.ValorDiaria)*desconto);
            }

            return valor;
        }
    }
