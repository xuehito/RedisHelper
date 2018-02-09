using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisHelper
{
    public interface IRedisProvider
    {
        string Get(string key);
        string Get<T>(string key);
        void Set(string key, string value);
        void Set<T>(string key, T value);
        void Set(string key, string value, TimeSpan sp);
        void Set<T>(string key, T value, TimeSpan sp);
        void Remove(string key);
        List<string> SearchKeys(string key);
        bool KeyExists(string key);
    }
}
