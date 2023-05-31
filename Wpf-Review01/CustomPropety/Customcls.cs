using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Review01.CustomPropety
{
    public  class Customcls:INotifyPropertyChanged
    {
        private string myText = "绑定了客制属性";
        public string MyText
        {
            get { return myText; } 
            set { myText = value;
                if (PropertyChanged != null) { 
                        this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs(myText));
                    }
                }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
