//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("GettingStartedBound.Views.MainPage.xaml", "Views/MainPage.xaml", typeof(global::GettingStartedBound.MainPage))]

namespace GettingStartedBound {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::GettingStartedBound.FileManagerViewModel viewModel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.TreeView.SfTreeView treeView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            viewModel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::GettingStartedBound.FileManagerViewModel>(this, "viewModel");
            treeView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.TreeView.SfTreeView>(this, "treeView");
        }
    }
}
