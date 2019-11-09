﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NorthShoreSurfApp
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        const string ResourceId = "NorthShoreSurfApp.Resources.AppResources";
        public string Text { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;
            ResourceManager resourceManager = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);
            return resourceManager.GetString(Text, CultureInfo.CurrentCulture);
        }
    }

    public static class Extensions
    {

    }
}