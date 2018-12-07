using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;

public class Database : MonoBehaviour
{
    private SqlConnection connection;
    // Mikael Paaske

    // Connectionstring til database
    private readonly string connectionString = @"Data Source = mssql7.gear.host; 
     user id = clothing;
     password = Paaske77!;
     Initial Catalog = clothing;";


    private void Connection()
    {
        // Opretter forbindelse til database
        connection = new SqlConnection(connectionString);
        Debug.Log("Database - Connection");
    }

    public List<ProductItem> GetclothesInfoListQRCode1()
    {
        // Henter alt information om tøjet hvor navnet er WOODBIRD STEFFEN TWILL PANT fra databasen og sætter det til vores properties i ProductItem
        var name = "WOODBIRD STEFFEN TWILL PANT";
        Connection();
        Debug.Log("Database - Get clothesInfoList");

        var clothesInfoList = new List<ProductItem>();
        var dataTable = new DataTable();

        var adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
            clothesInfoList.Add(
                new ProductItem
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Fabric1 = cloth["fabric1"].ToString(),
                    Fabric2 = cloth["fabric2"].ToString(),
                    Fabric3 = cloth["fabric3"].ToString(),
                    Fabric4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()
                });

        return clothesInfoList;
    }


    public List<ProductItem> GetclothesInfoListQRCode2()
    {
        // Henter alt information om tøjet hvor navnet er PATAGONIA BAGGIES fra databasen og sætter det til vores properties i ProductItem
        var name = "PATAGONIA BAGGIES";
        Connection();
        Debug.Log("Database - Get clothesInfoList");

        var clothesInfoList = new List<ProductItem>();
        var dataTable = new DataTable();

        var adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
            clothesInfoList.Add(
                new ProductItem
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Fabric1 = cloth["fabric1"].ToString(),
                    Fabric2 = cloth["fabric2"].ToString(),
                    Fabric3 = cloth["fabric3"].ToString(),
                    Fabric4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()
                });

        return clothesInfoList;
    }

    public List<ProductItem> GetclothesInfoListQRCode3()
    {
        // Henter alt information om tøjet hvor navnet er RAINS 1202 fra databasen og sætter det til vores properties i ProductItem
        var name = "RAINS 1202";
        Connection();
        Debug.Log("Database - Get clothesInfoList");

        var clothesInfoList = new List<ProductItem>();
        var dataTable = new DataTable();

        var adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
            clothesInfoList.Add(
                new ProductItem
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Fabric1 = cloth["fabric1"].ToString(),
                    Fabric2 = cloth["fabric2"].ToString(),
                    Fabric3 = cloth["fabric3"].ToString(),
                    Fabric4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()
                });

        return clothesInfoList;
    }

    public List<ProductItem> GetclothesInfoListQRCode4()
    {
        // Henter alt information om tøjet hvor navnet er GANNI BARRA CREPE TWIST fra databasen og sætter det til vores properties i ProductItem
        var name = "GANNI BARRA CREPE TWIST";
        Connection();
        Debug.Log("Database - Get clothesInfoList");

        var clothesInfoList = new List<ProductItem>();
        var dataTable = new DataTable();

        var adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
            clothesInfoList.Add(
                new ProductItem
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Fabric1 = cloth["fabric1"].ToString(),
                    Fabric2 = cloth["fabric2"].ToString(),
                    Fabric3 = cloth["fabric3"].ToString(),
                    Fabric4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()
                });

        return clothesInfoList;
    }
}