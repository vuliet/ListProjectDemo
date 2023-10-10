using System.Text.RegularExpressions;

string filePath = "D:\\my_project\\TestSomeThing\\GcodeAnalyze\\GcodeFile\\myoutputTest.gcode";

try
{
    string estimatedPrintTime = "";
    string totalFilamentUsed = "";

    // Đọc tệp G-code dòng theo dòng
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            if (line.Contains("; estimated printing time"))
            {
                // Trích xuất thời gian dự kiến từ dòng
                estimatedPrintTime = Regex.Match(line, @"[0-9]+").Value;
            }
            else if (line.Contains("; filament used [mm]"))
            {
                // Trích xuất lượng sợi in từ dòng
                totalFilamentUsed = Regex.Match(line, @"[0-9]+").Value;
            }
        }
    }

    // In kết quả
    Console.WriteLine($"Estimated Print Time: {estimatedPrintTime} seconds");
    Console.WriteLine($"Total Filament Used: {totalFilamentUsed} meters");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}