<h1 align="center"> Sistema para Colaboradores Baterem Ponto na Empresa</h1>
<br>
Sistema desenvolvido com o intuito de criar uma solução para funcionarios baterem ponto comercial na empresa, juntamente com o cálculo de horas e pagamento.
<hr>
✔️ Técnicas e Tecnologias utilizadas:

- ``C# 11``
- ``CQRS``
- ``Paradigma de Orientação a Objetos``
- ``.Net Core 6.0``
- ``PostgresSQL 14``
- ``FluentValidation``
- ``MediatR``
- ``Dapper``
- ``Swagger`` 

✔️ Estrutura do Projeto:

![estrutura](https://user-images.githubusercontent.com/99502227/196015151-a1660fc7-b15b-4032-956d-3ba4c20c279e.png)

- ``API`` - Cuida da entrada e disponibilização de dados através dos Controllers
- ``Application`` - Cuida da formatação dos dados, fazendo conversões quando necessário
- ``Domain`` - Mantém os objetos e enumeradores do projeto
- ``Infra`` - Cuida da ligação com a base de dados e dos serviços do projeto

✔️ Funções do sistema:

![endpoints](https://user-images.githubusercontent.com/99502227/196016251-26fe77d8-6f9f-4734-a7aa-2d3fa651e9e9.png)

- ``Post - CadasdroFuncionario`` - Adiciona um novo funcionário
- ``Patch - AtualizarNome`` - Atualiza o nome do funcionário
- ``Patch - AtualizarDataFimContratacao`` - Atualiza o data de término da contratação do funcionário (ocasiona sua demissão), no momento do cadastro, é marcada como nula
- ``Patch - MudarCargoFuncionario`` - Realiza a mudança de cargo de um funcionário já cadastrado
- ``Post - AdicionarCargo`` - Adiciona um cargo, sem um funcionário ligado ao mesmo
- ``Patch - AtualizarNomeCargo`` - Atualiza o nome do cargo
- ``Patch - AtualizarCargaHoraria`` - Atualiza a carga horária de determinado cargo
- ``Patch - AtualizarValorHora`` - Atualiza o valor da hora de determinado cargo
- ``Patch - AtualizarEstadoDoCargo`` - Define se um cargo está disponível ou não. Caso esteja desativado, não é possível adicionar funcionários a eles e também não é permitido desativar um cargo que tenha funcionários nele

<br>:construction: Projeto em construção :construction:
