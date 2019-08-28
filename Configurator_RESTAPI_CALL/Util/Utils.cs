﻿using System;
using System.Collections.Generic;

namespace Configurator_RESTAPI_CALL.Util
{
    public static class Utils
    {
        public static Dictionary<string, dynamic> DictionaryOfJsonFields<T>(T obj)
        {
            var dictionary = new Dictionary<string, dynamic>();

            foreach (var property in obj.GetType().GetProperties())
            {
                // Todo
            }

            return dictionary;
        }

        public static void DictionaryToJsonFields<T>(T obj, Dictionary<string, dynamic> fields)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                foreach (var attribute in property.GetCustomAttributes(true))
                {
                    // Todo
                }
            }
        }

        public static string DateToString(DateTime? date)
        {
            if (date == null)
            {
                return "";
            }

            return ((DateTime)(object)date).ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public static int? IntFromString(string integer)
        {
            if (integer != null)
            {
                return Int32.Parse(integer);
            }

            return null;
        }


        public static DateTime? DateTimeFromString(string date)
        {
            if (date != null)
            {
                try
                {
                    return DateTime.Parse(date);
                }
                catch (FormatException)
                {
                }
            }

            return null;
        }
    }
}
