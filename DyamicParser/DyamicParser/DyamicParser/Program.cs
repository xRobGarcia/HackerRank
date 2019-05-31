using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DyamicParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"   
                          UserName:admin;
                            Password:""super%^&*333password;
                            DNSName:SomeName;

                            TimeToLive:-33333;
                            ClusterSize:2;
                            PortNumber:2222;

                            IsEnabled:true;
                            EnsureTransaction:false;
                            PersistentStorage:false;
                        ";

            var parser = new Parser();
            var r = parser.Parse(s);


            try
            {

                Console.WriteLine(r.UserName);
                Console.WriteLine(r.Password);
                Console.WriteLine(r.DNSName);
                Console.WriteLine(r.TimeToLive);
                Console.WriteLine(r.ClusterSize);
                Console.WriteLine(r.PortNumber);
                Console.WriteLine(r.IsEnabled);
                Console.WriteLine(r.EnsureTransaction);
                Console.WriteLine(r.PersistentStorage);
                //Console.WriteLine(r.NoExiste);


            }
            catch (RuntimeBinderException)
            {
                //If someone tries to read a property (a key) which is not found in a configuration file then an exception should be thrown (in the following way: throw new UnknownKeyException();).
                throw new UnknownKeyException();
            }
            Console.ReadKey();
        }

        [Serializable]
        private class UnknownKeyException : Exception
        {
            //If someone tries to read a property (a key) which is not found in a configuration file then an exception should be thrown (in the following way: throw new UnknownKeyException();).
            public UnknownKeyException() {}
            public UnknownKeyException(string message) : base(message) {}
            public UnknownKeyException(string message, Exception innerException) : base(message, innerException) {}
            protected UnknownKeyException(SerializationInfo info, StreamingContext context) : base(info, context) {}
        }
    }
}
