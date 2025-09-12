using System;
using Npgsql;

public class KisiIslemleri
{
    private static string connectionString = "Host=db;Username=kullanici;Password=sifre;Database=rehber";

    public static void KisiEkle(string isim, string eposta, string telefon, string adres)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var command = new NpgsqlCommand(
                "INSERT INTO kisi (isim, eposta, telefon, adres) VALUES (@isim, @eposta, @telefon, @adres)",
                connection
            );
            command.Parameters.AddWithValue("@isim", isim);
            command.Parameters.AddWithValue("@eposta", eposta);
            command.Parameters.AddWithValue("@telefon", telefon);
            command.Parameters.AddWithValue("@adres", adres);
            command.ExecuteNonQuery();
        }
    }
}
