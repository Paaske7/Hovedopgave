using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;

public class Database : MonoBehaviour
{
    private SqlConnection connection;
    // Mikael Paaske
    //private string connectionString = @"Data Source = tcp:hovedopgave.database.windows.net,1433; 
    // user id = Mikael;
    // password = Paaske77;
    // Initial Catalog = Clothing;";

    private readonly string connectionString = @"Data Source = mssql7.gear.host; 
     user id = clothing;
     password = Paaske77!;
     Initial Catalog = clothing;";


    private void Connection()
    {
        connection = new SqlConnection(connectionString);
        Debug.Log("Database - Connection");
    }

    public List<ProductItem> GetclothesInfoListQRCode1()
    {
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

        //foreach (var Clothing in clothesInfoList)
        //{
        //    Debug.Log(Clothing.Name);
        //    Debug.Log(Clothing.Price);
        //    Debug.Log(Clothing.Description);
        //    Debug.Log(Clothing.Fabric1);
        //    Debug.Log(Clothing.Fabric2);
        //    Debug.Log(Clothing.URL);
        //}

        return clothesInfoList;
    }


    public List<ProductItem> GetclothesInfoListQRCode2()
    {
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

        //foreach (var Clothing in clothesInfoList) Debug.Log(Clothing.Name);
        //Debug.Log(clothesInfoList[0].URL);
        return clothesInfoList;
    }

    public List<ProductItem> GetclothesInfoListQRCode3()
    {
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

        //foreach (var Clothing in clothesInfoList) Debug.Log(Clothing.Name);

        return clothesInfoList;
    }

    public List<ProductItem> GetclothesInfoListQRCode4()
    {
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

        //foreach (var Clothing in clothesInfoList) Debug.Log(Clothing.Name);

        return clothesInfoList;
    }
}