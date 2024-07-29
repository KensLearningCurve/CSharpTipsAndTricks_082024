using Logic;

List<Task<(bool, Product)>> downloadTasks = ProductList.Products
    .GetRange(1, 10)
    .Select(ShouldBeOrdered)
    .ToList();

await foreach (var finishedTask in Task.WhenEach(downloadTasks))
{
    (bool order, Product product) result = await finishedTask;
    Console.WriteLine($"{result.product.Title} -> {result.order}");
}

async Task<(bool, Product)> ShouldBeOrdered(Product product)
{
    bool result = product.Stock < 10 && product.Status == Status.Delivered;

    await Task.Delay(Random.Shared.Next(1, 1000));

    return (result, product);
}
