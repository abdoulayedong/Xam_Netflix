using Netflix.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Netflix.PageModels
{
    public class MainPageModel : PageModelBase
    {
        public MainPageModel()
        {
            InitializeCarouselData();
            GetStartedCommand = new Command(async () =>
            {
                await CoreMethods.PushPageModel<SignInPageModel>();
            });

            OpenSignInPageCommand = new Command(async () =>
            {
                await CoreMethods.PushPageModel<SignInPageModel>();
            });
        }

        private ObservableCollection<Card> _cards;
        public ObservableCollection<Card> Cards
        {
            get { return _cards; }
            set => SetProperty(ref _cards, value);
        }

        private Card _selectedCard;

        public Card SelectedCard
        {
            get { return _selectedCard; }
            set 
            {
                SetProperty(ref _selectedCard, value); 
            }
        }


        private void InitializeCarouselData()
        {
            Cards = new ObservableCollection<Card>();
            Cards.Add(new Card() { Image = "screen.png", Title = "Trying to join Netflix", Description = "You can't sign up for Netflix in the app. We know it's a hassle." });
            Cards.Add(new Card() { Image = "screen1.png", Title = "Watch on any Device", Description = "Stream on your phone, tablet, laptop, and TV without paying more." });
            Cards.Add(new Card() { Image = "screen2.png", Title = "Download and Go", Description = "Save your data, watch offline on a plane,train, or rocket." });
            Cards.Add(new Card() { Image = "screen3.png", Title = "No pesky Contracts", Description = "Join today, cancel anytime." });
        }

        public ICommand GetStartedCommand { get; }
        public ICommand OpenSignInPageCommand { get; }
    }
}
