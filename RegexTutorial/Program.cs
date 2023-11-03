using System.Text.RegularExpressions;

var content = "Xppmm: 21.16402\r\n      Yppmm: 21.16402\r\n      Ppmm: {Width=21.16402, Height=21.16402}\r\n      PpmmMax: 21.16402\r\n      PixelWidth: 0.0472\r\n      PixelHeight: 0.0472\r\n      PixelSize: {Width=0.0472, Height=0.0472}\r\n      PixelSizeMax: 0.0472\r\n      PixelArea: 0.0022278402\r\n      PixelWidthMicrons: 47.25\r\n      PixelHeightMicrons: 47.25\r\n      PixelSizeMicrons: {Width=47.25, Height=47.25}\r\n      PixelSizeMicronsMax: 47.25\r\n      PixelAreaMicrons: 2232.5625\r\n      Volume: 333.421\r\n      HaveAntiAliasing: True\r\n      IsAntiAliasingEmulated: False\r\n      LayerHeightUm: 50\r\n      PrintHeight: 18.45\r\n      SupportGlobalPrintParameters: True\r\n      SupportPerLayerSettings: False\r\n      IsReadOnly: False\r\n      Count: 369";

//string[] lines = content.Split('\n'); // Tách dữ liệu thành từng dòng

//foreach (string line in lines)
//{
//    string[] parts = line.Split(':'); // Tách dòng thành phần tên thuộc tính và giá trị
//    if (parts.Length == 2)
//    {
//        string propertyName = parts[0].Trim();
//        string propertyValue = parts[1].Trim();

//        // Ở đây bạn có thể xác định thuộc tính (propertyName) và giá trị (propertyValue)
//        Console.WriteLine($"Field: {propertyName}, Value: {propertyValue}");
//    }
//}

//string pattern = @":\s*(\d+\.\d+)";

//string pattern = @"\s*([a-zA-Z\s]+)";

//string pattern = @"(\w+):\s*([^{}]+|\{[^{}]+\})";

//MatchCollection matches = Regex.Matches(content, pattern);

//foreach (Match match in matches)
//{
//    string name = match.Groups[1].Value;
//    string value = match.Groups[2].Value.Trim();
//    Console.WriteLine($"{name}: {value}");
//}

string pattern = @"Ppmm:\s*([^\r\n]+)";

Match match = Regex.Match(content, pattern);

if (match.Success)
{
    string xppmmValue = match.Groups[1].Value.Trim();
    Console.WriteLine($"Value of Ppmm is: {xppmmValue}");
}

Console.ReadLine();

// \s* phù hợp với bất kỳ khoảng trắng sau chuỗi "Xppmm:".
// ([^\r\n] +) phù hợp với bất kỳ ký tự nào (trừ các ký tự xuống dòng) và lấy giá trị này.
// Khi bạn chạy chương trình này, nó sẽ in ra giá trị tương ứng với "Xppmm" từ chuỗi content.