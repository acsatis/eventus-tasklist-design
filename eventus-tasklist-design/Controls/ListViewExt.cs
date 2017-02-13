using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace eventus_tasklist_design.Controls
{
    public class ListViewExt : ListView
    {
        public Style HeaderItemStyle
        {
            get { return (Style)GetValue(HeaderItemStyleProperty); }
            set { SetValue(HeaderItemStyleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderItemStyle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderItemStyleProperty =
            DependencyProperty.Register("HeaderItemStyle", typeof(Style), typeof(ListViewExt), new PropertyMetadata(null));
        
        public ListViewExt()
        {
            this.Loaded += (sender, args) =>
            {
                if (HeaderItemStyle != null)
                {
                    //find headerItems
                    foreach (ListViewHeaderItem headerItem in FindVisualChildren<ListViewHeaderItem>((ListView)sender))
                    {
                        headerItem.Style = HeaderItemStyle;
                    }
                }
            };
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

    }
}
