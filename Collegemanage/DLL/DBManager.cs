using BOL;
namespace DLL;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using MYSql.Data.MySqlClient;
public class DBManager
{
public static string conString=@"server=localhost;port=3306;user=root;password=root123;database=collegecare";
public static List<Admin> GetAllAdminsFromDatabase(){
List<Admin> allAdmins=new List<Admin>();
MySqlConnection con =new MySqlConnection();
con.ConnectionString=conString;
try{
    con.Open();
    MySqlCommand cmd=new MySqlCommand();
    cmd.Connection=con;
string query="select * from adminLoginCradentials";
cmd.CommandText=query;
MySqlDataReader reader=cmd.ExecuteReader();
while(reader.Read()){
    int id=int.Parse(reader["Id"].ToString());
string userName=reader["UserName"].ToString();
string password=reader["Password"].ToString();
Admin newAdmin=new Admin(id,userName,password);
allAdmins.Add(newAdmin);

}
}catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
con.Close();
}
return allAdmins;
}


public static List<Hospital> GetAllCollegesFromDatabase(){
List<College> allColleges=new List<College>();
MySqlConnection con =new MySqlConnection();
con.ConnectionString=conString;

         try{
            con.Open();
              MySqlCommand cmd=new MySqlCommand();
               cmd.Connection=con;
string query="select * from collegeDetails";
cmd.CommandText=query;
MySqlDataReader reader =cmd.ExecuteReader();
while(reader.Read()){
int id =int.Parse(reader["colId"].TOString());
string name=reader["colName"].TOString();
string email=reader["colEmail"].ToString();
string pin =reader["colPin"].ToString();
College newCollege=new College(id,name,email,pin);
allColleges.Add(newCollege);
}
}catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    con.Close();
}
return allColleges;
}
   
      
public static bool InsertIntoFile(List<College> allColleges)
{
    string collegeFile=@""
    var jsonData=JsonSerializer.Serialize<List<College>>(allColleges);
    System.IO.File.WriteAllText(collegeFile,jsonData);
    return true;
}
    

}














