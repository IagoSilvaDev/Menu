using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class CreditScreen : IScreen
{
    private SpriteFont font;
   



    public void LoadContent(ContentManager content)
    {

        font = content.Load<SpriteFont>("File");

    }

    public void Initialize()
    {
        
    }

    public void Update(float deltaTime)
    {
        if (Input.GetKeyDown(Keys.Escape))
        {
            Globals.GameInstance.ChangeScreen(EScreen.Menu);
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {


        spriteBatch.DrawString(font, "Alunos: ", new Vector2(200, 100), Color.Black);
        spriteBatch.DrawString(font, "Emerson Aquino da Costa Filho - 01501853", new Vector2(260, 100), Color.Black);
        spriteBatch.DrawString(font, "Iago Vitor Germano Albuquerque da Silva - 01565468", new Vector2(260, 150), Color.Black);
        spriteBatch.DrawString(font, "Nicolas Rafael Silva Lucena - 01565072", new Vector2(260, 200), Color.Black);
        spriteBatch.DrawString(font, "Renan Alves Zloccowick - 01529935", new Vector2(260, 250), Color.Black);


    }

  
}
