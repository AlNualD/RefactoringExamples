using System.Collections.Generic;

namespace RefactoringExamples.IntroduceNullObject
{
    public class RecommendationsConstructorRefactored
    {
        public List<string> GetFavoriteThemesRefactored(UserRefactored user)
        {
            var curUser = user ?? new NullUserRefactored();

            return curUser.Favorites;
        }
    }

    public class UserRefactored
    {
        public UserRefactored()
        {
            Favorites = new List<string>();
        }

        public virtual List<string> Favorites { get; }

        public bool IsFavorite(string item)
        {
            return Favorites.Contains(item);
        }

        public virtual bool IsNull()
        {
            return false;
        }
    }

    public class NullUserRefactored : UserRefactored
    {
        public override List<string> Favorites =>
            new()
            {
                "adf",
                "adsfff",
                "1111"
            };

        public override bool IsNull()
        {
            return true;
        }
    }
}