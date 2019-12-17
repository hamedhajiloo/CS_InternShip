using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class Boomer
    {
        public event EventHandler Boom;
        public void Start()
        {
            OnBoom();
            OnBoom();
            OnBoom();
        }

        protected virtual void OnBoom()
        {
            Boom?.Invoke(this, EventArgs.Empty);
        }
    }
}
