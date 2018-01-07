using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Practice.MvvmLight.Model.Sample;
using GalaSoft.MvvmLight.Command;

namespace Practice.MvvmLight.ViewModel.Sample
{
    public class RadioButtonGroupViewModel : ViewModelBase
    {
        public RadioButtonGroupViewModel()
        {
            InitCompRadio();
        }

        private void InitCompRadio()
        {
            RadioButtons = new List<CompBottonModel>()
            {
                 new CompBottonModel(){ Content="苹果", IsCheck = false },
                 new CompBottonModel(){ Content="香蕉", IsCheck = false },
                 new CompBottonModel(){ Content="梨", IsCheck = false },
                 new CompBottonModel(){ Content="樱桃", IsCheck = false },
            };
        }
        
        private List<CompBottonModel> radioButtons;
        /// <summary>
        /// 组合单选框列表
        /// </summary>
        public List<CompBottonModel> RadioButtons
        {
            get { return radioButtons; }
            set
            {
                radioButtons = value; RaisePropertyChanged(() => RadioButtons);
            }
        }

        private CompBottonModel radioButton;
        /// <summary>
        /// 组合单选框 选中值
        /// </summary>
        public CompBottonModel RadioButton
        {
            get { return radioButton; }
            set { radioButton = value; RaisePropertyChanged(() => RadioButton); }
        }
        private RelayCommand radioCheckCommand;
        /// <summary>
        /// 单选框命令
        /// </summary>
        public RelayCommand RadioCheckCommand
        {
            get
            {
                if (radioCheckCommand == null)
                    radioCheckCommand = new RelayCommand(() => ExcuteRadioCommand());
                return radioCheckCommand;

            }
            set { radioCheckCommand = value; }
        }
        private void ExcuteRadioCommand()
        {
            RadioButton = RadioButtons.Where(p => p.IsCheck).First();
        }

    }
}
