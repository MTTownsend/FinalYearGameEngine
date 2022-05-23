﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3351_Game_Engine
{
    interface IInputManager
    {
        void AddListener(EventHandler<IKeyboardInput> handler);
        void AddListener(EventHandler<IMouseInput> handler);
    }
}
