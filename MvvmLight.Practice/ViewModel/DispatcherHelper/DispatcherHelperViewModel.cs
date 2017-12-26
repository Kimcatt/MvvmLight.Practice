using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight.Practice.Model.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Threading;
using MvvmLight.Practice.Service.UserInfo;

namespace MvvmLight.Practice.ViewModel.DispatcherHelper
{
    public class DispatcherHelperViewModel : ViewModelBase
    {
        /// <summary>
        /// 构造行数
        /// </summary>
        public DispatcherHelperViewModel()
        {
            InitData();
            GalaSoft.MvvmLight.Threading.DispatcherHelper.Initialize();
        }


        #region 全局属性

        private ObservableCollection<UserParamModel> userList;
        /// <summary>
        /// 数据列表
        /// </summary>
        public ObservableCollection<UserParamModel> UserList
        {
            get { return userList; }
            set { userList = value; RaisePropertyChanged(() => UserList); }
        }

        private UserParamModel user;
        /// <summary>
        /// 当前用户信息
        /// </summary>
        public UserParamModel User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged(() => User); }
        }


        private Boolean isEnableForm;
        /// <summary>
        /// 是否表单可用
        /// </summary>
        public bool IsEnableForm
        {
            get { return isEnableForm; }
            set { isEnableForm = value; RaisePropertyChanged(() => IsEnableForm); }
        }

        private Boolean isWaitingDisplay;
        /// <summary>
        /// 是都显示延迟旋转框
        /// </summary>
        public bool IsWaitingDisplay
        {
            get { return isWaitingDisplay; }
            set { isWaitingDisplay = value; RaisePropertyChanged(() => IsWaitingDisplay); }
        }

        private Int32 processRange;
        /// <summary>
        /// 进度比例
        /// </summary>
        public int ProcessRange
        {
            get { return processRange; }
            set { processRange = value; RaisePropertyChanged(() => ProcessRange); }
        }

        #endregion


        #region 全局命令
        private RelayCommand addRecordCmd;
        /// <summary>
        /// 添加资源
        /// </summary>
        public RelayCommand AddRecordCmd
        {
            get
            {
                if (addRecordCmd == null) addRecordCmd = new RelayCommand(() => ExcuteAddRecordCmd());
                return addRecordCmd;
            }
            set
            {
                addRecordCmd = value;
            }
        }
        #endregion


        #region 辅助方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            UserList = new ObservableCollection<UserParamModel>()
            {
                 new UserParamModel(){ UserName="周杰伦", UserAdd="周杰伦地址", UserPhone ="88888888", UserSex="男" },
                 new UserParamModel(){ UserName="刘德华", UserAdd="刘德华地址", UserPhone ="88888888", UserSex="男" },
                 new UserParamModel(){ UserName="刘若英", UserAdd="刘若英地址", UserPhone ="88888888", UserSex="女" }
            };
            User = new UserParamModel();
            IsEnableForm = true;
            IsWaitingDisplay = false;
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        private void ExcuteAddRecordCmd()
        {
            UserParamModel up = new UserParamModel { UserAdd = User.UserAdd, UserName = User.UserName, UserPhone = User.UserPhone, UserSex = User.UserSex };
            UserInfoBuilder creatUser = new UserInfoBuilder(up);
            creatUser.CreateProcess += new EventHandler<UserInfoBuilder.CreateArgs>(CreateProcess);
            creatUser.Create();
            IsEnableForm = false;
            IsWaitingDisplay = true;
        }

        /// <summary>
        /// 创建进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CreateProcess(object sender, UserInfoBuilder.CreateArgs args)
        {
            GalaSoft.MvvmLight.Threading.DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                if (args.isFinish)
                {
                    if (args.userInfo != null)
                    {
                        UserList.Add(args.userInfo);
                    }

                    IsEnableForm = true;
                    IsWaitingDisplay = false;
                }
                else
                {
                    ProcessRange = args.process;
                }
            });
        }
        #endregion

    }
}
