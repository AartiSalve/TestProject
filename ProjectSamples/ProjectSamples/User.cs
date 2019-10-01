using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSamples
{

    public class City
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

    }

    public class State
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

    }

    public class Country
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

    }
        public class User
    {
        public int UserId
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string UserMobile
        {
            get;
            set;
        }
        public string UserEmail
        {
            get;
            set;
        }
        public string FaceBookUrl
        {
            get;
            set;
        }
        public string LinkedInUrl
        {
            get;
            set;
        }
        public string TwitterUrl
        {
            get;
            set;
        }
        public string PersonalWebUrl
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
    }
}
