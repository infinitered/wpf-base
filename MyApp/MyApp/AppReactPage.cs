﻿using ReactNative;
using ReactNative.Modules.Core;
using ReactNative.Shell;
using System.Collections.Generic;

namespace MyApp
{
    internal class AppReactPage : ReactPage
    {
        public override string MainComponentName => "MyApp";

#if BUNDLE
        public override string JavaScriptBundleFile
        {
            get
            {
                return "ms-appx:///ReactAssets/index.windows.bundle";
            }
        }
#endif

        public override List<IReactPackage> Packages => new List<IReactPackage>
        {
            new MainReactPackage(),
        };

        public override bool UseDeveloperSupport
        {
            get
            {
#if !BUNDLE || DEBUG
                return true;
#else
                return false;
#endif
            }
        }
    }
}
