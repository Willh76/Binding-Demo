using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Binding_Demo.Functions
{
    internal static class HelperFunctions
    {
        public static ViewModel.ViewModel GetViewModel()
        {
            return (Application.Current?.MainWindow as MainWindow)?.VM;
        }
    }
}
