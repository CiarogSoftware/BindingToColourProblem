using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingToColourProblem.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public string greenProperty { get; set; }
        
        public string MyGreen {get { return "#8ec274"; } }
        public Color MyGreenColor { get => Color.FromArgb(MyGreen);}

        
        public MainPageViewModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        
    

    }
}
