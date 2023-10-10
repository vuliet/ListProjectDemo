using IronBarCode;

//BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("");

try
{
    // Giải mã QR code
    var result = BarcodeReader.Read("QRTEST.jpg");
}
catch (Exception ex)
{
    Console.WriteLine("Lỗi: " + ex.Message);
}
