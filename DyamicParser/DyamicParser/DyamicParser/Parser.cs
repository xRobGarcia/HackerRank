using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace DyamicParser
{
    internal class Parser : IParser
    {

        public dynamic Parse(string configuration)
        {
            // configuration = "";
            if (configuration == string.Empty || configuration == null)
            {
                //A parsing method should throw an exception ArgumentException if a provided string is null or empty.
                throw new ArgumentException();
            }
            else
            {
                //The parser should trim off all key names and all string values.
                string json = Regex.Replace(configuration, @"\s*([^\s]*)\s*:(?<=:)\s*(.*?)\s*(?=;);\s*", "\"$1\" : \"$2\",", RegexOptions.Multiline);

                string stringJSON = json.Trim().TrimEnd(',');
                dynamic dynamicJSON = JObject.Parse("{" + stringJSON + "}");

                JSONValidations(stringJSON, dynamicJSON);

                return dynamicJSON;
            }


        }

        private void JSONValidations(string stringJSON, dynamic dynamicJSON)
        {
            if (HaveJSONeDuplicateKeys(stringJSON))
            {
                throw new DuplicatedKeyException();
            }

            foreach (dynamic item in dynamicJSON)
            {
                //If a key name is null or empty then an exception should be thrown (in the following way: throw new EmptyKeyException();).
                if (item.Value == string.Empty || item.Value == null)
                {
                    throw new EmptyKeyException();
                }
                //If a key found in a configuration file cannot be used as a property in C# then an exception should be thrown (in the following way: throw new InvalidKeyException();). You can assume that a key name is correct if and only if it consists of letters (a–z and A–Z) and digits (0–9), and does not start with a digit.
                if (!Regex.IsMatch(item.Name, @"\A^[^0-9][a-zA-Z0-9]*\z", RegexOptions.Multiline))
                {
                    throw new InvalidKeyException();
                }
            }
        }

        private bool HaveJSONeDuplicateKeys(string stringJSON)
        {
            try
            {
                Dictionary<string, string> dictionary = stringJSON.Split(',').ToDictionary(item => item.Split(':')[0], item => item.Split(':')[1]);
            }
            catch (Exception ex)
            {
                if (ex.Message == "An item with the same key has already been added.")
                {
                    return true;
                }
            }
            return false;
        }

        private class EmptyKeyException : Exception
        {
            public EmptyKeyException() {}
            public EmptyKeyException(string message) : base(message) {}
            public EmptyKeyException(string message, Exception innerException) : base(message, innerException) {}
            protected EmptyKeyException(SerializationInfo info, StreamingContext context) : base(info, context) {}
        }

        private class InvalidKeyException : Exception
        {
            public InvalidKeyException() {}
            public InvalidKeyException(string message) : base(message) {}
            public InvalidKeyException(string message, Exception innerException) : base(message, innerException) {}
            protected InvalidKeyException(SerializationInfo info, StreamingContext context) : base(info, context) {}
        }

        private class DuplicatedKeyException : Exception
        {
            public DuplicatedKeyException() {}
            public DuplicatedKeyException(string message) : base(message) {}
            public DuplicatedKeyException(string message, Exception innerException) : base(message, innerException) {}
            protected DuplicatedKeyException(SerializationInfo info, StreamingContext context) : base(info, context) {}
        }
    }

    internal interface IParser
    {
        dynamic Parse(string configuration);
    }
}
