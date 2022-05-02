using System.Collections;
using UnityEngine;
using Loxodon.Framework.Contexts;
using Loxodon.Framework.Views;
using Loxodon.Framework.Binding;
using Loxodon.Framework.Services;
using Loxodon.Framework.Examples;

public class Startup : MonoBehaviour
{
    private ApplicationContext _context;

    private void Awake()
    {
        _context = Context.GetApplicationContext();

        // Register services
        IServiceContainer container = _context.GetContainer();
        container.Register<IUIViewLocator>(new ResourcesViewLocator ());

        var bundle = new BindingServiceBundle(_context.GetContainer());
        bundle.Start();
    }

    private IEnumerator Start()
    {
        // Create a window container
        var winContainer = WindowContainer.Create("MAIN");

        yield return null;

        IUIViewLocator locator = _context.GetService<IUIViewLocator>();
        var sampleView = locator.LoadWindow<SampleView>(winContainer, "SampleUI");
        sampleView.Create();
        ITransition transition = sampleView.Show().OnStateChanged((w, state) =>
        {
        });

        yield return transition.WaitForDone();
    }
}