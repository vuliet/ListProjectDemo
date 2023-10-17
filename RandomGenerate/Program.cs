using System.Security.Cryptography;

var alphaNumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_!@#$%^&*()=-~`|/><.,[]";

var genString = RandomNumberGenerator.GetInt32(100);

Console.WriteLine(genString);
Console.ReadLine();