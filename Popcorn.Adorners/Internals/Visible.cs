﻿namespace Popcorn.Adorners.Internals
{
    using System.Windows;
    using System.Windows.Data;

    internal static class Visible
    {
        internal static readonly RoutedEvent IsVisibleChangedEvent = EventManager.RegisterRoutedEvent(
            "IsVisibleChanged",
            RoutingStrategy.Direct,
            typeof(RoutedEventHandler),
            typeof(Visible));

        private static readonly DependencyProperty IsVisibleProxyProperty = DependencyProperty.RegisterAttached(
            "IsVisibleProxy",
            typeof(bool?),
            typeof(Visible),
            new PropertyMetadata(default(bool?), OnIsVisibleProxyChanged));

        private static readonly RoutedEventArgs IsVisibleChangedEventArgs = new RoutedEventArgs(IsVisibleChangedEvent);

        internal static void Track(UIElement e)
        {
            if (e == null)
            {
                return;
            }

            if (BindingOperations.GetBindingExpression(e, IsVisibleProxyProperty) == null)
            {
                e.Bind(IsVisibleProxyProperty)
                 .OneWayTo(e, UIElement.IsVisibleProperty);
            }
        }

        internal static bool IsVisible(DependencyObject element)
        {
            if (element is UIElement fe)
            {
                return fe.IsVisible;
            }

            return false;
        }

        private static void OnIsVisibleProxyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((UIElement)d).RaiseEvent(IsVisibleChangedEventArgs);
        }
    }
}
