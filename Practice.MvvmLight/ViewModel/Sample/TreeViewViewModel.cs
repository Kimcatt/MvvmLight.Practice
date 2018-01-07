using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Practice.MvvmLight.Model.Sample;

namespace Practice.MvvmLight.ViewModel.Sample
{
    public class TreeViewViewModel : ViewModelBase
    {
        public TreeViewViewModel()
        {
            InitTreeInfo();
        }

        private void InitTreeInfo()
        {
            TreeInfo = new List<TreeNodeModel>()
            {
                new TreeNodeModel(){
                  NodeID = "1", NodeName = "苹果",Children=new List<TreeNodeModel>(){
                    new TreeNodeModel(){ NodeID="1.1", NodeName ="苹果A" },
                    new TreeNodeModel(){ NodeID="1.2", NodeName ="苹果B" },
                    new TreeNodeModel(){ NodeID="1.3", NodeName ="苹果C",Children = new List<TreeNodeModel>(){
                       new TreeNodeModel(){ NodeID="1.3.1", NodeName ="苹果C1" },
                       new TreeNodeModel(){ NodeID="1.3.2", NodeName ="苹果C2" },
                    } },

                  }
                },
                new TreeNodeModel(){
                  NodeID = "2", NodeName = "香蕉",Children=new List<TreeNodeModel>(){
                    new TreeNodeModel(){ NodeID="2.1", NodeName ="香蕉A" },
                    new TreeNodeModel(){ NodeID="2.2", NodeName ="香蕉B" },
                    new TreeNodeModel(){ NodeID="2.3", NodeName ="香蕉C" }
                  }
                }
            };
        }

        #region 树控件

        private List<TreeNodeModel> treeInfo;
        /// <summary>
        /// 树控件数据信息
        /// </summary>
        public List<TreeNodeModel> TreeInfo
        {
            get { return treeInfo; }
            set { treeInfo = value; RaisePropertyChanged(() => TreeInfo); }
        }


        #endregion
    }
}
