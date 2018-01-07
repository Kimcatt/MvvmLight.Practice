/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Practice.MvvmLight"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Practice.MvvmLight.ViewModel.Basic;

namespace Practice.MvvmLight.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<AppViewModel>();
            //×Ô¼ºµÄViewModel
            SimpleIoc.Default.Register<WelcomeViewModel>();
            SimpleIoc.Default.Register<BothWayBindViewModel>();
            SimpleIoc.Default.Register<ViewModel.Bind.DataContextBindViewModel>();
            SimpleIoc.Default.Register<Sample.ComboBoxViewModel>();
            SimpleIoc.Default.Register<Sample.RadioButtonViewModel>();
            SimpleIoc.Default.Register<Sample.RadioButtonGroupViewModel>();
            SimpleIoc.Default.Register<Sample.CheckBoxGroupViewModel>();
            SimpleIoc.Default.Register<Sample.TreeViewViewModel>();
            SimpleIoc.Default.Register<Sample.ListBoxViewModel>();
            SimpleIoc.Default.Register<Sample.UserControlViewModel>();
            SimpleIoc.Default.Register<Validation.FormValidationViewModel>();
            SimpleIoc.Default.Register<Validation.ExceptionViewModel>();
            SimpleIoc.Default.Register<Validation.ValidationRuleViewModel>();
            SimpleIoc.Default.Register<Validation.DataErrorInfoViewModel>();
            SimpleIoc.Default.Register<Validation.DataAnnotationViewModel>();
            SimpleIoc.Default.Register<Validation.ValidationObjectViewModel>();
            SimpleIoc.Default.Register<Command.CommandBasicViewModel>();
            SimpleIoc.Default.Register<Command.CommandAdvancedViewModel>();
            SimpleIoc.Default.Register<DispatcherHelper.DispatcherHelperViewModel>();
        }

        public AppViewModel App
        {
            get { return ServiceLocator.Current.GetInstance<AppViewModel>(); }
        }

        public WelcomeViewModel Welcome
        {
            get { return ServiceLocator.Current.GetInstance<WelcomeViewModel>(); }
        }

        public BothWayBindViewModel BothWayBind
        {
            get { return ServiceLocator.Current.GetInstance<BothWayBindViewModel>(); }
        }

        public Bind.DataContextBindViewModel DataContextBind
        {
            get { return ServiceLocator.Current.GetInstance<Bind.DataContextBindViewModel>(); }
        }

        public Sample.ComboBoxViewModel ComboBox
        {
            get { return ServiceLocator.Current.GetInstance<Sample.ComboBoxViewModel>(); }
        }

        public Sample.RadioButtonViewModel RadioButton
        {
            get { return ServiceLocator.Current.GetInstance<Sample.RadioButtonViewModel>(); }
        }

        public Sample.RadioButtonGroupViewModel RadioButtonGroup
        {
            get { return ServiceLocator.Current.GetInstance<Sample.RadioButtonGroupViewModel>(); }
        }

        public Sample.CheckBoxGroupViewModel CheckBoxGroup
        {
            get { return ServiceLocator.Current.GetInstance<Sample.CheckBoxGroupViewModel>(); }
        }

        public Sample.TreeViewViewModel TreeView
        {
            get { return ServiceLocator.Current.GetInstance<Sample.TreeViewViewModel>(); }
        }

        public Sample.ListBoxViewModel ListBox
        {
            get { return ServiceLocator.Current.GetInstance<Sample.ListBoxViewModel>(); }
        }

        public Sample.UserControlViewModel UserControl
        {
            get { return ServiceLocator.Current.GetInstance<Sample.UserControlViewModel>(); }
        }

        public Validation.FormValidationViewModel FormValidation
        {
            get { return ServiceLocator.Current.GetInstance<Validation.FormValidationViewModel>(); }
        }

        public Validation.ExceptionViewModel Exception
        {
            get { return ServiceLocator.Current.GetInstance<Validation.ExceptionViewModel>(); }
        }

        public Validation.ValidationRuleViewModel ValidationRule
        {
            get { return ServiceLocator.Current.GetInstance<Validation.ValidationRuleViewModel>(); }
        }

        public Validation.DataErrorInfoViewModel DataErrorInfo
        {
            get { return ServiceLocator.Current.GetInstance<Validation.DataErrorInfoViewModel>(); }
        }

        public Validation.DataAnnotationViewModel DataAnnotation
        {
            get { return ServiceLocator.Current.GetInstance<Validation.DataAnnotationViewModel>(); }
        }

        public Validation.ValidationObjectViewModel ValidationObject
        {
            get { return ServiceLocator.Current.GetInstance<Validation.ValidationObjectViewModel>(); }
        }

        public Command.CommandBasicViewModel CommandBasic
        {
            get { return ServiceLocator.Current.GetInstance<Command.CommandBasicViewModel>(); }
        }

        public Command.CommandAdvancedViewModel CommandAdvanced
        {
            get { return ServiceLocator.Current.GetInstance<Command.CommandAdvancedViewModel>(); }
        }

        public DispatcherHelper.DispatcherHelperViewModel DispatcherHelper
        {
            get { return ServiceLocator.Current.GetInstance<Practice.MvvmLight.ViewModel.DispatcherHelper.DispatcherHelperViewModel>(); }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}