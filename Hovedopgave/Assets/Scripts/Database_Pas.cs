using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;

public class Database_Pas : MonoBehaviour
{
    // Mikael Paaske
    private string connectionString = @"Data Source = tcp:hovedopgave.database.windows.net,1433; 
     user id = Mikael;
     password = Paaske77;
     Initial Catalog = Clothing;";
        
//        @"Data Source=tcp:hovedopgave.database.windows.net,1433;Initial Catalog=Clothing;
//Persist Security Info=False;User ID=Mikael;Password=Paaske77;MultipleActiveResultSets=False;Encrypt=True;
//TrustServerCertificate=False;Connection Timeout=30;";
                              
    SqlConnection connection = null;


    void Connection()
    {
        connection = new SqlConnection(connectionString);
        Debug.Log("Database - Connection");
    }

    public List<Cloth> GetClothList()
    {
        string name = "lemon curry kjole";
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
                    Quality = cloth["Quality"].ToString(),
                    Quality2 = cloth["Quality2"].ToString(),
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
