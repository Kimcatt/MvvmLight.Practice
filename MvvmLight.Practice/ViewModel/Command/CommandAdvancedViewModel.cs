using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight.Practice.Model.Command;
using System.Windows;
using MvvmLight.Practice.Model.Sample;

namespace MvvmLight.Practice.ViewModel.Command
{
    public class CommandAdvancedViewModel : ViewModelBase
    {
        
        public CommandAdvancedViewModel()
        {
            ObjParam = new UserParamModel();
            ArgsTo = new UserParamModel();
            //构造 Todo
            ResType = new ResTypeModel()
            {
                SelectIndex = 0,
                List = new List<ComplexInfoModel>() {
                    new ComplexInfoModel() { Key="0", Text="请选择..." },
                    new ComplexInfoModel() { Key="1", Text="苹果" },
                    new ComplexInfoModel() { Key="2", Text="香蕉" },
                    new ComplexInfoModel() { Key="3", Text="樱桃"} }
            };
        }
        
        #region 传递单个参数

        private String argStrTo;
        //目标参数
        public String ArgStrTo
        {
            get { return argStrTo; }
            set { argStrTo = value; RaisePropertyChanged(() => ArgStrTo); }
        }

        #endregion

        #region 命令

        private RelayCommand<String> passArgStrCommand;
        /// <summary>
        /// 传递单个参数命令
        /// </summary>
        public RelayCommand<String> PassArgStrCommand
        {
            get
            {
                if (passArgStrCommand == null)
                    passArgStrCommand = new RelayCommand<String>((p) => ExecutePassArgStr(p));
                return passArgStrCommand;

            }
            set { passArgStrCommand = value; }
        }
        private void ExecutePassArgStr(String arg)
        {
            ArgStrTo = arg;
        }

        #endregion


        #region 传递参数对象

        private UserParamModel objParam;
        public UserParamModel ObjParam
        {
            get { return objParam; }
            set { objParam = value; RaisePropertyChanged(() => ObjParam); }
        }

        #endregion

        #region 命令
        private RelayCommand<UserParamModel> passArgObjCmd;
        public RelayCommand<UserParamModel> PassArgObjCmd
        {
            get
            {
                if (passArgObjCmd == null)
                    passArgObjCmd = new RelayCommand<UserParamModel>((p) => ExecutePassArgObj(p));
                return passArgObjCmd;
            }
            set { passArgObjCmd = value; }
        }
        private void ExecutePassArgObj(UserParamModel up)
        {
            ObjParam = up;
        }
        #endregion

        #region 动态参数传递

        private UserParamModel argsTo;
        /// <summary>
        /// 动态参数传递
        /// </summary>
        public UserParamModel ArgsTo
        {
            get { return argsTo; }
            set { argsTo = value; RaisePropertyChanged(() => ArgsTo); }
        }

        #endregion
        //=================================================================================================================
        private RelayCommand<UserParamModel> dynamicParamCmd;
        /// <summary>
        /// 动态参数传递
        /// </summary>
        public RelayCommand<UserParamModel> DynamicParamCmd
        {
            get
            {
                if (dynamicParamCmd == null)
                    dynamicParamCmd = new RelayCommand<UserParamModel>(p => ExecuteDynPar(p));
                return dynamicParamCmd;
            }
            set
            {

                dynamicParamCmd = value;
            }
        }

        private void ExecuteDynPar(UserParamModel up)
        {
            ArgsTo = up;
        }

        //==============================================================================//
        private String fileAdd;
        /// <summary>
        /// 原事件参数
        /// </summary>
        public String FileAdd
        {
            get { return fileAdd; }
            set { fileAdd = value; RaisePropertyChanged(() => FileAdd); }
        }


        private RelayCommand<DragEventArgs> dropCommand;
        /// <summary>
        /// 传递原事件参数
        /// </summary>
        public RelayCommand<DragEventArgs> DropCommand
        {
            get
            {
                if (dropCommand == null)
                    dropCommand = new RelayCommand<DragEventArgs>(e => ExecuteDrop(e));
                return dropCommand;
            }
            set { dropCommand = value; }
        }

        private void ExecuteDrop(DragEventArgs e)
        {
            FileAdd = ((System.Array)e.Data.GetData(System.Windows.DataFormats.FileDrop)).GetValue(0).ToString();
        }

        //=====================================================================================//
        #region 事件转命令执行

        private String selectInfo;
        /// <summary>
        /// 选中信息
        /// </summary>
        public String SelectInfo
        {
            get { return selectInfo; }
            set { selectInfo = value; RaisePropertyChanged(() => SelectInfo); }
        }



        private ResTypeModel resType;
        /// <summary>
        /// 资源类型列表
        /// </summary>
        public ResTypeModel ResType
        {
            get { return resType; }
            set { resType = value; RaisePropertyChanged(() => ResType); }
        }

        #endregion

        private RelayCommand selectCommand;
        /// <summary>
        /// 事件转命令执行
        /// </summary>
        public RelayCommand SelectCommand
        {
            get
            {
                if (selectCommand == null)
                    selectCommand = new RelayCommand(() => ExecuteSelect());
                return selectCommand;
            }
            set { selectCommand = value; }
        }
        private void ExecuteSelect()
        {
            if (ResType != null && ResType.SelectIndex > 0)
            {
                SelectInfo = ResType.List[ResType.SelectIndex].Text;
            }
        }

    }
}
