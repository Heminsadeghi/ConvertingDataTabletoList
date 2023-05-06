using ConvertingDataTabletoList.DB;
using ConvertingDataTabletoList.Model;
using System.Data;

DataBaseCommon dataBase = new DataBaseCommon();
string ConntionStringSource = "Password=123;Persist Security Info=True;User ID=sa1;Initial Catalog=TestDB1;Data Source=.;TrustServerCertificate=True";

string Column = "ID,FirstName,LastName,Suffix,Email,AdditionalContactInfo,ModifiedDate,CreateDate";
string TableName = "Person";

var data = 
    dataBase.
    GetData(ConntionStringSource, TableName, Column)
    .CastToList<Person>();





var ddd = "";
