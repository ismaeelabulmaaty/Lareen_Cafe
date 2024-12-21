﻿using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace LareenCafe.Api.VerticalSlicing.Common
{
    public static class MapperHandler
    {
        public static IMapper mapper { get; set; } = null!;

        public static TResult Map<TResult>(this object source)
        {
            return mapper.Map<TResult>(source);
        }
        public static TDestination Map<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return mapper.Map(source, destination);
        }
        public static IEnumerable<TResult> Map<TResult>(this IQueryable source)
        {
            return source.ProjectTo<TResult>(mapper.ConfigurationProvider);
        }
    }
}
