using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Power
{
    class Menu
    {
        public static Texture2D textura;
        public Vector2 location;
        public static Viewport tela;
        public void Draw(SpriteBatch s)
        {
            location.X = (tela.Width - textura.Width) / 2;
            location.Y = (tela.Height - textura.Height) / 2;
            s.Draw(textura, location, Color.Gray);
        }
    }

    class Sair
    {
        public static Texture2D textura;
        public Vector2 location;
        public void Draw(SpriteBatch s)
        {
            location.X = (Menu.tela.Width - textura.Width) / 2;
            location.Y = 300f;
            s.Draw(textura, location, Color.LightBlue);
        }
        public void Update(MouseState m)
        {
            if (m.LeftButton == ButtonState.Pressed)
                if ((m.X > location.X && m.X < location.X + textura.Width) &&
                    (m.Y > location.Y && m.Y < location.Y + textura.Height))
                    Game1.saindo = true;
        }
    }
}
