namespace Aula30082022.Models.ViewModel
{
    public class ValoresCalculadora
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public Operacoes Operacao { get; set; }
        public decimal? resultado { get; set; }
    }
    public enum Operacoes : int
    {
        Soma = 1,
        Subtracao = 2,
        Multiplicacao = 3,
        Divisao = 4
    }
}
