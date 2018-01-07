using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MvvmLight.Model.Sample
{
    public class TreeNodeModel : ObservableObject
    {
        public string NodeID { get; set; }
        public string NodeName { get; set; }
        public List<TreeNodeModel> Children { get; set; }
    }
}
