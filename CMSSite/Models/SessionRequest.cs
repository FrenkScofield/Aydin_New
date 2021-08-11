
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

public static class SessionRequest
{
    private static IHttpContextAccessor _IHttpContextAccessor;

    public static void Configure(IHttpContextAccessor __IHttpContextAccessor)
    {
        _IHttpContextAccessor = __IHttpContextAccessor;
    }

    public static HttpContext _HttpContext => _IHttpContextAccessor.HttpContext;

    public static User _User
    {
        get
        {
            return _IHttpContextAccessor.HttpContext.Session.Get<User>("_user");
        }
        set { }
    }

    public static SiteConfig config
    {
        get
        {
            return _IHttpContextAccessor.HttpContext.Session.Get<SiteConfig>("config");
        }
        set { }
    }
    public static int LanguageID
    {
        get
        {
            return _IHttpContextAccessor.HttpContext.Session.Get<int>("LanguageID");
        }
        set { }
    }



}




