using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public static class GetValueByKey
    {
        public static object GetValueByKeymathod(object obj, string key)
        {
            var keys = key.Split('/');
            var currentObj = obj;

            foreach (var k in keys)
            {
                var type = currentObj.GetType();
                var property = type.GetProperty(k);

                if (property != null)
                {
                    currentObj = property.GetValue(currentObj);
                }
                else
                {
                    return null;
                }
            }

            return currentObj;
        }
    }
}
