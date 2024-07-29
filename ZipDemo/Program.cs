using Logic;

IEnumerable<string> productTitles = ProductList.Products.Take(10).Select(x => x.Title);
IEnumerable<int> productStocks = ProductList.Products.Take(10).Select(x => x.Stock);

var products = productTitles.Zip(productStocks, (title, stock) => new
{
    Title = title,
    Stock = stock
});

foreach (var product in products)
{
    Console.WriteLine($"{product.Title} - {product.Stock}");
}