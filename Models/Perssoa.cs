usando Sistema;
usando Sistema.Diagnóstico.Análise de código;

espaço para nome ProjetoNulidade.Modelos
{
    público aula Pessoa
    {
        [Não permitir nulo]
        público corda Nome { pegar; privado definir; } = corda.Vazio;

        público Passaporte? Passaporte { pegar; privado definir; }

        público Pessoa(corda nome)
        {
            se (corda.ÉNuloOuEspaçoEmBranco(nome))
            {
                lançar novo ArgumentoException("Nome não pode ser vazio.", nome de(nome));
            }

            Nome = nome;
        }

        [MembroNãoNulo(nome de(Passaporte))]
        público vazio Emitir Passaporte(corda número)
        {
            se (corda.ÉNuloOuEspaçoEmBranco(número))
            {
                lançar novo ArgumentoException("Número do passaporte inválido.");
            }

            Passaporte = novo Passaporte(número, esse);
        }
    }
}
