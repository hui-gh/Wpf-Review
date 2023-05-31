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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_Review01.CustomPropety;

namespace Wpf_Review01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            CustomProperty();
            CodeBing();

        }
        /// <summary>
        /// 绑定客制属性
        /// </summary>
        public void CustomProperty() {
            //CusProperty.SetBinding(TextBox.TextProperty, new Binding("MyText") { Source = new Customcls() }); //方式一
            this.DataContext = new Customcls();
        }
        /// <summary>
        /// CodeBinding
        /// </summary>
        public void CodeBing()
        {
            //this.MyCodeBinding.SetBinding(TextBox.TextProperty, new Binding("Text") { Source = MySource, Mode = BindingMode.TwoWay, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged }); //方式一
            BindingOperations.SetBinding(MyCodeBinding, TextBox.TextProperty, new Binding("Text") { Source = MySource, Mode = BindingMode.TwoWay, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged }); //方式二

            //以下代码获取元素的绑定信息，再修改Binding后再重新进行绑定
            //Binding binding = BindingOperations.GetBinding(this.MyCodeBinding, TextBlock.TextProperty);
            //获取绑定以后可以修改 bindig 的属性
            //binding.Mode = BindingMode.TwoWay;
            //...
            //修改过后可以重先设置绑定
            //BindingOperations.SetBinding(this.tb,TextProperty,binding); 
        }
    }
}
