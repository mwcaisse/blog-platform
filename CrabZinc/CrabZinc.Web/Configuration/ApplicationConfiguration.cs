﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrabZinc.Web.Configuration
{
    public class ApplicationConfiguration
    {
        private string _rootPathPrefix;
        public string RootPathPrefix
        {
            get
            {
                return _rootPathPrefix;
            }
            set
            {
                _rootPathPrefix = value;
                if (string.IsNullOrWhiteSpace(_rootPathPrefix))
                {
                    _rootPathPrefix = "";
                }
                else
                {
                    if (!_rootPathPrefix.StartsWith("/"))
                    {
                        _rootPathPrefix = "/" + RootPathPrefix;
                    }
                    _rootPathPrefix = _rootPathPrefix.TrimEnd('/');
                }
            }
        }

        public string PrefixUrl(string url)
        {
            return $"{RootPathPrefix}/{url.TrimStart('/')}";
        }
    }
}
