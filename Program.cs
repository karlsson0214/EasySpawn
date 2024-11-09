using EasyMonoGame;
using EasySpawn; // The namespace of your game.
// Set starting world.
EasyGame.Instance.ActiveWorld = new SpawnWorld();
// Run the game.
EasyGame.Instance.Run();