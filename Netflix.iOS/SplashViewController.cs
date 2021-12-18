using Airbnb.Lottie;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace Netflix.iOS
{
    public partial class SplashViewController : UIViewController
    {
        public SplashViewController() : base() { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            var viewAnimation = LOTAnimationView.AnimationNamed("29313-netflix-logo-swoop");
            viewAnimation.ContentMode = UIViewContentMode.Center;
            
            View.AddSubview(viewAnimation);
            View.BackgroundColor = UIColor.Black;

            viewAnimation.Center = View.Center;

            viewAnimation.PlayWithCompletion((finished) =>
            {
                UIApplication.SharedApplication.Delegate.FinishedLaunching(
                    UIApplication.SharedApplication, new Foundation.NSDictionary());
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}