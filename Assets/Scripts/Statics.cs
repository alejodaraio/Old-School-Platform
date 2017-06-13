
namespace gamesvsalex
{
    #region Game Scenes
    public static class GameScenes
    {
        public enum SCENES
        {
            MAIN = 0,
            LEVEL_1 = 1,
            LEVEL_2 = 2,
            WIN = 3,
            GAMEOVER = 4,
            CREDITS = 5
        };

        public static int SceneIndex(SCENES scene)
        {
            return (int)scene;
        }
    }
    #endregion

    #region Game Inputs
    public static class GameInputs
    {
        public const string HORIZONTAL = "Horizontal";
        public const string VERTICAL = "Vertical";
    }
    #endregion

    #region Game Tags
    public static class GameTags
    {
        public const string PLAYER = "Player";
        public const string ENEMY = "Enemy";
        public const string PATROL_LIMIT = "Box";
        public const string SPAWN = "Spawn";
        public const string ITEM = "Item";
    }
    #endregion

    #region Game Texts
    public static class GameTexts
    {
        public const string SCORE_TEXT = "Score: ";
        public const string LIVES_TEXT = "x";
    }
    #endregion

}