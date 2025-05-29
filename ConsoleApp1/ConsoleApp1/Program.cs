using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Connection
    {
        private string _host;
        private int _port;
        private string _password;
        private string _username;
        private string _db;


        public string host{ get{ return _host; } set { if (string.IsNullOrEmpty(value)) { this._host = value; } } }
        public int port { get { return _port; } set { this._port = value; } }
        public string password { get { return _password; } set { if (string.IsNullOrEmpty(value)) { this._password = value; } } }
        public string username { get { return _username; } set { if (string.IsNullOrEmpty(value)) { this._username = value;  } } }
        public string db { get { return _db; } set { if (string.IsNullOrEmpty(value)) { this._db = value; } } }

    
    
    
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();
            connection.host = "localhost";
            connection.port = Environment.ProcessorCount;
            Console.WriteLine(connection.port);
        }
    }
}
