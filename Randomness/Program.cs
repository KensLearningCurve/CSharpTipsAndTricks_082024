
using Logic;

Product[] products = Random.Shared.GetItems(ProductList.Products.ToArray(), 5);
Console.WriteLine("GetItems<T>:");
foreach (Product product in products)
{
    Console.WriteLine($"Name: {product.Title}, Stock: {product.Stock}");
}

Product[] forShuffle = ProductList.Products.ToArray();
Random.Shared.Shuffle(forShuffle);
Console.WriteLine(string.Empty);
Console.WriteLine("Shuffle<T>:");
foreach (Product product in forShuffle)
{
    Console.WriteLine($"Name: {product.Title}, Stock: {product.Stock}");
}