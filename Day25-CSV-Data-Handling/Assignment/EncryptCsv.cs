using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class EncryptCsv
{
    private readonly byte[] key = Encoding.UTF8.GetBytes(
        "12345678901234567890123456789012");

    private readonly byte[] iv = Encoding.UTF8.GetBytes(
        "1234567890123456");

    private string Encrypt(string text)
    {
        using Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;

        using MemoryStream memory = new MemoryStream();

        using (CryptoStream crypto = new CryptoStream(
            memory,
            aes.CreateEncryptor(),
            CryptoStreamMode.Write))
        {
            byte[] data = Encoding.UTF8.GetBytes(text);

            crypto.Write(data, 0, data.Length);
        }

        return Convert.ToBase64String(memory.ToArray());
    }

    private string Decrypt(string text)
    {
        using Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;

        byte[] encrypted = Convert.FromBase64String(text);

        using MemoryStream memory =
            new MemoryStream(encrypted);

        using CryptoStream crypto = new CryptoStream(
            memory,
            aes.CreateDecryptor(),
            CryptoStreamMode.Read);

        using StreamReader reader =
            new StreamReader(crypto);

        return reader.ReadToEnd();
    }

    public void Run()
    {
        string salary = "60000";
        string email = "prince@gmail.com";

        string encryptedSalary = Encrypt(salary);
        string encryptedEmail = Encrypt(email);

        Console.WriteLine("Encrypted Salary: " +
            encryptedSalary);

        Console.WriteLine("Encrypted Email: " +
            encryptedEmail);

        Console.WriteLine("Decrypted Salary: " +
            Decrypt(encryptedSalary));

        Console.WriteLine("Decrypted Email: " +
            Decrypt(encryptedEmail));
    }
}