using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class NegozioItem : ContentView
{
    NegozioItemViewModel ViewModel;
    public NegozioItem()
    {
        InitializeComponent();
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        ViewModel = (NegozioItemViewModel)BindingContext;
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        //fram.LayoutTo(Rect.FromLTRB(0,0,300,200));

        //if (this.AnimationIsRunning("TransitionAnimation"))
        //return;

        ((NegozioItemViewModel)BindingContext).Preferred = !((NegozioItemViewModel)BindingContext).Preferred;
    }
    bool ScrollSet = false;
    private void SfEffectsView_TouchUp(object sender, EventArgs e)
    {
        if (!ScrollSet)
        {
            var scroll = (ScrollView)Parent.Parent.Parent.Parent;
            var content = scroll.Content;
            scroll.Content = null;
            scroll.Content = content;
            ScrollSet = true;
        }

        var anim = new[]{
            new[]{120, 260 },
            new[]{60, 36 }
        };
        if (ViewModel.IsExpanded)
        {
            anim[0] = new[] { 260, 120 };
            anim[1] = new[] { 36, 60 };
        }

        var animation = new Animation
        {
            {0,1,new(v => Frame.HeightRequest = v, anim[0][0], anim[0][1], Easing.CubicInOut) },
            {0.5, 1, new(v => Frame.CornerRadius = (float)v, anim[1][0], anim[1][1], Easing.CubicInOut)}
        };
        animation.Commit(this, "TransitionAnimation", 16, 500);
        
        ViewModel.IsExpanded=!ViewModel.IsExpanded;

        //var inf = new Random().Next(20, 250);
        //((NegozioItemViewModel)BindingContext).GridRows = new RowDefinitionCollection() { new RowDefinition(inf) };

    }
}