# Conversor-KM-Anos-Luz
 Este projeto simples é uma API RESTful desenvolvida em ASP.NET Core para converter distâncias de quilômetros para anos-luz e vice-versa.

## Pré-requisitos
 - .NET SDK instalado
 - Visual Studio Code ou outro editor de código de sua escolha

## Estrutura do Projeto

 - `Controllers/`: Contém os controladores da API para manipular requisições HTTP.
 - `Models/`: Contém os modelos de dados utilizados na aplicação.
 - `Services/`: Contém a lógica de negócio para realizar as conversões.
 - `Startup.cs`: Arquivo de configuração do ASP.NET Core.

## Configuração do Projeto
1. Clone o repositório:
   ```bash
    git clone https://github.com/seu-usuario/conversor-km-anos-luz.git
   ```
2. Navague até o diretório do projeto:
     ```bash
    cd conversor-km-anos-luz
   ```
3. Restaure as dependências:
     ```bash
    dotnet restore
   ```

## Executando o projeto

 Para iniciar o servidor de desenvolvimento, execute o seguinte comando:
   ```bash
    dotnet run
   ```
 A API estará disponível em:

 - Localhost: http://localhost:5104 (HTTP)
 - Localhost: http://localhost:5104 (HTTP)

## Endpoints

### 1. Conversão de Quilômetros para Anos-luz
- Endpoint: '/netcon/api/v1/converter/km'
- Método HTPP: Get
- Parâmetros:
    - 'anosLuz(número)': Disntância em anos-luz para ser convertida em KM.
- Exemplo:
   ```bash
    GET http://localhost:5104/netcon/api/v1/converter/km?anosLuz=23123
   ```
- Resposta 
    ```json
    {
    "statusCode": 200,
    "errorMessage": null,
    "dateTime": "2023-10-29T09:56:28.62268-03:00",
    "value": 2.187667E+17
    }
   ```

### 2. Conversão de Anos-Luz para quilômetros
- Endpoint: '/netcon/api/v1/converter/anos-Luz'
- Método HTPP: Get
- Parâmetros:
    - 'km(número)': Disntância em km para ser convertida em Anos-Luz.
- Exemplo:
   ```bash
    GET  http://localhost:5104/netcon/api/v1/converter/anos-Luz?km=10
   ```
- Resposta 
    ```json
    {
    "statusCode": 200,
    "errorMessage": null,
    "dateTime": "2023-10-29T10:16:52.1299739-03:00",
    "value": 1.0569707E-12
    }
   ```

## Contribuir
    Sinta-se à vontade para contribuir para este projeto! Se encontrar problemas ou tiver sugestões, por favor, abra uma issue ou envie um pull request.



 
