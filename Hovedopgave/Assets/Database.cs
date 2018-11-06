using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;

public class Database : MonoBehaviour
{
    private readonly string connectionString = @"Data Source=sql.itcn.dk\EADANIA;Initial Catalog=jona711p.EADANIA;Persist Security Info=True;User ID=jona711p.EADANIA;Password=7DG6ckH8c0";
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

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clothing where Name = 'Something?'", connection);
            connection.Open();
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

                });
        }

        foreach (Cloth Clothing in ClothList)
        {
            Debug.Log(Clothing.Name);
        }

        return ClothList;
    }

}
