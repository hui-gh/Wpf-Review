

using System.Windows;

namespace Wpf_Review02
{
    class DependencyTest : DependencyObject
    {
        public string Name
        {
            get { return (string)GetValue(dependencyProperty); }
            set { SetValue(dependencyProperty, value); }
        }
        public readonly static DependencyProperty dependencyProperty 
            = DependencyProperty.Register("Name",typeof(string),typeof(DependencyTest));
    }
}
