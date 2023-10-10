using Renci.SshNet;

string host = "65.108.230.204";
string username = "root";
string password = "A6kTrCCtM4jkwhsq4b59tIgB55ri72Yn";

using (SshClient sshClient = new(host, username, password))
{
    try
    {
        sshClient.Connect();

        using var command = sshClient.CreateCommand("pwd");

        var output = command.Execute();

        sshClient.Disconnect();
    }
    catch (Exception e)
    {
        Console.WriteLine("An exception has been caught " + e.ToString());
    }
}