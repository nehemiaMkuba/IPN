﻿using System;
using System.Reflection;
using System.ComponentModel;

namespace IPN.API.Models.Common
{
    public static class HelperMethods
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
