usando Sistema;
usando Sistema.Diagnóstico.Análise de código;
usando ProjetoNulidade.Modelos;

espaço para nome ProjetoNulidade.Serviços
{
    público aula Serviço de Usuário
    {
        público bool TentarObterUsuárioPorEmail(corda? e-mail, [Não Nulo Quando(verdadeiro)] fora Pessoa? pessoa)
        {
            se (corda.ÉNuloOuEspaçoEmBranco(e-mail))
            {
                pessoa = nulo;
                retornar falso;
            }

            // Simulação: usuário encontrado se o e-mail contém "utfpr"
            se (e-mail.Contém("utfpr"))
            {
                pessoa = novo Pessoa("Aluno UTFPR");
                retornar verdadeiro;
            }

            pessoa = nulo;
            retornar falso;
        }
    }
}
