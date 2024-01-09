namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
    int counter = 0;
    int countdown = 0;

    List<Monkey> MonkeyList;
    int currIndex = 0;
    public  NewPage1()
    {
        InitializeComponent();
        
       
        MonkeyList = Monkey.GetMonkeys();
        InitializeControlls();
    }
    public void InitializeControlls()
    {
        AddLayout();
        AddImage();
       AddButtons();

    }

    private void AddButtons()
    {
        //btn 1
        StackLayout stk = this.Content as StackLayout;
        Button upBtn = new Button()
        {
            Text="למעלה",
            HorizontalOptions = LayoutOptions.Center, WidthRequest=200
            , HeightRequest=60,Margin=new Thickness(0,5,0,0)
        };
        Button downBtn = new Button()
        {
            Text="למטה",
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 200
          ,
            HeightRequest = 60,
            Margin = new Thickness(0, 5, 0, 0)
        };
        //btn 2
        upBtn.Clicked += Forward;
        downBtn.Clicked += Backwards;
        stk.Children.Insert(0,upBtn);

        stk.Children.Add(downBtn);
    }

    private void AddImage()
    {
        StackLayout stk = this.Content as StackLayout;
        Image img = new Image()
        {
            Aspect = Aspect.AspectFit,
            HeightRequest = 400,
            WidthRequest = 500,
            Source = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg"

        };
        stk.Children.Add(img);  

    }

    private void AddLayout()
    {
        StackLayout stackLayout= new StackLayout();
        stackLayout.Orientation = StackOrientation.Vertical;
        stackLayout.Padding=new Thickness(0);
        stackLayout.Spacing = 20;
        this.Content= stackLayout;
    }
    private void Forward(object sender, EventArgs e)
    {
        currIndex++;
        if (currIndex >= MonkeyList.Count) currIndex = 0;
        StackLayout stk = (StackLayout)this.Content;
        Image img = stk.Children[1] as Image;
        img.Source = MonkeyList[currIndex].Image;
    }
    private void Backwards(object sender, EventArgs e)
    {
        currIndex--;
        if (currIndex < 0) currIndex = MonkeyList.Count - 1;
        StackLayout stk = (StackLayout)this.Content;
        Image img = stk.Children[1] as Image;
        img.Source = MonkeyList[currIndex].Image;
    }

}