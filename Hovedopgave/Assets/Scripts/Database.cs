using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;

public class Database : MonoBehaviour
{
    // Mikael Paaske
    //private string connectionString = @"Data Source = tcp:hovedopgave.database.windows.net,1433; 
    // user id = Mikael;
    // password = Paaske77;
    // Initial Catalog = Clothing;";

    private string connectionString = @"Data Source = mssql7.gear.host; 
     user id = clothing;
     password = Paaske77!;
     Initial Catalog = clothing;";



    SqlConnection connection = null;


    void Connection()
    {
        connection = new SqlConnection(connectionString);
        Debug.Log("Database - Connection");
    }

    public List<Cloth> GetClothListQRCode1()
    {
        string name = "Test";
        Connection();
        Debug.Log("Database - Get ClothList");

        List<Cloth> ClothList = new List<Cloth>();
        DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
            connection.Open();
        Debug.Log("Forbindelse oprettet");
            adapter.Fill(dataTable);
            connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
        {

            ClothList.Add(
                new Cloth
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Quality = cloth["fabric1"].ToString(),
                    Quality2 = cloth["fabric2"].ToString(),
                    Quality3 = cloth["fabric3"].ToString(),
                    Quality4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()

                });
            
        }

        foreach (Cloth Clothing in ClothList)
        {
            Debug.Log(Clothing.Name);
            Debug.Log(Clothing.Price);
            Debug.Log(Clothing.Description);
            Debug.Log(Clothing.Quality);
            Debug.Log(Clothing.Quality2);
            Debug.Log(Clothing.URL);
        }

        return ClothList;
    }



    public List<Cloth> GetClothListQRCode2()
    {
        string name = "Test2";
        Connection();
        Debug.Log("Database - Get ClothList");

        List<Cloth> ClothList = new List<Cloth>();
        DataTable dataTable = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
        {

            ClothList.Add(
                new Cloth
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Quality = cloth["fabric1"].ToString(),
                    Quality2 = cloth["fabric2"].ToString(),
                    Quality3 = cloth["fabric3"].ToString(),
                    Quality4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()

                });

        }

        foreach (Cloth Clothing in ClothList)
        {
            Debug.Log(Clothing.Name);
        }
        Debug.Log(ClothList[0].URL);
        return ClothList;
    }

    public List<Cloth> GetClothListQRCode3()
    {
        string name = "Test3";
        Connection();
        Debug.Log("Database - Get ClothList");

        List<Cloth> ClothList = new List<Cloth>();
        DataTable dataTable = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
        {

            ClothList.Add(
                new Cloth
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Quality = cloth["fabric1"].ToString(),
                    Quality2 = cloth["fabric2"].ToString(),
                    Quality3 = cloth["fabric3"].ToString(),
                    Quality4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()

                });

        }

        foreach (Cloth Clothing in ClothList)
        {
            Debug.Log(Clothing.Name);
        }

        return ClothList;
    }

    public List<Cloth> GetClothListQRCode4()
    {
        string name = "Test4";
        Connection();
        Debug.Log("Database - Get ClothList");

        List<Cloth> ClothList = new List<Cloth>();
        DataTable dataTable = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cloths where Name = '" + name + "'", connection);
        Debug.Log("Prøver at oprette forbindelse");
        connection.Open();
        Debug.Log("Forbindelse oprettet");
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
        {

            ClothList.Add(
                new Cloth
                {
                    Name = cloth["Name"].ToString(),
                    Price = cloth["Price"].ToString(),
                    Description = cloth["Description"].ToString(),
                    Quality = cloth["fabric1"].ToString(),
                    Quality2 = cloth["fabric2"].ToString(),
                    Quality3 = cloth["fabric3"].ToString(),
                    Quality4 = cloth["fabric4"].ToString(),
                    URL = cloth["URL"].ToString()

                });

        }

        foreach (Cloth Clothing in ClothList)
        {
            Debug.Log(Clothing.Name);
        }

        return ClothList;
    }

}
