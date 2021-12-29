using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Wpf_net.framework_animation
{
    class SampleViewer: Window
    {
        public SampleViewer()
        {
            var tControl = new TabControl();
            var tItem = new TabItem { Header = "Local Animation Example" };
            var contentFrame = new Frame { Content = new LocalAnimationExample() };
            tItem.Content = contentFrame;
            tControl.Items.Add(tItem);
            //tItem = new TabItem { Header = "Interactive Animation Example" };
            //contentFrame = new Frame { Content = new InteractiveAnimationExample() };
            //tItem.Content = contentFrame;
            //tControl.Items.Add(tItem);

            Content = tControl;
            Title = "Local Animations Example";
        }
    }
}
