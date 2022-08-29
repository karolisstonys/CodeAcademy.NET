using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L042_Abstract
{
    public abstract class SearchEngine
    {
        public abstract string[] Search(string text);

        //public virtual string[]? Search(string text)
        //{
        //    return null;
        //}


        public virtual string[] Result()
        {
            return new string[]
            {
                "NO RESULT"
            };
        }
    }

    public class GoogleSearchEngine : SearchEngine
    {
        public override string[] Search(string text)
        {
            return new string[]
            {
                "Google result 1",
                "Google result 2",
                "Google result 3",
                "Google result 4",
                "Google result 5"
            };
        }
    }
    public class DuckDuckGoSearchEngine : SearchEngine
    {
        public override string[] Search(string text)
        {
            return new string[]
            {
                "DuckDuckGo result 1",
                "DuckDuckGo result 2",
                "DuckDuckGo result 3",
                "DuckDuckGo result 4",
                "DuckDuckGo result 5"
            };
        }

        public override string[] Result()
        {
            return new string[]
            {
                "DuckDuckGo result 1",
                "DuckDuckGo result 2",
                "DuckDuckGo result 3",
                "DuckDuckGo result 4",
                "DuckDuckGo result 5"
            };
        }
    }

}
