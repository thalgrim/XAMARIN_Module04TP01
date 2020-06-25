using module4TP1.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace module4TP1.services
{
    class TwitterService : ITweeterService
    {
        public bool authenticate(string user, string password)
        {
            if (user.Equals("thalgrim") && password.Equals("123456")) 
            {
                return true;
            }

            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweet1 = new Tweet();
            tweet1.userIdentifier = "userIndentifier1";
            tweet1.userName = "userName1";
            tweet1.userPseudo = "userPseudo1";
            tweet1.creationDate = "25/06/2020";
            tweet1.identifier = "indentifier1";
            tweet1.text = "text1";

            var tweet2 = new Tweet();
            tweet1.userIdentifier = "userIndentifier2";
            tweet1.userName = "userName2";
            tweet1.userPseudo = "userPseudo2";
            tweet1.creationDate = "24/06/2020";
            tweet1.identifier = "indentifier2";
            tweet1.text = "text2";

            var tweet3 = new Tweet();
            tweet1.userIdentifier = "userIndentifier3";
            tweet1.userName = "userName3";
            tweet1.userPseudo = "userPseudo3";
            tweet1.creationDate = "26/06/2020";
            tweet1.identifier = "indentifier3";
            tweet1.text = "text3";

            var tweets = new List<Tweet>();
            tweets.Add(tweet1);
            tweets.Add(tweet2);
            tweets.Add(tweet3);

            return tweets;

        }
    }
}
