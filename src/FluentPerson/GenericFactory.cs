using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace FluentPerson
{
    public class GenericFactory<T> : IGenericFactory<T> where T : new()
    {
        private readonly T _entity;

        public GenericFactory(T entity)
        {
            this._entity = entity;
        }

        public GenericFactory()
        {
            this._entity = new T();
        }

        public IGenericFactory<T> AddPropertyValue<TValue>(Expression<Func<T, object>> property, TValue value)
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
            propertyInfo?.SetValue(_entity, value);

            return this;
        }


        public T Create()
        {
            return this._entity;
        }
    }
}
