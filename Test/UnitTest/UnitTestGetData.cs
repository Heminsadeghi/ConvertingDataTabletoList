using ConvertingDataTabletoList.DB;
using ConvertingDataTabletoList.Model;

namespace UnitTest
{
    public class UnitTestGetData
    {
        [Fact]
        public void TestFirst()
        {
            // Arrange  
            DataBaseCommon dataBase = new DataBaseCommon();
            string ConntionStringSource = "Password=123;Persist Security Info=True;User ID=sa1;Initial Catalog=TestDB1;Data Source=.;TrustServerCertificate=True";

            string Column = "ID,FirstName,LastName,Suffix,Email,AdditionalContactInfo,ModifiedDate,CreateDate";
            string TableName = "Person";

            // Act  
            var _result =
             dataBase.
             GetData(ConntionStringSource, TableName, Column);


            var data =
                dataBase.
                GetData(ConntionStringSource, TableName, Column)
                .CastToList<Person>();


            //Assert  

            Assert.NotNull(data);
            Assert.True(_result.Rows.Count == data.Count());




        }
    }
}