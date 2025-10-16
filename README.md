🧩 Projeto: Contratos de Nulidade com Atributos em C#

Este projeto tem como objetivo demonstrar o uso de atributos de nulidade em C#, conforme o material apresentado pelo professor Everton Foz.

🎯 Conceitos Demonstrados

O projeto aborda os principais conceitos relacionados à verificação e controle de nulidade em C#, incluindo:

Tipos nuláveis e não nuláveis: T? e T

Atributos de nulidade:

[NotNull]

[NotNullWhen(true)]

[MemberNotNull]

[DisallowNull]

[AllowNull]

Associações entre classes: 0..1 e 1..1

Guardas e lançamento de exceções

Contratos de nulidade (nullability contracts)

🏗️ Estrutura do Projeto
ProjetoNulidade/
├── Models/
│   ├── Person.cs
│   ├── Passport.cs
├── Services/
│   ├── Guard.cs
│   ├── UserService.cs
└── Program.cs

▶️ Execução

Para compilar e executar o projeto, utilize o .NET CLI:

dotnet new console -n ProjetoNulidade
dotnet run

👨‍💻 Informações

Autor: Gustavo Henrique Magagnin Silva

Professor: Everton 

Disciplina: Programação Orientada a Objetos

Instituição: UTFPR
