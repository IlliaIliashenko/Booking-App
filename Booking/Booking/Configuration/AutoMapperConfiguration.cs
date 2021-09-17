using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Booking.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static  IEnumerable<Type> GetAutoMapperProfilesFromAllAssemblies()
        {
            return from assembly in AppDomain.CurrentDomain.GetAssemblies()
                from aType in assembly.GetTypes()
                where aType.IsClass && !aType.IsAbstract && aType.IsSubclassOf(typeof(Profile))
                select aType;
        }
    }
}