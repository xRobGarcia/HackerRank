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
            string s = @"   UserName: admin;
                            UserName: anotherAdmin;
                            Password: super password;

                            TimeToLive: 4;
                            IsEnabled: true;   
                            1QuePedo: true;   
                        ";


            var parser = new Parser();
            var r = parser.Parse(s);

            try
            {

                Console.WriteLine(r.UserName);
                Console.WriteLine(r.Password);
                Console.WriteLine(r.TimeToLive);
                Console.WriteLine(r.IsEnabled);
                Console.ReadKey();
            }
            catch (RuntimeBinderException)
            {
                //If someone tries to read a property (a key) which is not found in a configuration file then an exception should be thrown (in the following way: throw new UnknownKeyException();).
                throw new UnknownKeyException(); 
            }
        }

        [Serializable]
        private class UnknownKeyException : Exception
        {
            public UnknownKeyException()
            {
            }

            public UnknownKeyException(string message) : base(message)
            {
            }

            public UnknownKeyException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected UnknownKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }

}
