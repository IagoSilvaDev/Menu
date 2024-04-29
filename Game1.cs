using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameEngine;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private IScreen _MenuScreen;
    private IScreen _GameScreen;
    private IScreen _CreditScreen;
    private IScreen _currentScreen;


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    public void ChangeScreen(EScreen screenType)
    {
        switch(screenType)
        {
            case EScreen.Menu:
                _currentScreen = _MenuScreen; 
                break;
        case EScreen.Game:
                _currentScreen = _GameScreen;
                break;
            case EScreen.Credit:
                _currentScreen = _CreditScreen;
                break;
        }

        _currentScreen.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _MenuScreen = new MenuScreen();
        _MenuScreen.LoadContent(Content);

        _GameScreen = new GameScreen();
        _GameScreen.LoadContent(Content);

        _CreditScreen = new CreditScreen();
        _CreditScreen.LoadContent(Content);

        _currentScreen = _MenuScreen;
    }

    protected override void Initialize()
    {
        base.Initialize();

        Globals.GameInstance = this;
        _currentScreen.Initialize();

    }

    protected override void Update(GameTime gameTime)
    {

        _currentScreen.Update((float)gameTime.ElapsedGameTime.TotalSeconds);

        Input.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        _currentScreen.Draw(_spriteBatch);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}