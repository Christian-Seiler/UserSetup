using System.Linq;
using System.DirectoryServices;
using System.Collections.Generic;

namespace UserSetup
{
    public class Person
    {
        public static string getID()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
        }

        public static List<string> getInfo(string id)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://allpower.local", "intranet", "saarcos!50");
            DirectorySearcher search = new DirectorySearcher(entry);

            search.Filter = $"(&(objectClass=user)(samAccountName={id}))";
            search.SearchScope = SearchScope.Subtree;

            List<string> list = new List<string>();

            foreach (SearchResult result in search.FindAll())
            {
                // ID
                list.Add(GetProperty(result, "samAccountName"));
                // First Name
                list.Add(GetProperty(result, "givenName"));
                // Last Name
                list.Add(GetProperty(result, "sn"));
                // email address
                list.Add(GetProperty(result, "mail"));
            }

            return list;
        }

        public static string GetProperty(SearchResult result, string PropertyName)
        {
            if (result.Properties.Contains(PropertyName))
            {
                return result.Properties[PropertyName][0].ToString();
            }
            else
            {
                return string.Empty;
            }
        }


    }
}