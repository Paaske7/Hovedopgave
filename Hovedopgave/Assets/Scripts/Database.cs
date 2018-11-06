using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;

public class Database : MonoBehaviour
{
    private readonly string connectionString = "Data Source=.;Initial Catalog = Clothing; Integrated Security = True" ;
    SqlConnection connection = null;


    private void Connection()
    {
        connection = new SqlConnection(connectionString);
    }

    public List<Cloth> GetClothList()
    {
        Connection();
      

        List<Cloth> ClothList = new List<Cloth>();
        DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cloths Series where Name = 'T-Shirt'", connection);
            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

        foreach (DataRow cloth in dataTable.Rows)
        {

            ClothList.Add(
                new Cloth
                {
                    Name = cloth["Name"].ToString(),
                    //Price = cloth["Price"].ToString(),
                    //Description = cloth["Description"].ToString(),
                    //Quality = cloth["Quality"].ToString(),
                    //Quality2 = cloth["Quality2"].ToString(),

                });
            
        }

        foreach (Cloth Clothing in ClothList)
        {
            Debug.Log(Clothing.Name);
        }

        return ClothList;
    }

}
