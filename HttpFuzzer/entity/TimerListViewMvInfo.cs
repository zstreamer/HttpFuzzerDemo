﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveCoody.entity
{
    class TimerListViewMvInfo
    {
        private Int32 line;

        public Int32 Line
        {
            get { return line; }
            set { line = value; }
        }

        private Int32 column;

        public Int32 Column
        {
            get { return column; }
            set { column = value; }
        }

        private String msg;

        public String Msg
        {
            get { return msg; }
            set { msg = value; }
        }


    }
}
