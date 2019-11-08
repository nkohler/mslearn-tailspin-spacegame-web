namespace TailSpin.SpaceGame.Web.Models
{
    public class ProfileViewModel
    {
        // The player profile.
        private Profile _profile;
        public Profile Profile
        {
            get { return _profile; }
            set { _profile = value; }
        }
        // The player's rank according to the active filter.
        private string _rank;
        public string Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
    }
}