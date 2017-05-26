using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DxRep.Core.Attributes;

namespace DxRep.Core.Extensions
{
    /// <summary>
    /// 反射静态扩展类
    /// </summary>
    public static class ReflectionExtension
    {
        /// <summary>
        /// 读取对象所有属性名称的集合
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="t">泛型对象</param>
        /// <returns>对象所有属性名称的集合</returns>
        public static List<string> GetAllPropertyNameList(this Type t)
        {
            if (t == null)
            {
                throw new NullReferenceException();
            }
            var properties = t.GetProperties().Select(x => x.Name).ToList();
            return properties;
        }

        /// <summary>
        /// 读取对象所有属性名称的集合
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="t">泛型对象</param>
        /// <returns>以逗号连接的对象所有属性名称字符串</returns>
        public static string GetAllPropertyNameString(this Type t)
        {
            if (t == null)
            {
                throw new NullReferenceException();
            }
            var properties = t.GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance).Select(x => x.Name).ToList();
            return string.Join(",", properties);
        }

        public static PropertyMapping Mapping(this Type type)
        {
            var mapping = new PropertyMapping
            {
                ClassName = type.Name,
                PropertyInfos = type.GetProperties(),
                PropertiesString = type.GetAllPropertyNameString(),
                PrimaryKey = ""
            };
            var primaryKeyProperty = mapping.PropertyInfos.FirstOrDefault(p => p.GetCustomAttributes(false).Any(x => x.GetType() == typeof(PrimaryKeyAttribute)));
            if (primaryKeyProperty != null)
            {
                mapping.PrimaryKey = primaryKeyProperty.Name;
            }
            else
            {
                var first = mapping.PropertyInfos.FirstOrDefault(x => x.Name.ToLower().EndsWith("_id"));
                if (first != null)
                {
                    mapping.PrimaryKey = first.Name;
                }
                else
                {
                    first = mapping.PropertyInfos.FirstOrDefault(x => x.Name.ToLower().EndsWith("id"));
                    if (first != null)
                    {
                        mapping.PrimaryKey = first.Name;
                    }
                }
            }
            if (string.IsNullOrEmpty(mapping.PrimaryKey))
            {
                throw new Exception(string.Format("请为表{0}指定一个主键", mapping.ClassName));
            }
            return mapping;
        }
    }
}
