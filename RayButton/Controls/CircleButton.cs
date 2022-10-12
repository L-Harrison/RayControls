using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RayButton.Controls
{
    public class CircleButton:Button
    {
        static CircleButton()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleButton), new FrameworkPropertyMetadata(typeof(CircleButton)));
        }
    }
}
