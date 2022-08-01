using System.Text;

namespace TDD_Project
{
    public class Welcome
    {
        public const string HELLOMESSAGE = "Hello";
        public const string MYFRIEND = "my friend";
        public const string HELLOMESSAGESHOUTED = "HELLO";

        public string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return $"{HELLOMESSAGE}, {MYFRIEND}.";
            }

            if (name.ToUpper() == name)
            {
                return $"{HELLOMESSAGESHOUTED} {name}!";
            }

            return $"{HELLOMESSAGE}, {name}.";
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
                    if (shoutedNames.Count == 1)
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
                    if (shoutedNames.IndexOf(shoutedName) != 0)
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

        private List<string> CleanString(List<string> splited)
        {
            var cleanedList = new List<string>();
            foreach(var item in splited)
            {
                var newstring = item.Replace("\"", "");
                 cleanedList.Add( newstring);
            }
            return cleanedList;
        }

        private List<string> SplitEntity(List<string> names)
        {
            List<string> result = new List<string>();
            foreach (string name in names)
            {
                if (name.Contains(','))
                {
                    var splitedItems = name.Split(',', ' ').ToList();
                    splitedItems.RemoveAll(item => item == string.Empty);
                    result.AddRange(CleanString(splitedItems));
                }
                else
                {
                    result.Add(name);
                }
            }
            return result;
        }

        private string NormalNamesMessage(List<string> names,ref List<string> shoutedNames)
        {
            var message = new StringBuilder();
            message.Append(HELLOMESSAGE);
            var toAppend = string.Empty;
            foreach (string name in names)
            {
                if (name.ToUpper() == name)
                {
                    shoutedNames.Add(name);
                }
                else
                {
                    if (names.IndexOf(name) == names.Count - 1)
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
            return message.ToString();
        }
        public string Greet(List<string> names)
        {
            var namesWithoutComma = SplitEntity(names);

            var shoutedNames = new List<string>();

            var message = new StringBuilder();

            message.Append(NormalNamesMessage(namesWithoutComma, ref shoutedNames));

            if (shoutedNames.Count!=0)
            {
                message.Append(ShoutedNamesMessage(shoutedNames));
            }
            return message.ToString();
        }
    }
}
