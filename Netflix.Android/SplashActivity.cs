﻿using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Com.Airbnb.Lottie;
using System;

namespace Netflix.Droid
{
    [Activity(Label = "SplashActivity", Theme = "@style/SplashTheme",
        MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity, Animator.IAnimatorListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Splash);

            var animationView = FindViewById<LottieAnimationView>(Resource.Id.animation_view);
            animationView.AddAnimatorListener(this);
        }

        public void OnAnimationCancel(Animator animation)
        {
            
        }

        public void OnAnimationEnd(Animator animation)
        {
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        public void OnAnimationRepeat(Animator animation)
        {
            
        }

        public void OnAnimationStart(Animator animation)
        {
            
        }

    }
}