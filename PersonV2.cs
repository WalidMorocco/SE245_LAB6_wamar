using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SE245_LAB5_wamar
{
    class PersonV2 : Person
    {
        private string instagram, cellPhone;

        public string Instagram
        {
            get
            {
                return instagram;
            }
            set
            {
                if (ValidationLibrary.IsValidInstagram(value))
                {
                    instagram = value;
                }
                else
                {
                    feedback += "\n ERROR : Invalid instagram nickname syntax";
                }
            }
        }
        
        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                if (ValidationLibrary.IsValidPhone(value))
                {
                    cellPhone = value;
                }
                else
                {
                    feedback += "\n ERROR : Invalid cell phone syntax";
                }
            }
        }

        

        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_WAmar;User Id=SE245_WAmar;Password=008009482;";     //Set the Who/What/Where of DB

            string strSQL = "INSERT INTO Persons (FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email, Instagram, CellPhone) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @Instagram, @CellPhone)";
            
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Instagram", Instagram);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);

            //attempt to connect to the server
            try
            {
                Conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";       //Report that we made the connection
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }



            return strResult;

        }

        public PersonV2() : base()
        {
            instagram = "";
            cellPhone = "";
        }


    }
}
