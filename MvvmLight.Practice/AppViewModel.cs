using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;

namespace MvvmLight.Practice
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class AppViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public AppViewModel()
        {
            //if (IsInDesignMode)
            //{
            //    // Code runs in Blend --> create design time data.
            //}
            //else
            //{
            //    // Code runs "for real"
            //}

            basicBindCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(BasicBindCmd));
                new View.Bind.BasicBindView()
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            },
            (owner) => true);

            sourceBindCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(SourceBindCmd));
                new View.Bind.SourceBindView()
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            },
            (owner) => true);

            relativeSourceBindCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(RelativeSourceBindCmd));
                new View.Bind.RelativeSourceBindView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            dataContextBindCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(DataContextBindCmd));
                new View.Bind.DataContextBindView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            comboBoxSampleCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(ComboBoxSampleCmd));
                new View.Sample.ComboBoxView()
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            radioButtonCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(RadioButtonCmd));
                new View.Sample.RadioButtonView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            radioButtonGroupCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(RadioButtonGroupCmd));
                new View.Sample.RadioButtonGroupView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            checkBoxGroupCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(CheckBoxGroupCmd));
                new View.Sample.CheckBoxGroupView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            treeViewCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(TreeViewCmd));
                new View.Sample.TreeViewView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            listBoxCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(ListBoxCmd));
                new View.Sample.ListBoxView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            userControlCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(UserControlCmd));
                new View.Sample.UserControlView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            formValidationCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(FormValidationCmd));
                new View.Validation.FormValidationView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            exceptionValidationCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(ExceptionValidationCmd));
                new View.Validation.ExceptionView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            validationRuleValidationCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(ValidationRuleValidationCmd));
                new View.Validation.ValidationRuleView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            dataErrorInfoValidationCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(DataErrorInfoValidationCmd));
                new View.Validation.DataErrorInfoView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            dataAnnotationValidationCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(DataAnnotationValidationCmd));
                new View.Validation.DataAnnotationView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            validationObjectValidationCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(ValidationObjectValidationCmd));
                new View.Validation.ValidationObjectView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            commandBasicCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(CommandBasicCmd));
                new View.Command.CommandBasicView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            commandAdvancedCmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(nameof(CommandAdvancedCmd));
                new View.Command.CommandAdvancedView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            dispatcherHelperCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(DispatcherHelperCmd));
                new View.DispatcherHelper.DispatcherHelperView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            messengerCmd = new RelayCommand<Window>((owner) => 
            {
                SaveCmdName(nameof(MessengerCmd));
                new View.Messenger.MessengerView
                {
                    Owner = owner,
                    ShowInTaskbar = false
                }.ShowDialog();
            });

            //basicBindCmd = CreateCommand<View.Bind.BasicBindView>(nameof(BasicBindCmd));
            //sourceBindCmd = CreateCommand<View.Bind.SourceBindView>(nameof(SourceBindCmd));
            //relativeSourceBindCmd = CreateCommand<View.Bind.RelativeSourceBindView>(nameof(RelativeSourceBindCmd));
            //dataContextBindCmd = CreateCommand<View.Bind.DataContextBindView>(nameof(DataContextBindCmd));

            //CreateCommand(typeof(View.Bind.BasicBindView), nameof(BasicBindCmd), out basicBindCmd);
            //CreateCommand(typeof(View.Bind.SourceBindView), nameof(SourceBindCmd), out sourceBindCmd);
            //CreateCommand(typeof(View.Bind.RelativeSourceBindView), nameof(RelativeSourceBindCmd), out relativeSourceBindCmd);
            //CreateCommand(typeof(View.Bind.DataContextBindView), nameof(DataContextBindCmd), out dataContextBindCmd);
        }

        private void CreateCommand(Type t, string cmdName, out RelayCommand<Window> cmd)
        {
            cmd = new RelayCommand<Window>((owner) =>
            {
                SaveCmdName(cmdName);
                Window win = Activator.CreateInstance(t) as Window;
                try
                {
                    win.Owner = owner;
                    win.ShowInTaskbar = false;
                    win.ShowDialog();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            });
        }

        private RelayCommand<Window> CreateCommand<T>(string cmdName) where T : Window, new()
        {
            return new RelayCommand<Window>((o) =>
            {
                SaveCmdName(cmdName);
                T win = new T();
                win.Owner = o;
                win.ShowInTaskbar = false;
                win.ShowDialog();
            },
            (o) => true);
        }

        private void SaveCmdName(string cmdName)
        {
            CmdName = cmdName + System.Environment.NewLine;
        }

        #region Commands for binding

        /// <summary>
        /// 当前执行命令的名字
        /// </summary>
        private string cmdName;

        public string CmdName
        {
            get { return cmdName; }
            set
            {
                cmdName = value;
                RaisePropertyChanged(() => CmdName);
            }
        }

        /// <summary>
        /// 页面元素绑定
        /// </summary>
        private RelayCommand<Window> basicBindCmd;

        public RelayCommand<Window> BasicBindCmd
        {
            get { return basicBindCmd; }
        }


        /// <summary>
        /// 非页面元素绑定 - Source
        /// </summary>
        private RelayCommand<Window> sourceBindCmd;

        public RelayCommand<Window> SourceBindCmd
        {
            get { return sourceBindCmd; }
        }


        /// <summary>
        /// 非页面元素绑定  - RelativeSource
        /// </summary>
        private RelayCommand<Window> relativeSourceBindCmd;

        public RelayCommand<Window> RelativeSourceBindCmd
        {
            get { return relativeSourceBindCmd; }
        }

        /// <summary>
        /// 非页面元素绑定 - DataContext
        /// </summary>
        private RelayCommand<Window> dataContextBindCmd;

        public RelayCommand<Window> DataContextBindCmd
        {
            get { return dataContextBindCmd; }
        }

        private RelayCommand<Window> comboBoxSampleCmd;

        public RelayCommand<Window> ComboBoxSampleCmd
        {
            get { return comboBoxSampleCmd; }
        }

        private RelayCommand<Window> radioButtonCmd;

        public RelayCommand<Window> RadioButtonCmd
        {
            get { return radioButtonCmd; }
        }

        private RelayCommand<Window> radioButtonGroupCmd;

        public RelayCommand<Window> RadioButtonGroupCmd
        {
            get { return radioButtonGroupCmd; }
        }

        private RelayCommand<Window> checkBoxGroupCmd;

        public RelayCommand<Window> CheckBoxGroupCmd
        {
            get { return checkBoxGroupCmd; }
        }

        private RelayCommand<Window> treeViewCmd;

        public RelayCommand<Window> TreeViewCmd
        {
            get { return treeViewCmd; }
        }

        private RelayCommand<Window> listBoxCmd;

        public RelayCommand<Window> ListBoxCmd
        {
            get { return listBoxCmd; }
        }


        private RelayCommand<Window> userControlCmd;

        public RelayCommand<Window> UserControlCmd
        {
            get { return userControlCmd; }
        }

        private RelayCommand<Window> formValidationCmd;

        public RelayCommand<Window> FormValidationCmd
        {
            get { return formValidationCmd; }
        }

        private RelayCommand<Window> exceptionValidationCmd;

        public RelayCommand<Window> ExceptionValidationCmd
        {
            get { return exceptionValidationCmd; }
        }

        private RelayCommand<Window> validationRuleValidationCmd;

        public RelayCommand<Window> ValidationRuleValidationCmd
        {
            get { return validationRuleValidationCmd; }
        }

        private RelayCommand<Window> dataErrorInfoValidationCmd;

        public RelayCommand<Window> DataErrorInfoValidationCmd
        {
            get { return dataErrorInfoValidationCmd; }
        }

        private RelayCommand<Window> dataAnnotationValidationCmd;

        public RelayCommand<Window> DataAnnotationValidationCmd
        {
            get { return dataAnnotationValidationCmd; }
        }


        public RelayCommand<Window> validationObjectValidationCmd;

        public RelayCommand<Window> ValidationObjectValidationCmd
        {
            get { return validationObjectValidationCmd; }
        }

        private RelayCommand<Window> commandBasicCmd;

        public RelayCommand<Window> CommandBasicCmd
        {
            get { return commandBasicCmd; }
        }

        private RelayCommand<Window> commandAdvancedCmd;

        public RelayCommand<Window> CommandAdvancedCmd
        {
            get { return commandAdvancedCmd; }
        }

        private RelayCommand<Window> dispatcherHelperCmd;

        public RelayCommand<Window> DispatcherHelperCmd
        {
            get { return dispatcherHelperCmd; }
        }

        private RelayCommand<Window> messengerCmd;

        public RelayCommand<Window> MessengerCmd
        {
            get { return messengerCmd; }
        }

        #endregion

    }
}