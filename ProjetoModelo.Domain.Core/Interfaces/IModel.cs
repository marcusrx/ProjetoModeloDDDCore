namespace ProjetoModelo.Domain.Core.Interfaces
{

    //essa interface apenas as entidades do modelo devem implementa-la
    public interface IModel<T> where T : class
    {
        //colocar os metodos que todas entidades devem implementar como a obtencao de validadores por exemplo, uteis no momento das insercoes, atualizacoes e exclusoes e etc...
        //Validador<TEntidade> ObterValidador(ContextoValidacao contextoValidacao);
    }
}
