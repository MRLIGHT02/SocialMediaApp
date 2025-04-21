using System;
using System.Collections.Generic;
using System.Linq;


namespace SocialMediaApp.Controls
{
    public class NullBorderClass:Entry
    {

        protected override void OnHandlerChanged()
            {
            base.OnHandlerChanged();
            SetBorderLessBackground();
            }
        private void SetBorderLessBackground()
            {
             
            }
    }
}
