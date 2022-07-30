using System.Text;

namespace TDD_Project
{
    public class Welcome
    {
        public const string HELLOMESSAGE = "Hello";
        public const string EMPTYNAME = "my friend";
        public const string HELLOMESSAGESHOUTED = "HELLO";

        public string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return $"{HELLOMESSAGE}, {EMPTYNAME}.";
            }
            else
            {
                if (name.ToUpper() == name)
                {
                    return $"{HELLOMESSAGESHOUTED}, {name.ToUpper()}!";
                }
                else
                {
                    return $"{HELLOMESSAGE}, {name}.";
                }
            }
        }
        private string ShoutedNamesMessage(List<string> shoutedNames)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" AND {HELLOMESSAGESHOUTED}");
            string toAppend = string.Empty;
            foreach (string shoutedName in shoutedNames)
            {
                if (shoutedNames.IndexOf(shoutedName) == shoutedNames.Count - 1)
                {
                    if(shoutedNames.Count==1)
                    {
                        toAppend = $" {shoutedName}!";
                    }
                    else
                    {
                        toAppend = $" AND {shoutedName}!";
                    }  
                }
                else
                {
                    if(shoutedNames.IndexOf(shoutedName)!=0)
                    {
                        toAppend = $", {shoutedName}";
                    }
                    else
                    {
                        toAppend = $" {shoutedName}";
                    }                   
                }
                sb.Append(toAppend);
            }
            return sb.ToString();
        }
        public List<string> DeleteCommas(List<string> names)
        {
            List<string> result = new List<string>();
            foreach (string name in names)
            {
                if (name.Contains(','))
                {
                    var splited = name.Split(", ").ToList();
                    splited.ForEach(item=>result.Add(item));
                }
                else
                {
                    result.Add(name);
                }
            }
            return result;
        }
        public string Greet(List<string> names)
        {
            StringBuilder message = new StringBuilder();
            
            List<string> namesWithoutComma = DeleteCommas(names);
            List<string> shoutedNames = new List<string>();

            message.Append(HELLOMESSAGE);

            bool listHasCapitals = false;
            string toAppend = string.Empty;

            foreach (string name in namesWithoutComma)
            {
                if (name.ToUpper() == name)
                {
                    listHasCapitals = true;
                    shoutedNames.Add(name);
                }
                else
                {
                    if (namesWithoutComma.IndexOf(name) == namesWithoutComma.Count - 1)
                    {
                        toAppend = $" and {name}.";
                    }
                    else
                    {
                        toAppend = $", {name}";
                    }
                    message.Append(toAppend);
                }
            }
            if (listHasCapitals)
            {
                message.Append(ShoutedNamesMessage(shoutedNames));
            }
            return message.ToString();
        }
    }
}
