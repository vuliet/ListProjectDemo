using DataAnalysis;

var transactions = new List<Transaction>
{
    new Transaction { Product = "A", Sales = 100, Date = new DateTime(2023, 7, 1) },
    new Transaction { Product = "B", Sales = 200, Date = new DateTime(2023, 7, 1) },
    new Transaction { Product = "C", Sales = 150, Date = new DateTime(2023, 7, 1) },
    new Transaction { Product = "A", Sales = 120, Date = new DateTime(2023, 7, 2) },
    new Transaction { Product = "B", Sales = 180, Date = new DateTime(2023, 7, 2) },
    new Transaction { Product = "C", Sales = 130, Date = new DateTime(2023, 7, 2) },
    new Transaction { Product = "A", Sales = 140, Date = new DateTime(2023, 7, 3) },
    new Transaction { Product = "B", Sales = 190, Date = new DateTime(2023, 7, 3) },
    new Transaction { Product = "C", Sales = 160, Date = new DateTime(2023, 7, 3) }
};

// Khám phá dữ liệu (vẽ biểu đồ đường theo ngày)
var groupedByDate = transactions.GroupBy(t => t.Date);
foreach (var group in groupedByDate)
{
    var date = group.Key;
    var totalSales = group.Sum(t => t.Sales);
    Console.WriteLine($"Date: {date.ToShortDateString()}, Total Sales: {totalSales}");
}

// Xây dựng mô hình (tính trung bình doanh số bán hàng)
var groupedByProduct = transactions.GroupBy(t => t.Product);
foreach (var group in groupedByProduct)
{
    var product = group.Key;
    var averageSales = group.Average(t => t.Sales);
    Console.WriteLine($"Product: {product}, Average Sales: {averageSales}");
}

Console.ReadLine();