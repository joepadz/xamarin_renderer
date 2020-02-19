﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using CoreGraphics;
using CustomRenderer.iOS;
using CustomRenderer.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;

using Xamarin.Forms.Platform.iOS;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRenderersIOS))]
namespace CustomRenderer.iOS
{
    public class RoundedEntryRenderersIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.DeepPink.ToCGColor();
                Control.Layer.BackgroundColor = Color.LightGray.ToCGColor();
                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}