using Practice.MvvmLight.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.MvvmLight.Service.UserInfo
{
    public class UserInfoBuilderWithMessenger
    {
        //待创建信息
        public UserParamModel up { get; set; }

        public UserInfoBuilderWithMessenger(UserParamModel _up)
        {
            up = _up;
        }

        public void Create()
        {
            Thread t = new Thread(Start);//抛出一个新线程
            t.Start();
        }

        private void Start()
        {
            UserInfoWrapper ui = new UserInfoWrapper();

            //ToDo：编写创建用户的DataAccess代码
            for (Int32 idx = 1; idx <= 10; idx++) //idx
            {
                Thread.Sleep(1000);
                ui = new UserInfoWrapper()
                {
                    isFinish = false,
                    process = idx * 10,
                    userInfo = null
                };
                //UI线程上发送
                GalaSoft.MvvmLight.Threading.DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<UserInfoWrapper>(ui, "UserMessenger");
                });
            }
            Thread.Sleep(1000);
            ui = new UserInfoWrapper()
            {
                isFinish = true,
                process = 100,
                userInfo = up
            };
            GalaSoft.MvvmLight.Threading.DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<UserInfoWrapper>(ui, "UserMessenger");
            });
        }



        /// <summary>
        /// 用户信息对象
        /// </summary>
        public class UserInfoWrapper
        {
            /// <summary>
            /// 是否创建结束
            /// </summary>
            public Boolean isFinish { get; set; }
            /// <summary>
            /// 进度
            /// </summary>
            public Int32 process { get; set; }
            /// <summary>
            /// 处理后的用户信息
            /// </summary>
            public UserParamModel userInfo { get; set; }
        }
    }
}
