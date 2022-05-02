using UnityEngine;
using UnityEngine.UI;
using Loxodon.Framework.Views;
using Loxodon.Framework.Binding;
using Loxodon.Framework.Binding.Builder;
using TMPro;
using Loxodon.Framework.ViewModels;

public class SampleView : Window
{
    [SerializeField]
    private Button _submitButton;

    [SerializeField]
    private TextMeshProUGUI _message;

    private SampleViewModel _viewModel;

    protected override void OnCreate(IBundle bundle)
    {
        _viewModel = new SampleViewModel();
        BindingSet<SampleView, SampleViewModel> bindingSet = this.CreateBindingSet(_viewModel);

        bindingSet.Bind(_message).For(v => v.text).To(vm => vm.Message).OneWay();
        bindingSet.Bind(_submitButton).For(v => v.onClick).To(vm => vm.Submit);
        bindingSet.Build();
    }

    public override void DoDismiss()
    {
        base.DoDismiss();
    }
}
