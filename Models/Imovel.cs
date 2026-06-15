namespace Aula_API_3.Models
{
   public class Imovel
{
    public string Endereco { get; set; }
    public double Valor { get; set; }

    public void AplicarDesconto(double porcentagem)
    {
        Valor -= Valor * (porcentagem / 100);
    }
}
}