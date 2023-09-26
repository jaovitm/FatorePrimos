# API de Fatoração em C#

Esta API em C# tem como objetivo fornecer os fatores de um número fornecido e dentre estes, quais são números primos. Basta acessar o endpoint `/fatorar/{número}` para obter os fatores correspondentes.

## Uso

### Requisição

```
GET /fatorar/{número}
```

#### Parâmetros

- `{número}` (obrigatório): O número que você deseja fatorar.

### Exemplo de Requisição

```
GET /fatorar/40
```

### Resposta

```json
{
  "numero": 40,
  "divisores": [1, 2, 4, 5, 8, 10, 20, 40],
  "divisoresPrimos" : [2, 5]
}
```

## Instalação

1. Clone este repositório:

```bash
git clone https://github.com/seu-username/fatoracao-api-csharp.git
```

2. Abra o projeto em seu ambiente de desenvolvimento preferido.

3. Certifique-se de ter o ambiente configurado corretamente com o SDK do .NET.

4. Execute o projeto e a API estará pronta para receber requisições.


