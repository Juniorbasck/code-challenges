# explicações técnicas

A solução foi desenvolvida utilizando **C# (.NET 8)** com foco em simplicidade, desacoplamento e testabilidade.

### Arquitetura
O projeto segue o princípio de separation of concerns 

* **Domain (`Portfolio`):** Contém toda a lógica de negócio.
* **Services (`CapitalGainsService`):** Responsável pela orquestração. 
* **Application (`Application`):** Camada de Entrada/Saída. Abstrai a leitura do `Stdin` e escrita no `Stdout`, permitindo que o loop principal seja testado unitariamente sem depender do Console do sistema operacional.

## 📚 Bibliotecas e Frameworks

O projeto priorizou o uso de recursos nativos do .NET 

* **`System.Text.Json`:** Escolhida por ser a biblioteca nativa do .NET, oferecendo alta performance e baixo consumo de memória para serialização/deserialização, eliminando a necessidade do `Newtonsoft.Json`.
* **`xUnit`:** Framework de testes padrão de mercado no ecossistema .NET, utilizado para testes unitários e de integração.
* **Docker:** Utilizado para containerização da aplicação

### Como Compilar e Executar

A solução está containerizada. Para rodar utilizando o arquivo de entrada padrão:

1. **Buildar a imagem:**
   ```bash
   docker build -t capital-gains .
   ```

2. **Executar (Redirecionando Input):**
   ```bash
   docker run -i capital-gains < input.txt
   ```  

### Como Executar os Testes

O Dockerfile está configurado para rodar os testes durante o processo de build. Se o build passar, os testes passaram.


### Para visualizar o relatório de execução detalhado:

1. **Executar (Redirecionando Input):**
   ```bash
   dotnet test
   ```  

### Notas Adicionais

* [Arredondamento](O sistema aplica arredondamento para duas casas decimais (Math.Round(..., 2)) no final do cálculo do imposto e no recálculo do preço médio, conforme exemplos da documentação.)

Entrada de Dados: O sistema espera que cada linha seja um JSON válido contendo uma lista de operações. Linhas vazias encerram a execução.

Precisão: O output numérico (ex: 10000.00 vs 10000) respeita a formatação numérica padrão do System.Text.Json, garantindo que o valor seja um Number válido no JSON.
