﻿using NoSqlOperations.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlOperations.Interfaces
{
    public interface IRedisOperation
    {
        public void SetData<T>(T entity, string redisKey);
        public T? GetData<T>(string redisKey) where T : class;
        public List<T>? GetAllDataByKey<T>(string redisKey);
    }
}
