using AutoMapper;
using System.Reflection;

namespace PJ.Inf.ApplicantAssistance.Win.Registrars
{
    public static class AutomapperExtensions
    {
        public static IMappingExpression<TSource, TDestination> ForAllMembersOfType<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression, Type type, Action<IMemberConfigurationExpression<TSource, TDestination, object>> memberOptions)
        {
            foreach (PropertyInfo item in from c in typeof(TSource).GetProperties()
                                          where type.IsAssignableFrom((c.PropertyType.IsGenericType && type.IsGenericType) ? c.PropertyType.GetGenericTypeDefinition() : c.PropertyType)
                                          where (from x in typeof(TDestination).GetProperties()
                                                 where x.Name == c.Name
                                                 select x).Any()
                                          select c)
            {
                expression = expression.ForMember(item.Name, memberOptions);
            }

            return expression;
        }
    }
}
