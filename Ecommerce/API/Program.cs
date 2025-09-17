using API.Models;
Console.Clear();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Lista de produtos fakes
var produtos  = new List<Produto>
        {
        new Produto { Nome = "Mouse Gamer RGB", Quantidade = 25, Preco = 129.90 },
        new Produto { Nome = "Teclado Mecânico ABNT2", Quantidade = 10, Preco = 299.99 },
        new Produto { Nome = "Monitor 24'' Full HD", Quantidade = 8, Preco = 899.00 },
        new Produto { Nome = "Headset Surround 7.1", Quantidade = 15, Preco = 199.50 },
        new Produto { Nome = "Notebook i5 11ª Geração", Quantidade = 5, Preco = 3599.99 },
        new Produto { Nome = "Cadeira Gamer Reclinável", Quantidade = 3, Preco = 799.00 },
        new Produto { Nome = "Webcam Full HD", Quantidade = 20, Preco = 149.90 },
        new Produto { Nome = "HD Externo 1TB", Quantidade = 12, Preco = 249.99 },
        new Produto { Nome = "Placa de Vídeo RTX 3060", Quantidade = 2, Preco = 2299.00 },
        new Produto { Nome = "Fonte 600W 80 Plus Bronze", Quantidade = 7, Preco = 379.90 }
        };
//Funcionalidades - Requisições

// - URL/Caminho/Endereço
// - Um método HTTP

//GET: /API/produto/listar
app.MapGet("/", () => "API de Produtos");

app.MapGet("/API/produto/listar", () =>
{
    return produtos;
});

//POST:
app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    produto.Nome = "Mouse";
    produtos.Add(produto);

});





app.Run();

