using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_net.framework_animation
{
    /// <summary>
    /// Interaction logic for LocalAnimationExample.xaml
    /// </summary>
    public partial class LocalAnimationExample : Page
    {
        public LocalAnimationExample()
        {
            InitializeComponent();

            WindowTitle = "Local Animation Example";
            var myStackPanel = new StackPanel { Margin = new Thickness(20) };


            // Create and set the Button.
            var aButton = new Button { Content = "A Button" };

            // Animate the Button's Width.
            var myDoubleAnimation = new DoubleAnimation
            {
                From = 75,
                To = 300,
                Duration = new Duration(TimeSpan.FromSeconds(5)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Apply the animation to the button's Width property.
            aButton.BeginAnimation(WidthProperty, myDoubleAnimation);

            // Create and animate a Brush to set the button's Background.
            var myBrush = new SolidColorBrush { Color = Colors.Blue };

            var myColorAnimation = new ColorAnimation
            {
                From = Colors.Blue,
                To = Colors.Red,
                Duration = new Duration(TimeSpan.FromMilliseconds(7000)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Apply the animation to the brush's Color property.
            myBrush.BeginAnimation(SolidColorBrush.ColorProperty, myColorAnimation);
            aButton.Background = myBrush;

            // Add the Button to the panel.
            myStackPanel.Children.Add(aButton);
            Content = myStackPanel;
        }


    }
}
