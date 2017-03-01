using System;

namespace OAuth.LetMeIn.Infrastructure
{
    public class UrlParameterAttribute : Attribute
    {
        public string ParamName { get; set; }
    }
}
