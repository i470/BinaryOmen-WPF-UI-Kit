using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Effects;

namespace BinaryOmen.Vrika.Wpf.Converters
{
    internal static class ShadowInfo
    {
        private static readonly IDictionary<ShadowDepth, DropShadowEffect> ShadowsDictionary;

        static ShadowInfo()
        {
            var resourceDictionary = new ResourceDictionary { Source = new Uri("pack://application:,,,/BinaryOmen.Vrika;component/Themes/BinaryOmen.Shadows.xaml", UriKind.Absolute) };

            ShadowsDictionary = new Dictionary<ShadowDepth, DropShadowEffect>
            {
                { ShadowDepth.Depth0, null },
                { ShadowDepth.Depth1, (DropShadowEffect)resourceDictionary["wpfShadowDepth1"] },
                { ShadowDepth.Depth2, (DropShadowEffect)resourceDictionary["wpfShadowDepth2"] },
                { ShadowDepth.Depth3, (DropShadowEffect)resourceDictionary["wpfShadowDepth3"] },
                { ShadowDepth.Depth4, (DropShadowEffect)resourceDictionary["wpfShadowDepth4"] },
                { ShadowDepth.Depth5, (DropShadowEffect)resourceDictionary["wpfShadowDepth5"] },
            };
        }

        public static DropShadowEffect GetDropShadow(ShadowDepth depth)
        {
            return ShadowsDictionary[depth];
        }
    }
}