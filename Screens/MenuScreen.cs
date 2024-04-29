using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public class MenuScreen : IScreen
{
    private Button _playButton;
    private Button _creditButton;
    private Button _exitButton;



    public void LoadContent(ContentManager content)
    {

        _playButton = new Button(content.Load<Texture2D>("Start1"), Play);
        _creditButton = new Button(content.Load<Texture2D>("Credits1"), Credit);
        _exitButton = new Button(content.Load<Texture2D>("Quit1"), Exit);

        
    }

    public void Initialize()
    {
        _playButton.Position = new Point(350, 200);
        _creditButton.Position = new Point(350, 250);
        _exitButton.Position = new Point(350, 300);
    }

    public void Update(float deltaTime)
    {
        _playButton.Update(deltaTime);
        _creditButton.Update(deltaTime);
        _exitButton.Update(deltaTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {

     
        _playButton.Draw(spriteBatch);
        _creditButton.Draw(spriteBatch);
        _exitButton.Draw(spriteBatch);

    
    }

    private void Play()
    {
        Globals.GameInstance.ChangeScreen(EScreen.Game);
    }
    private void Credit()
    {
        Globals.GameInstance.ChangeScreen(EScreen.Credit);
    }
    private void Exit()
    {
        Globals.GameInstance.Exit();
    }
}
