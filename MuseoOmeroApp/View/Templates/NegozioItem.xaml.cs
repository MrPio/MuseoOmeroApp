using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class NegozioItem : ContentView
{
	public NegozioItem()
	{
		InitializeComponent();
	}

    private void  TapGestureRecognizer_Tapped(object sender, EventArgs e)
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
            var scroll = (ScrollView)Parent.Parent;
            var content = scroll.Content;
            scroll.Content = null;
            scroll.Content = content;
            ScrollSet= true;
        }


        var animation = new Animation(v => ((NegozioItemViewModel)BindingContext).Height = v, 120, 260, Easing.CubicInOut);
        animation.Commit(this, "TransitionAnimation", 16, 500);

        //var inf = new Random().Next(20, 250);
        //((NegozioItemViewModel)BindingContext).GridRows = new RowDefinitionCollection() { new RowDefinition(inf) };

    }
}