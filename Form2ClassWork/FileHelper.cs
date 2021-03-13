using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form2ClassWork
{
    class FileHelper
    {
        public static void JsonSerialize(string filename, User user)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{filename}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }

        public static User JsonDeserialize(string filename)

        {
            User user = new User();
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader($"{filename}.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    user = serializer.Deserialize<User>(jr);
                }
            }
            return user;
        }
    }
}
