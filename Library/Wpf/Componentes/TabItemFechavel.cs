﻿using System.Windows;
using System.Windows.Controls;

namespace FusionLibrary.Wpf.Componentes
{
    /// <summary>
    ///     ========================================
    ///     .NET Framework 3.0 Custom Control
    ///     ========================================
    ///     Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///     Step 1a) Using this custom control in a XAML file that exists in the current project.
    ///     Add this XmlNamespace attribute to the root element of the markup file where it is
    ///     to be used:
    ///     xmlns:MyNamespace="clr-namespace:TabItemFechavelDemo"
    ///     Step 1b) Using this custom control in a XAML file that exists in a different project.
    ///     Add this XmlNamespace attribute to the root element of the markup file where it is
    ///     to be used:
    ///     xmlns:MyNamespace="clr-namespace:TabItemFechavelDemo;assembly=TabItemFechavelDemo"
    ///     You will also need to add a project reference from the project where the XAML file lives
    ///     to this project and Rebuild to avoid compilation errors:
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///     Step 2)
    ///     Go ahead and use your control in the XAML file. Note that Intellisense in the
    ///     XML editor does not currently work on custom controls and its child elements.
    ///     <MyNamespace:TabItemFechavel />
    /// </summary>
    public class TabItemFechavel : TabItem
    {
        public static readonly RoutedEvent CloseTabEvent =
            EventManager.RegisterRoutedEvent("CloseTab", RoutingStrategy.Bubble,
                typeof (RoutedEventHandler), typeof (TabItemFechavel));

        static TabItemFechavel()
        {
            //This OverrideMetadata call tells the system that this element wants to provide a style that is different than its base class.
            //This style is defined in themes\generic.xaml
            DefaultStyleKeyProperty.OverrideMetadata(typeof (TabItemFechavel),
                new FrameworkPropertyMetadata(typeof (TabItemFechavel)));
        }

        public event RoutedEventHandler CloseTab
        {
            add { AddHandler(CloseTabEvent, value); }
            remove { RemoveHandler(CloseTabEvent, value); }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var closeButton = GetTemplateChild("ButtonClose") as Button;
            if (closeButton != null)
                closeButton.Click += closeButton_Click;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CloseTabEvent, this));
        }
    }
}