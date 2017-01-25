using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace FluentPerson
{
    public class GenericFactory<T> : IGenericFactory<T>
    {
        private readonly T _entity;

        public GenericFactory(T entity)
        {
            this._entity = entity;
        }

        public IGenericFactory<T> AddPropertyValue(Expression<Func<T, object>> property, object value)
        {
            PropertyInfo propertyInfo = null;
            if (property.Body is MemberExpression)
            {
                propertyInfo = (property.Body as MemberExpression).Member as PropertyInfo;
            }
            else
            {
                propertyInfo = (((UnaryExpression)property.Body).Operand as MemberExpression).Member as PropertyInfo;
            }
            propertyInfo?.SetValue(_entity, value, null);

            return this;
        }

        public T Create()
        {
            return this._entity;
        }
    }
}
