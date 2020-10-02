using System;
using System.Reflection;
using Dapper;

public static class DataHelper
{
    public static DynamicParameters ExtractParameters<T>(T data){
        var parameters=new DynamicParameters();
        Type type=typeof(T);
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            parameters.Add(property.Name,property.GetValue(data, null));
        }
        return parameters;
    }
}