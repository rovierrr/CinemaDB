# CineDBteste — MVC

Projeto Windows Forms com Entity Framework organizado segundo o padrão MVC.

## Estrutura do Projeto

```
CineDBteste/
├── Model/
│   ├── Filmecs.cs
│   ├── ComprarFilme.cs
│   ├── OrcamentoMensal.cs
│   ├── Utilizador.cs
│   ├── Sessao.cs
│   ├── CinemaContext.cs
│   ├── AppDbInitializer.cs
│   ├── CompraGridDto.cs
│   └── ResumoEstatisticas.cs
├── Controller/
│   ├── Form1Controller.cs
│   ├── Form2Controller.cs
│   └── Form3Controller.cs
├── View/
│   ├── Form1.cs / Form1.Designer.cs
│   ├── Form2.cs / Form2.Designer.cs
│   └── Form3.cs / Form3.Designer.cs
├── Program.cs
├── App.config
├── packages.config
└── CineDBteste.csproj
```

## Como abrir no Visual Studio

1. Abrir o ficheiro `CineDBteste.sln` com Visual Studio 2019 ou 2022
2. Clicar com botão direito na solução → **Restore NuGet Packages**
   (isto instala o EntityFramework 6 automaticamente)
3. Compilar e executar (F5)

## Credenciais de teste

| Utilizador | Password |
|------------|----------|
| admin      | 12345    |
| pedro      | 1234     |

## Notas

- A base de dados é criada automaticamente em LocalDB na primeira execução
- O `AppDbInitializer` insere dados de teste (3 filmes, 3 compras, 1 orçamento)
- Se alterar o modelo, a BD é recriada automaticamente (`DropCreateDatabaseIfModelChanges`)
