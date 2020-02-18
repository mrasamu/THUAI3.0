﻿using System;
using System.Collections.Generic;
using System.Text;
using static Logic.Constant.MapInfo;
using System.Configuration;
using Logic.Constant;
using Communication.Proto;

namespace Logic.Server
{
    public class Block : Obj
    {
        public int RefreshTime;//食物刷新点的食物刷新速率，毫秒


        public List<DishType> Task = null;//任务点的任务列表
        public Block(double x_t, double y_t, BlockType type_t) : base(x_t, y_t)
        {
            type = ObjType.Block;
            Layer = (int)MapLayer.BlockLayer;
            Movable = false;
            blockType = type_t;
            if (blockType == BlockType.FoodPoint)
            {
                dish = (DishType)Program.Random.Next(1, (int)DishType.Size1 - 1);
                RefreshTime = 4000;
                Console.WriteLine("食品刷新：地点（" + Position.x + "," + Position.y + "）, 种类 : " + dish);
                lock (Program.MessageToClientLock)
                {
                    Program.MessageToClient.GameObjectMessageList.Add(
                        this.ID,
                        new GameObjectMessage
                        {
                            ObjType = ObjTypeMessage.Block,
                            BlockType = BlockTypeMessage.FoodPoint,
                            DishType = (DishTypeMessage)dish,
                            Position = new XYPositionMessage { X = Position.x, Y = Position.y }
                        });
                }
            }
            else if (blockType == BlockType.TaskPoint)
            {
                Task = new List<DishType>();
                Task.Add(DishType.Apple);
                Task.Add(DishType.Banana);
                //new System.Threading.Timer(TaskProduce, null, 1000, Convert.ToInt32(ConfigurationManager.AppSettings["TaskRefreshTime"]));
                lock (Program.MessageToClientLock)
                {
                    Program.MessageToClient.GameObjectMessageList.Add(
                        this.ID,
                        new GameObjectMessage
                        {
                            ObjType = ObjTypeMessage.Block,
                            BlockType = BlockTypeMessage.TaskPoint,
                            DishType = (DishTypeMessage)dish,
                            Position = new XYPositionMessage { X = Position.x, Y = Position.y }
                        });
                }
            }
        }
        public override DishType GetDish(DishType t)
        {
            DishType temp = dish;
            dish = DishType.Empty;
            //lock (Program.MessageToClientLock)
            //    Program.MessageToClient.GameObjectMessageList[this.ID].DishType = (DishTypeMessage)dish;
            if (this.blockType == BlockType.FoodPoint) RefreshTimer.Change(RefreshTime, 0);
            return temp;
        }
        protected System.Threading.Timer _refreshTimer;
        public System.Threading.Timer RefreshTimer
        {
            get
            {
                if (this.blockType == BlockType.FoodPoint) _refreshTimer = _refreshTimer ?? new System.Threading.Timer(Refresh);
                else if(this.blockType == BlockType.TaskPoint) _refreshTimer = _refreshTimer ?? 
                        new System.Threading.Timer(TaskProduce, null, 1000, Convert.ToInt32(ConfigurationManager.AppSettings["TaskRefreshTime"]));
                return _refreshTimer;
            }
        }
        public void Refresh(object i)
        {
            dish = (DishType)Program.Random.Next(1, (int)DishType.Size1 - 1);
            lock (Program.MessageToClientLock)
                Program.MessageToClient.GameObjectMessageList[this.ID].DishType = (DishTypeMessage)dish;
            Console.WriteLine("食品刷新：地点（" + Position.x + "," + Position.y + "）, 种类 : " + dish);
        }

        public override void UseCooker()
        {
            string Material = "";

            SortedSet<DishType> dishTypeSet = new SortedSet<DishType>();
            foreach (var GameObject in WorldMap.Grid[(int)Position.x, (int)Position.y].GetLayer((int)MapLayer.ItemLayer))
            {
                if (GameObject is Dish)
                { dishTypeSet.Add(((Dish)GameObject).dish);GameObject.Parent = null; }
            }

            foreach (var dishType in dishTypeSet)
            {
                Material += dishType.ToString() + " ";
                
            }
            string result = ConfigurationManager.AppSettings[Material];
            System.Threading.Timer timer = new System.Threading.Timer(Cook, result, Convert.ToInt32(ConfigurationManager.AppSettings[result + "Time"]), 0);
            DishType GetResult(string s)
            {
                for (int i = 0; i < (int)DishType.Size2; i++)
                {
                    if ((Convert.ToString((DishType)i)) == s) return (DishType)i;
                }
                return DishType.DarkDish;
            }
            void Cook(object s)
            {
                if (s is string)
                    dish = GetResult((string)s);
            }
        }

        public void TaskProduce(object i)
        {
            DishType temp = DishType.Apple;//(Dish.Type)new Random().Next();
            Task.Add(temp);
            //new System.Threading.Timer(remove, temp,
                //Convert.ToInt32(ConfigurationManager.AppSettings["TaskTimeLimit"]), 0);

            void remove(object task)
            {
                if (task is DishType)
                    Task.Remove((DishType)task);
            }
        }

        public override int HandIn(DishType dish_t)
        {
            if (Task.Contains(dish_t))
            {
                Task.Remove(dish_t);
                return Convert.ToInt32(ConfigurationManager.AppSettings[dish_t.ToString() + "Score"]);//菜品名+Score，在App.config里加，里面有AppleScore
                //测试的时候能直接把食材交进去，比赛的只会产生菜品任务
            }
            return 0;
        }
    }
}
