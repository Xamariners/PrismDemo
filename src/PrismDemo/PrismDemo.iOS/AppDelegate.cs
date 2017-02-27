using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Azure.Mobile;
using UIKit;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace PrismDemo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            MobileCenter.Configure("a6877052-0ac1-4bb7-84ef-3720ff95d20f");
            LoadApplication(new App(new iOSInitializer()));

			#if ENABLE_TEST_CLOUD
			// requires Xamarin Test Cloud Agent
			Xamarin.Calabash.Start();
			#endif

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            
        }
    }

}
