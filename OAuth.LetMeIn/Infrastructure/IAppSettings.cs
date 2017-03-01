using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.LetMeIn.Infrastructure
{
    public interface IClientSettings
    {
        string Id { get; }
        string Secret { get; set; }
        string RedirectUri { get; set; }
    }
}
