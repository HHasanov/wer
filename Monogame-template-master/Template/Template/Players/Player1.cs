using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Players
{
    public class Player1
    {
        public Vector2 position;
        private Texture2D texture;

        public Sprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Draw(SpriteBatch sp)
        {
            sp.Draw(texture, position, null, Color.White);
        }
    }
}
