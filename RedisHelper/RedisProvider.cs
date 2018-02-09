using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisHelper
{
    public class RedisProvider : IRedisProvider
    {
        public string Get(string key)
        {
            try
            {
                return RedisHelper.GetObjectKey(key);
            }
            catch (Exception ex)
            {
                //LOG
                return null;
            }
        }

        public string Get<T>(string key)
        {
            try
            {
                return RedisHelper.GetObjectKey<T>(key);
            }
            catch (Exception ex)
            {
                //LOG
                return null;
            }
        }

        public void Set(string key, string value)
        {
            try
            {
                RedisHelper.SetStringKey(key, value);
            }
            catch (Exception ex)
            {
                //LOG
            }
        }

        public void Set<T>(string key, T value)
        {
            try
            {
                RedisHelper.SetStringKey<T>(key, value);
            }
            catch (Exception ex)
            {
                //LOG
            }
        }

        public void Set(string key, string value, TimeSpan sp)
        {
            try
            {
                RedisHelper.SetStringKey(key, value, sp);
            }
            catch (Exception ex)
            {
                //LOG
            }
        }

        public void Set<T>(string key, T value, TimeSpan sp)
        {
            try
            {
                RedisHelper.SetStringKey<T>(key, value, sp);
            }
            catch (Exception ex)
            {
                //LOG
            }
        }

        public void Remove(string key)
        {
            try
            {
                RedisHelper.KeyDelete(key);
            }
            catch (Exception ex)
            {
                //LOG
            }
        }

        public List<string> SearchKeys(string key)
        {
            try
            {
                return RedisHelper.SearchKeys(key);
            }
            catch (Exception ex)
            {
                //LOG
                return null;
            }
        }

        public bool KeyExists(string key)
        {
            try
            {
                return RedisHelper.KeyExists(key);
            }
            catch (Exception ex)
            {
                //LOG
                return false;
            }
        }
    }
}
