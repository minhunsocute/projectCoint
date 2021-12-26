using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Server_manage
{
    public class sql_manage
    {
        public static string strComputerName = Environment.MachineName.ToString();
        private string conStr = $"Data Source={strComputerName};Initial Catalog=COINS_MANAGE;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        //Hàm kiểm tra login thành công nếu như hàm trả về -1 tức là client đã đăng nhập thành công bằng 0 thì ngược lại
        #region check Sign in and sign up
        public int checkLogin(string stringCheck)
        {
            //1*4*hung*8*20112002
            string userName = "";
            string password = "";
            string countS = "";
            int i = 2;
            for (; ; i++)
            {
                if (stringCheck[i] == '*') { i++; break; }
                countS += stringCheck[i];
            }
            int j = i;
            for (; i < j + Int32.Parse(countS); i++)
            {
                userName += stringCheck[i];
            }
            i += 1; countS = string.Empty;
            for (; ; i++)
            {
                if (stringCheck[i] == '*') { i++; break; }
                countS += stringCheck[i];
            }
            j = i;
            for (; i < j + Int32.Parse(countS); i++)
                password += stringCheck[i];
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = $"SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME = '{userName}' AND PASS = '{password}'";
            comm = new SqlCommand(sqlString, conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            if (count != 0)
                return -1;
            conn.Close();
            return 0;
        }
        #endregion

        #region get data from web json
        private static string returnApiString()
        {
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString("https://vapi.vnappmob.com/api/request_api_key?scope=exchange_rate");
            return htmlCode;
        }

        private static async Task GetFromCompaniesHouse()
        {
            string s = returnApiString();
            var url = "https://vapi.vnappmob.com/api/v2/exchange_rate/vcb";
            var apiKey = s.Substring(12, s.IndexOf('}') - 13);
            var encodedKey = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(apiKey));
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Add("Authorization", $"Basic {apiKey}");
                var response = await client.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();
                int size = content.ToString().Length;
                string jsonString = content.ToString();
                Root value = JsonConvert.DeserializeObject<Root>(jsonString);
                if (value.results.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DI57MUOG;Initial Catalog=COINS_MANAGE;Integrated Security=True");
                    SqlCommand com;
                    con.Open();
                    DateTime d1 = DateTime.Now;
                    string sqlString1 = $"SELECT COUNT(*) FROM COINS_DATA WHERE DAY(DATE_TIME) = {d1.Day.ToString()} AND MONTH(DATE_TIME) = {d1.Month.ToString()}" +
                                        $" AND YEAR(DATE_TIME) = {d1.Year.ToString()}";
                    com = new SqlCommand(sqlString1, con);
                    Int32 count = (Int32)com.ExecuteScalar();
                    if (count == 0)
                    {
                        foreach (Result item in value.results)
                        {
                            string sqlString = $"EXEC INSERT_COINSDATA '{item.currency}',{item.buy_cash.ToString()},{item.buy_transfer.ToString()},{item.sell.ToString()}";
                            com = new SqlCommand(sqlString, con);
                            com.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        foreach (Result item in value.results)
                        {
                            string sqlStringCheck = $"SELECT COUNT(*) FROM COINS_DATA WHERE CURRENCY = '{item.currency}'";
                            com = new SqlCommand(sqlStringCheck, con);
                            Int32 count1 = (Int32)com.ExecuteScalar();
                            if (count1 == 0)
                            {
                                string sqlString = $"EXEC INSERT_COINSDATA '{item.currency}',{item.buy_cash.ToString()},{item.buy_transfer.ToString()},{item.sell.ToString()}";
                                com = new SqlCommand(sqlString, con);
                                com.ExecuteNonQuery();
                            }
                            else
                            {
                                string sqlString = $"UPDATE COINS_DATA SET BUY_CASH = {item.buy_cash.ToString()}, BUY_TRANSFER = {item.buy_transfer.ToString()}, SELL = {item.sell.ToString()}, " +
                                                $" DATE_TIME = GETDATE() " +
                                                $" WHERE CURRENCY = '{item.currency}' AND DAY(DATE_TIME) = {d1.Day.ToString()} AND MONTH(DATE_TIME) = {d1.Month.ToString()}" +
                                                $" AND YEAR(DATE_TIME) = {d1.Year.ToString()}";
                                com = new SqlCommand(sqlString, con);
                                com.ExecuteNonQuery();
                            }
                        }
                    }
                    con.Close();
                }
            }
        }
        // Get data from sql 
        #region getdata from sql
        public string GetDataFromDatabase(string currency, string datime)
        {
            string sendString = "";
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "";
            if (datime != "")
            {
                string day = "", year = "", month = "";
                int i = 0;
                for (; i < 4; i++) year += datime[i];
                int j = i + 1; i++;
                for (; i < j + 2; i++) month += datime[i];
                i++;
                for (; i < datime.Length; i++) day += datime[i];
                sendString = "5";
                sqlString = $" SELECT * FROM COINS_DATA WHERE CURRENCY LIKE'%{currency}%' " +
                            $" AND DAY(DATE_TIME) = {day} AND MONTH(DATE_TIME) = {month}" +
                            $" AND YEAR(DATE_TIME) = {year}";
            }
            else
            {
                sendString = "5";
                sqlString = $"SELECT * FROM COINS_DATA WHERE CURRENCY LIKE'%{currency}%'";
            }
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "ID");
            dt = ds.Tables["ID"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sendString += $"{dt.Rows[i]["CURRENCY"].ToString()}*{dt.Rows[i]["BUY_CASH"].ToString()}*" +
                            $"{dt.Rows[i]["BUY_TRANSFER"].ToString()}*{dt.Rows[i]["SELL"].ToString()}*{dt.Rows[i]["DATE_TIME"].ToString()}*|";
            }
            conn.Close();
            return sendString;
        }
        #endregion
        public static void updateData()
        {
            var task = GetFromCompaniesHouse();
        }

        #endregion

        #region class result and root result 
        public class Result
        {
            public double buy_cash { get; set; }
            public double buy_transfer { get; set; }
            public string currency { get; set; }
            public double sell { get; set; }
        }
        //List<Object>
        public class Root
        {
            public List<Result> results { get; set; }
            //private List<Result> esults { get; set; }
        }
        #endregion
       
        #region insert Account
        //INSERT INTO ACCOUNT TABLE
        public void Insert_Account(string stringCheck)
        {
           
            string userName = "";
            string password = "";
            string countS = "";
            int i = 2;
            for (; ; i++)
            {
                if (stringCheck[i] == '*') { i++; break; }
                countS += stringCheck[i];
            }
            int j = i;
            for (; i < j + Int32.Parse(countS); i++)
            {
                userName += stringCheck[i];
            }
            i += 1; countS = string.Empty;
            for (; ; i++)
            {
                if (stringCheck[i] == '*') { i++; break; }
                countS += stringCheck[i];
            }
            j = i;
            for (; i < j + Int32.Parse(countS); i++)
                password += stringCheck[i];
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = $"INSERT INTO ACCOUNT (USERNAME,PASS) VALUES('{userName}','{password}')";
            comm = new SqlCommand(sqlString, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
        
    }
}
