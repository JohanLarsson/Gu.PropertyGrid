﻿namespace Gu.Wpf.PropertyGrid
{
    using System.Runtime.CompilerServices;
    using System.Windows;

    public static class Keys
    {
        public static ResourceKey RootGridStyleKey { get; } = CreateKey();

        public static ResourceKey ItemsControlSettingListStyleKey { get; } = CreateKey();

        public static ResourceKey ItemsControlNestedSettingListStyleKey { get; } = CreateKey();

        public static ResourceKey NestedSettingListStyle { get; } = CreateKey();

        public static ResourceKey UnitSettingBaseStyleKey { get; } = CreateKey();

        public static ResourceKey SettingRowHeaderStyleKey { get; } = CreateKey();

        public static ResourceKey SettingRowInfoPresenterStyleKey { get; } = CreateKey();

        public static ResourceKey SettingRowOldValueStyleKey { get; } = CreateKey();

        public static ResourceKey SettingRowErrorStyleKey { get; } = CreateKey();

        public static ResourceKey SettingRowSuffixStyleKey { get; } = CreateKey();

        private static ComponentResourceKey CreateKey([CallerMemberName] string caller = null)
        {
            return new ComponentResourceKey(typeof(Keys), caller);
        }
    }
}