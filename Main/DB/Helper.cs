using System.Data;
using System.Reflection;

namespace ConvertingDataTabletoList.DB
{
    public static class Execution
    {
        public static List<T> CastToList<T>(this DataTable table) where T : class, new()
        {
            var items = table.AsEnumerable().Select(dataRow =>
             {
                 T item = new T();
                 foreach (var info in item.GetType().GetProperties())
                 {
                     PropertyInfo pInfo = item.GetType().GetProperty(info.Name);

                     if (dataRow[info.Name] is DBNull) continue;
                     Object value = Convert.ChangeType(dataRow[info.Name], pInfo.PropertyType);
                     pInfo.SetValue(item, value);
                 }

                 return item;
             }).ToList();

            return items;

        }

    }

}
