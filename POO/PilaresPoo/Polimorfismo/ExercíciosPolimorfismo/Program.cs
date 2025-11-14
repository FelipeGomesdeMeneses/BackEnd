using ExercíciosPolimorfismo;
Console.Clear();

PagamentoPix CompraPix = new PagamentoPix();
CompraPix.ValorCompra = 15000;

float valorpagar = CompraPix.ValorCompra;
Console.WriteLine($"Produto: Iphone");
Console.WriteLine($"Preco: {CompraPix.ValorCompra}");
Console.WriteLine($"Pagamento com Desconto: {CompraPix.CalcularTotal()}");


Console.WriteLine();

PagamentoCartao  CompraCartao = new PagamentoCartao();
CompraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {CompraCartao.ValorCompra}");
Console.WriteLine($"Forma De Pagamento: Cartäo");
Console.WriteLine($"Pagamento com Acrescimo: {CompraCartao.CalcularTotal()}");