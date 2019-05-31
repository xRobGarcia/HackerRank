UserName: admin;
Password: super password;

TimeToLive: 4;
IsEnabled: true;

You can assume that:

A configuration file will always use the format shown above; i.e. each non-empty line will contain a key name, then a colon and then a value.
Key names are case sensitive.
A key value can be a Boolean (true, false), an integer (e.g. 1, −2, 44) or a string.
All values that are not Booleans or integers should be treated as strings.
Integer values can be safely stored in variables of type int.
Integer values will be written as a series of digits (and only digits), with an additional minus sign at the beginning for negative numbers.
A configuration file can contain empty lines.
Neither a key name nor a value will contain a colon.
Each line in a configuration file, except for empty lines, will have a semicolon at the end.

Additional requirements:

*done The parsing method should have the following signature: public dynamic Parse(string configuration);.
*done Every key name found in a configuration file should be exposed as a property of an object returned from a parser, e.g. var r = parser.Parse(s); Console.WriteLine(r.TimeToLive);. These properties should be of an appropriate type, i.e. bool, int or string.
*done A parsing method should throw an exception ArgumentException if a provided string is null or empty.
*done The parser should trim off all key names and all string values.
*done If someone tries to read a property (a key) which is not found in a configuration file then an exception should be thrown (in the following way: throw new UnknownKeyException();).
*done If a key name is null or empty then an exception should be thrown (in the following way: throw new EmptyKeyException();).
*done If a key found in a configuration file cannot be used as a property in C# then an exception should be thrown (in the following way: throw new InvalidKeyException();). You can assume that a key name is correct if and only if it consists of letters (a–z and A–Z) and digits (0–9), and does not start with a digit.
*done You should throw an exception (in the following way: throw new DuplicatedKeyException()) if a duplicated key name is found in a configuration file.