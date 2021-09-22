namespace SOLID.SRP.Solucao
{
    public interface ICadastroCliente:ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}