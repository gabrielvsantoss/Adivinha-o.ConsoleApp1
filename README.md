# Jogo da adivinhação

![](https://i.imgur.com/WtaMOYX.gif)

**Funcionalidades**

- **Gerador de numeros**: Gera um numero aleatório de 0 a 20.
- **Tipos de Dificuldade**: Permite que o usuario escolha entre facil médio e dificil.
- **Interação com o usuario**: Permite que o usuario tenha a possibilidade de acertar o numero gerado.

**Como usar**
1. Clone o repósitório ou baixe o código fonte
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, complete uma solução utilizando o comando:
```
dotnet build --configuration Release
```

5. Para executar o projeto compilado em tempo real:
```
dotnet run --project Calculadora.ConsoleApp
```

6.Para executar o arquivo compilado, navegue até a pasta ./Adivinhação.ConsoleApp/bin/Release/net8.0/e execute o arquivo:
```
Adivinhação.ConsoleApp.exe
```

**Requisitos**
- .NET SDK (recomendado .NET 8.0 ou superior) para construção e execução do projeto.