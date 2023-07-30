using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.UnityLib.Middleware
{

    public class GameService
    {
        static GameService _gameService;
        public GameService Singleton
        {
            get
            {
                if (_gameService == null) _gameService = new GameService();
                return _gameService;
            }
        }

        public GameService()
        {
            services = new Dictionary<string, object>();
        }
        static Dictionary<string, object> services;

        public void AddService<T>(T service)
        {
            services.Add(typeof(T).Name, service);
        }

        public T GetService<T>()
        {
            return (T)services[typeof(T).Name];
        }

        public void AddServiceByName<T>(string name, T service)
        {
            services.Add(name, service);
        }
        public T GetServiceByName<T>(string name)
        {
            return (T)services[name];
        }
    }
}
