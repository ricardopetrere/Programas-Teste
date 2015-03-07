using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Power
{
    class Bola
    {
        public static Texture2D Textura;
        public static Viewport Tela;
        public Vector2 Localizacao = Vector2.Zero;

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Textura, Localizacao, Color.White);
        }
        public void Update(float tempo)
        {
            ButtonState estadoMouse = Mouse.GetState().LeftButton;
            bool estadoKey = Keyboard.GetState().IsKeyDown(Keys.Space);
            if (estadoMouse == ButtonState.Pressed)
            {
                System.Threading.Thread.Sleep(50);
                if(Mouse.GetState().LeftButton==ButtonState.Released)
                    Localizacao.Y-=10f;
            }
            if (!(Localizacao.Y + Textura.Height > Tela.Height))
                Localizacao.Y += 50*tempo;
            else
                Localizacao.Y -= 50*tempo;
        }
    }
}
