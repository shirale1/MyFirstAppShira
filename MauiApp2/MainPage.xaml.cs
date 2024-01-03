

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        List<Monkey> MonkeyList;
        int currIndex = 0;
        public MainPage()
        {
            InitializeComponent();
            MonkeyList = Monkey.GetMonkeys();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }
        private void backwards(object sender, EventArgs e)
        {
            currIndex--;
            if (currIndex < 0) currIndex = MonkeyList.Count - 1;
            monkeyImage.Source = MonkeyList[currIndex].Image;
        }
        private void forward(object sender, EventArgs e) {
            currIndex++;
            if (currIndex >= MonkeyList.Count) currIndex = 0;
            monkeyImage.Source = MonkeyList[currIndex].Image;
        }

        private void ChangeText(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if(bt.Text == "החזר טקסט")
            {
                bt.Text = "החלף שנה";
                lbl_Year.Text = "wellcome";
                img_image.Source = "https://media-cldnry.s-nbcnews.com/image/upload/t_fit-760w,f_auto,q_auto:best/streams/2013/May/130522/6C7536084-g-hlt-120105-puppy-423p.jpg";
            }
            else
            {
                bt.Text = "החזר טקסט";
                lbl_Year.Text = "goodbye";
                img_image.Source = "https://afikimdogs.co.il/wp-content/uploads/2018/04/golden_retriever.png";
            }
        }
    }
}