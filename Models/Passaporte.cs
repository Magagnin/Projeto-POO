usando Sistema;
usando Sistema.Diagnóstico.Análise de código;

espaço para nome ProjetoNulidade.Modelos
{
    público aula Passaporte
    {
        [Não permitir nulo]
        público corda Número { pegar; privado definir; } = corda.Vazio;

        [Não Nulo]
        público Pessoa Proprietário { pegar; }

        público Passaporte(corda número, [Não Nulo] Pessoa proprietário)
        {
            se (corda.ÉNuloOuEspaçoEmBranco(número))
            {
                lançar novo ArgumentoException("Número do passaporte inválido.");
            }
            Número = número;
            Proprietário = proprietário ?? lançar novo ArgumentoNullException(nome de(proprietário));
        }
    }
}
