using System.Collections.Generic;

namespace RefactoringExamples.IntroduceNullObject
{
    public class RecommendationsConstructor
    {
        public List<string> GetFavoriteThemes(User user)
        {
            if (user == null)
            {
                return DefaultFavorites();
            }

            return user.Favorites;

        }

        private List<string> DefaultFavorites()
        {
            return new List<string>
            {
                "adf",
                "adsfff",
                "1111"
            };
        }
    }

    public class User
    {
        public User()
        {
            Favorites = new List<string>();
        }

        public List<string> Favorites { get; }

        public bool IsFavorite(string item)
        {
            return Favorites.Contains(item);
        }
        
        
    }
}