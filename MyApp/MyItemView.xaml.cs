namespace MyApp;


public partial class MyItemView : ContentView
{
    public static readonly BindableProperty ItemTextProperty =
        BindableProperty.Create(nameof(ItemText), typeof(string), typeof(MyItemView), "", propertyChanged: ItemTextPropertyChanged);

    public string ItemText
    {
        get => (string)GetValue(ItemTextProperty);
        set => SetValue(ItemTextProperty, value);
    }

    public MyItemView()
    {
        InitializeComponent();
    }

    static async void ItemTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var view = bindable as MyItemView;
        var viewmode = view.BindingContext as MyViewModel;
        viewmode.ItemText = newValue?.ToString();
    }
}

public class MyViewModel : BindableObject
{
    //public static readonly BindableProperty ItemTextProperty =
    //    BindableProperty.Create(nameof(ItemText), typeof(string), typeof(MyViewModel), "");

    public string ItemText { get; set; }
}
