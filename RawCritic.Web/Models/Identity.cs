
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class IdentityOrValue<T> where T : class
    {
        public long? Id { get; private set; }

        public T Value { get; private set; }

        public IdentityOrValue()
        {
        }

        public IdentityOrValue(long id)
        {
            Id = id;
        }

        public IdentityOrValue(T value)
        {
            Value = value;
        }

        public IdentityOrValue(object value)
        {
            Value = value as T;
        }
    }

    public class IdentitiesOrValues<T> where T : class
    {
        public long[] Ids { get; private set; }

        public T[] Values { get; private set; }

        public IdentitiesOrValues()
        {
        }

        public IdentitiesOrValues(long[] ids)
        {
            Ids = ids;
        }

        public IdentitiesOrValues(object[] values)
        {
            var list = values.Select(value => (T)value).ToArray();
            Values = list;
        }
    }
}

