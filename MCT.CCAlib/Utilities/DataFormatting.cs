using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MCT.CCAlib.Utilities
{
    public static class DataFormatting
    {
        /// <summary>
		/// This method removes the UNICODE characters from a string
		/// </summary>
		/// <param name="valueToClean"></param>
		/// <returns></returns>
		public static string RemoveUnicode(string valueToClean)
        {
            return Regex.Replace(valueToClean, @"[^\u0020-\u007E]", string.Empty);
        }

        /// <summary>
        /// Takes a IEnumerable of items and converts the list into a DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(string desiredTableName, IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(desiredTableName);

            PropertyInfo[] properties = typeof(T).GetProperties();

            // Traverse each oProperty, .Add'ing each .Name/.BaseType into our oReturn value
            // NOTE: The call to .BaseType is required as DataTables/DataSets do not support nullable types, so it's
            //          non-nullable counterpart Type is required in the .Column definition
            foreach (PropertyInfo property in properties)
            {
                dataTable.Columns.Add(property.Name, BaseType(property.PropertyType));
            }

            foreach (T item in items)
            {
                var values = new object[properties.Length];

                for (int i = 0; i < properties.Length; ++i)
                {
                    values[i] = properties[i].GetValue(item, null);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        /// <summary>
        /// Retrieve the base type of the passed in object
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type BaseType(Type type)
        {
            //If the passed type is valid, .IsValueType and is logicially nullable, .Get(its)UnderlyingType
            if (type != null && type.IsValueType &&
                type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>)
            )
            {
                return Nullable.GetUnderlyingType(type);
            }
            else // Else the passed oType was null or was not logicially nullable, so simply return the passed oType
            {
                return type;
            }
        }
    }
}
