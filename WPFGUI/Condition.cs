﻿using System;

namespace WPFGUI
{

    public class Condition
    {
        public int type;  //teacher ，student， all
        public int frequency;
        public DateTime starTime;
        public DateTime endTime;
        public int firstPrizeNumber; //抽奖人数
        public int secondPrizeNumber; //抽奖人数
        public int thirdPrizeNumber; //抽奖人数
        //public string[] prize;
        public string key;
    }
}