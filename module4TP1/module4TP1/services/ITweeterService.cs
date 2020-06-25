using module4TP1.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace module4TP1.services
{
    interface ITweeterService
    {
        bool authenticate(String user, String password);
        List<Tweet> getTweets();
    }
}
