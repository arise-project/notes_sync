using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

namespace notes_sync.Serializer
{
	public class NamedRowSerializer
	{
		public Dictionary<string, string> DeserializePlain(string text, string marker)
		{
			return null;
		}
		
		//https://missingquitbutton.wordpress.com/2019/07/31/using-reflection-with-serialization-part-2/
		public T Deserialize<T>(string text, string marker)
		{
			var d = DeserializePlain(text, marker);
			Type t = typeof(T);
			T o = (T)Activator.CreateInstance(t);
			DeserializeObject(o, t, d);
			return o;
		}
		
		static void DeserializeObject(object o, Type t, Dictionary<string, string> d)
		{
			FieldInfo[] fieldInfos = t.GetFields(BindingFlags.Public | BindingFlags.Instance);
			for (int i = 0; i < fieldInfos.Length; i++)
			{
				DeserializeField(fieldInfos[i], d, o);	
			}
		}
		
		static void DeserializeField(FieldInfo field, Dictionary<string, string> data, object rootObject)
		{
		    Type fieldType = field.FieldType;
		
		    if (fieldType.IsGenericType)
		        fieldType = fieldType.GetGenericTypeDefinition();
		
		    if (fieldType.IsArray)
		        fieldType = typeof(Array);
		
		    if (fieldType == typeof(int) || fieldType.IsEnum)
		    {
		        field.SetValue(rootObject, int.Parse(data[field.Name]));
		    }
		    else if (fieldType == typeof(float))
		    {
		        field.SetValue(rootObject, float.Parse(data[field.Name]));
		    }
		    else if (fieldType == typeof(bool))
		    {
		        field.SetValue(rootObject, Boolean.Parse(data[field.Name]));
		    }
		    else if (fieldType == typeof(string))
		    {
		        field.SetValue(rootObject, data[field.Name]);
		    }
		    else if (fieldType == typeof(Array))
		    {
		        //Type arrayType = field.FieldType;
		        //int rank = arrayType.GetArrayRank();
		
		        //JSONArray jsArray = data[field.Name]["Array"].AsArray;
		        //Type elementType = arrayType.GetElementType();
		
		        //Array arr;
		
		        //if (rank == 1)
		        //{
		        //    int lenght = data[field.Name]["Lenght"].AsInt;
		        //    arr = Array.CreateInstance(elementType, lenght);
		
		        //    if (elementType.IsPrimitive || elementType == typeof(string))
		        //    {
		        //        if (elementType == typeof(int) || elementType.IsEnum)
		        //        {
		        //            for (int i = 0; i < arr.Length; i++)
		        //                arr.SetValue(jsArray[i].AsInt, i);
		        //        }
		        //        else if (elementType == typeof(float))
		        //        {
		        //            for (int i = 0; i < arr.Length; i++)
		        //                arr.SetValue(jsArray[i].AsFloat, i);
		        //        }
		        //        else if (elementType == typeof(bool))
		        //        {
		        //            for (int i = 0; i < arr.Length; i++)
		        //                arr.SetValue(jsArray[i].AsBool, i);
		        //        }
		        //        else if (elementType == typeof(string))
		        //        {
		        //            for (int i = 0; i < arr.Length; i++)
		        //                arr.SetValue(jsArray[i].Value, i);
		        //        }
		        //    }
		        //    else if (elementType.IsClass || (elementType.IsValueType && !elementType.IsEnum))
		        //    {
		        //        for (int i = 0; i < arr.Length; i++)
		        //        {
		        //            string typeString = jsArray[i]["Type"].Value;
		        //            Type entryType = Type.GetType(typeString);
		
		        //            object o = Activator.CreateInstance(entryType);
		        //            DeserializeObject(o, jsArray[i]["Value"], o);
		        //            arr.SetValue(o, i);
		        //        }
		        //    }
		        //    field.SetValue(rootObject, arr);
		        //}
		        //else if (rank == 2)
		        //{
		        //    int lenght1 = data[field.Name]["Lenght1"].AsInt;
		        //    int lenght2 = data[field.Name]["Lenght2"].AsInt;
		        //    arr = Array.CreateInstance(elementType, lenght1, lenght2);
		
		        //  if (elementType.IsPrimitive || elementType == typeof(string))
		        //  {
		        //      if (elementType == typeof(int) || elementType.IsEnum)
		        //      {
		        //          for (int i = 0; i < arr.GetLength(0); i++)
		        //              for (int j = 0; j < arr.GetLength(1); j++)
		        //                  arr.SetValue(jsArray[i].AsInt, i, j);
		        //        }
		        //        else if (elementType == typeof(float))
		        //        {
		        //            for (int i = 0; i < arr.GetLength(0); i++)
		        //                for (int j = 0; j < arr.GetLength(1); j++)
		        //                    arr.SetValue(jsArray[i].AsFloat, i, j);
		        //        }
		        //        else if (elementType == typeof(bool))
		        //        {
		        //            for (int i = 0; i < arr.GetLength(0); i++)
		        //                for (int j = 0; j < arr.GetLength(1); j++)
		        //                    arr.SetValue(jsArray[i].AsBool, i, j);
		        //        }
		        //        else if (elementType == typeof(string))
		        //        {
		        //            for (int i = 0; i < arr.GetLength(0); i++)
		        //                for (int j = 0; j < arr.GetLength(1); j++)
		        //                    arr.SetValue(jsArray[i].Value, i, j);
		        //        }
		        //    }
		        //    else if (elementType.IsClass || (elementType.IsValueType && !elementType.IsEnum))
		        //    {
		        //        for (int i = 0; i < arr.GetLength(0); i++)
		        //        {
		        //            for (int j = 0; j < arr.GetLength(1); j++)
		        //            {
		        //                string typeString = jsArray[i][j]["Type"].Value;
		        //                Type entryType = Type.GetType(typeString);
		
		        //                object o = Activator.CreateInstance(entryType);
		        //                DeserializeObject(o, jsArray[i][j]["Value"], o);
		        //                arr.SetValue(o, i, j);
		        //            }
		        //        }
		        //    }
		        //    field.SetValue(rootObject, arr);
		        //}
		    }
		    else if (fieldType == typeof(List<>))
		    {
		        //JSONArray jsArray = data[field.Name].AsArray;
		        //int entryCount = jsArray.Count;
		
		        //Type genericArgument = field.FieldType.GetGenericArguments()[0];
		        //Type constructedListType = (typeof(List<>).MakeGenericType(genericArgument));
		        //IList instance = (IList)Activator.CreateInstance(constructedListType);
		
		        //if (genericArgument.IsPrimitive || genericArgument == typeof(string))
		        //{
		        //    if (genericArgument == typeof(int) || genericArgument.IsEnum)
		        //    {
		        //        for (int i = 0; i < entryCount; i++)
		        //            instance.Add(jsArray[i].AsInt);
		        //    }
		        //    else if (genericArgument == typeof(float))
		        //    {
		        //        for (int i = 0; i < entryCount; i++)
		        //            instance.Add(jsArray[i].AsFloat);
		        //    }
		        //    else if (genericArgument == typeof(bool))
		        //    {
		        //        for (int i = 0; i < entryCount; i++)
		        //            instance.Add(jsArray[i].AsBool);
		        //    }
		        //    else if (genericArgument == typeof(string))
		        //    {
		        //        for (int i = 0; i < entryCount; i++)
		        //            instance.Add(jsArray[i].Value);
		        //    }
		        //}
		        //else if (genericArgument.IsClass || (genericArgument.IsValueType && !genericArgument.IsEnum))
		        //{
		        //    for (int i = 0; i < entryCount; i++)
		        //    {
		        //        string typeString = jsArray[i]["Type"].Value;
		        //        Type entryType = Type.GetType(typeString);
		
		        //        object o = Activator.CreateInstance(entryType);
		        //        DeserializeObject(o, jsArray[i]["Value"], o);
		        //        instance.Add(o);
		        //    }
		        //}
		
		        //field.SetValue(rootObject, instance);
		    }
		    else if (fieldType == typeof(object))
		    {
		        //JSONNode objectNode = data[field.Name];
		        //object newInstance = Activator.CreateInstance(fieldType);
		        //DeserializeObject(newInstance, data[field.Name].AsObject, newInstance);
		
		        //field.SetValue(rootObject, newInstance);
		    }
		}
	}
}
