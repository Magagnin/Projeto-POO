#habilitar anulável
usando Sistema;
usando ProjetoNulidade.Modelos;
usando ProjetoNulidade.Serviços;

espaço para nome ProjetoNulidade
{
    interno aula Programa
    {
        estático vazio Principal(corda[] argumentos)
        {
            Console.WriteLine("=== Demonstração de Contratos de Nulidade ===\n");

            var serviço de usuário = novo Serviço de Usuário();

            se (serviço de usuário.TentarObterUsuárioPorEmail("aluno@utfpr.edu.br", fora var pessoa))
            {
                Console.WriteLine($"Usuário encontrado: {pessoa.Nome}");

                pessoa.EmitirPassaporte("BR123456");
                Console.WriteLine($"Passaporte emitido: {pessoa.Passaporte?.Número}");
            }
            outro
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
    }
}
