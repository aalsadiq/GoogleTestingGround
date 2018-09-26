using System.Collections.Generic;

namespace GoogleTestingGround
{
    class Email
    {
        // This function will work on normalizing the email get rid of . in the localName and ignore any thing after a +
        public static string NormalizeEmail(string email)
        {
            // splitting the email into localName and domainName at the @
            //  Also Splitting localName at the + to use the left side only and removing the . from the localName
            var localName = email.Split('@')[0].Split('+')[0].Replace(".","").ToUpper();
            var domainName = email.Split('@')[1];
            //var plusSignIndex = localName.IndexOf('+');

            /*// Checking if '+' exist in the localName
            if (plusSignIndex > 0)
            {
                // If '+' exist then only tak what is to the left of it
                localName = localName.Split('+')[0];
            }*/

            // return the email back
            return localName + "@" + domainName;
        }
 
        // This method finds any duplicates in a list of strings and spits out the number of duplicated emails
        public static int FindDuplicates(string[] emails)
        {
            var duplicates = 0;
            var emailDictionary = new Dictionary<string,int>();

            foreach (var email in emails)
            {
                // Normalizing the emails based on the criterias given using the NormilizeEmail function
                var normalizeEmail = NormalizeEmail(email);

                // Checking if the email already exists
                if (emailDictionary.ContainsKey(normalizeEmail) && emailDictionary[normalizeEmail] == 1)
                {
                    emailDictionary[normalizeEmail]++;
                    duplicates++;
                }
                // If it the email does not exist then add it to the dictonary 
                if (!emailDictionary.ContainsKey(normalizeEmail))
                {
                    emailDictionary.Add(normalizeEmail,1);
                }
            }
            return duplicates;
        }

        /*public static void Main(string[] args)
        {
            string[] l = {"a.b@example.com", "x@example.com", "x@exa.mple.com", "ab+1@example.com",
                "y@example.com", "y@example.com", "y@example.com" };
            int numberOfDuplicates = FindDuplicates(l);
            Console.WriteLine(numberOfDuplicates);
            Console.ReadKey();
        }*/
    }
}
