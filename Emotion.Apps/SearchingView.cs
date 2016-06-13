using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Emotion.Apps
{
    public partial class SearchingView : MetroForm
    {
        Dictionary<string, string> lstparam = new Dictionary<string, string>();
        public SearchingView(string key)
        {
            InitializeComponent();
            searchView(key);
        }
        private void searchView(string key)
        {
            lstparam["address"] = key;
            webBrowser1.Navigate("https://www.google.com/search?q=" + lstparam["address"]);
        }
    }
}
