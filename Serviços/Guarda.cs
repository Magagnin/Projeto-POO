usando Sistema;
usando Sistema.Diagnóstico.Análise de código;

espaço para nome ProjetoNulidade.Serviços
{
    público estático aula Guarda
    {
        público estático vazio Contra Nulo<T>([Não Nulo] referência T? valor, corda paramName)
        {
            se (valor é nulo)
            {
                lançar novo ArgumentoNullException(paramName);
            }
        }
    }
}
