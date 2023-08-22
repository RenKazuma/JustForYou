using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Settings
    {
        public Font GetFont()
        {
            return new Font(FFamily, Size);
        }

        public float Size
        {
            get => _size;
            private set
            {
                _size = value;
                Changed?.Invoke(this, this);
            }
        }
        private float _size = 10;

        public FontFamily FFamily
        {
            get => _fFamily;
            private set
            {
                _fFamily = value;
                Changed?.Invoke(this, this);
            }
        }
        private FontFamily _fFamily = new FontFamily("Arial");

        public Color AccentColor
        {
            get => _accentColor; 
            set
            {
                _accentColor = value;
                Changed?.Invoke(this, this);
            }
        }
        private Color _accentColor = Color.FromArgb(255, 255, 0, 0);

        public event EventHandler<Settings> Changed;
    }

    
}
