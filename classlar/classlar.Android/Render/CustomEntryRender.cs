using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;

using classlar.Droid.Render;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRender))]

namespace classlar.Droid.Render
{
   
    public class CustomEntryRender :EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                //entry şekli
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                gradientDrawable.SetColor(Android.Graphics.Color.LightGray);    
                Control.SetBackground(gradientDrawable);
                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight,
                Control.PaddingBottom);

                //entry içindeki imleç renginin kodu renk için values e git.
                IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
                JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, Resource.Drawable.my_cursor);
            }
          
        }

      
    }
}
