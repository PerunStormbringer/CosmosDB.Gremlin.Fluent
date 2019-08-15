﻿using System;

namespace CosmosDB.Gremlin.Fluent.Functions
{
    public static class SideEffectFunction
    {
        /// <summary>
        /// Perform some operation on the traverser and pass it to the next step unmodified
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="traversal"></param>
        /// <returns></returns>
        public static GremlinQueryBuilder SideEffect(this GremlinQueryBuilder builder, GremlinQueryBuilder traversal)
        {
            if (traversal == null)
                throw new ArgumentNullException(nameof(traversal));
            
            builder.AddArguments(traversal.GremlinArguments);
            return builder.Add($"sideEffect({traversal.Query})");
        }
    }
}
