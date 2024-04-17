namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
             
            if (Suite.Capacidade >=hospedes.Count )
            {
                Hospedes = hospedes;
            }

            else
            {
                throw new Exception("A capacidade hospedes � menor que o numero recebido"); 
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            
            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 10M / 100M;

                return valor - desconto;
            }

            return valor;
        }
    }
}